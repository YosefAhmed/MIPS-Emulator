using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MIPS_Emulator
{
	class RegesterFile
	{
		public int readReg1;
		public int readReg2;
		public int writeReg;
		public int writeData;
		public int readData1;
		public int readData2;
	}
	class IF_ID
	{
		public int PC;
		public int OP;
		public int RS;
		public int RT;
		public int RD;
		public int Offset;
		public int Funct;

		//public string ConvertToString()
		//{
		//	string regStr="";

		//	return regStr;
		//}
	}
	class ID_EX
	{
		public int ReadData1;
		public int ReadData2;
		public int Offset;
		public int IRegDst;
		public int RRegDst;
		public int ALUOp;
	}
	class EX_MEM
	{
		public int Result;
		public int Data2;
		public int RegDst;
		public int Funct;
	}
	class MEM_WB
	{
		public int ReadData;
		public int ALUResult;
		public int RegDst;
		public int Funct;

	}
	class MIPS
	{
		//array of integers represents 32 regesters
		public static int[] REGESTERS = new int[32];
		
		//program counter
		public static int PC;
		
		//IF/ID pipeline regester
		public static IF_ID IF_ID = new IF_ID();
		
		//ID/EX pipeline regester
		public static ID_EX ID_EX = new ID_EX();
		
		//EX/MEM pipeline regester
		public static EX_MEM EX_MEM = new EX_MEM();
		
		//MEM/WB pipeline regester
		public static MEM_WB MEM_WB = new MEM_WB();
		
		//array of integers represents 2KB Data Memory
		public static int[] MEMORY = new int[2000];
		
		/*dictionary contains the given instructions, 
		  as the key is the number of each instruction
		  and the value is a string of the machine code 
		  of each instruction*/
		public static Dictionary<int, string> INSTRUCTION_MEM = new Dictionary<int, string>();
		
		//Regester file
		public static RegesterFile RegesterFile = new RegesterFile();

		/// <summary>
		/// splits the instructions into PC and instruction machine code
		/// </summary>
		/// <param name="instructions">array of instructions string</param>
		internal static void SplitInstructions(string[] instructions)
		{
			foreach (string inst in instructions)
			{
				try
				{

					string instruction="";
					int pc = 0;
					string[] instComponants = inst.Split(':');
					pc = Convert.ToInt32(instComponants[0]);
					if (pc < MIPS.PC)
						continue;
					instComponants = instComponants[1].Split(' ');
					for (int i = 0; i < instComponants.Length; i++)
					{
						instruction += instComponants[i];
					}
					INSTRUCTION_MEM.Add(pc, instruction);
				}
				catch (Exception)
				{

					throw;
				}

			}
		}

		/// <summary>
		/// Apply the fetch phase, gets the instruction at current PC
		/// and stores it in IF/ID regester
		/// </summary>
		internal static void Fetch()
		{
			string instruction = INSTRUCTION_MEM[PC];
			PC += 4;
			IF_ID.PC = PC;
			string Iterator = "";
			for (int i = 0; i < instruction.Length; i++)
			{
				Iterator += instruction[i];
				// 6 bits for the OP code
				if (i == 5)
				{
					int op = Convert.ToInt32(Iterator, 2);
					IF_ID.OP = op;
					Iterator = "";
				}
				// 5 bits for RS
				if (i == 10)
				{
					int rs = Convert.ToInt32(Iterator, 2);
					IF_ID.RS = rs;
					Iterator = "";
				}
				// 5 bits for RT
				if (i == 15)
				{
					int rt = Convert.ToInt32(Iterator, 2);
					IF_ID.RT = rt;
					Iterator = "";
				}
				// 5 bits for RD
				if (i == 20 && IF_ID.OP == 0)
				{
					int rd = Convert.ToInt32(Iterator, 2);
					IF_ID.RD = rd;
					Iterator = "";
				}
				// 5 bits for shamt
 				if (i == 25 && IF_ID.OP == 0)
				{
					Iterator = "";
				}
				// 6 bits for funct
				if (i == 31 && IF_ID.OP == 0)
				{
					int funct = Convert.ToInt32(Iterator, 2);
					IF_ID.Funct = funct;
					Iterator = "";
				}
				// 16 bits for constant/address
				if (i == 31 && IF_ID.OP == 35)
				{
					int offset = Convert.ToInt32(Iterator, 2);
					IF_ID.Offset = offset;
					IF_ID.Funct = -1;
					Iterator = "";
				}
			}
		}

		/// <summary>
		/// Apply the Decode phase, set inputs of the Regester file
		/// and stores its outputs and stores the offset and the destination 
		/// regester and function code of the operatipon in ID/EX regester.
		/// </summary>
		internal static void Decode()
		{
			RegesterFile.readReg1 = IF_ID.RS;
			RegesterFile.readReg2 = IF_ID.RT;
			RegesterFile.readData1 = REGESTERS[RegesterFile.readReg1];
			RegesterFile.readData2 = REGESTERS[RegesterFile.readReg2];

			ID_EX.Offset = IF_ID.Offset;
			ID_EX.IRegDst = IF_ID.RT;
			ID_EX.RRegDst = IF_ID.RD;
			ID_EX.ReadData1 = RegesterFile.readData1;
			ID_EX.ReadData2 = RegesterFile.readData2;
			ID_EX.ALUOp = IF_ID.Funct;
		}

		/// <summary>
		/// Apply the Excute phase, sets inputs of ALU
		/// and stores its result, destination regester and function code of the operatipon 
		/// in EX/MEM regester.
		/// </summary>
		internal static void Excute()
		{
			int ALU_in1, ALU_in2;
			ALU_in1 = ID_EX.ReadData1;
	
			//if current instruction is R-type
			if(ID_EX.ALUOp != -1)
			{
				ALU_in2 = ID_EX.ReadData2;
				EX_MEM.RegDst = ID_EX.RRegDst;
			}
			//if current instruction is I-type
			else
			{
				ALU_in2 = ID_EX.Offset;
				EX_MEM.RegDst = ID_EX.IRegDst;
				EX_MEM.Data2 = ID_EX.ReadData2;
			}
			ALU(ALU_in1, ALU_in2, ID_EX.ALUOp, ref EX_MEM.Result);
			EX_MEM.Funct = ID_EX.ALUOp;
		}

		/// <summary>
		/// Represents ALU chip.
		/// </summary>
		/// <param name="in1">input 1</param>
		/// <param name="in2">input 2</param>
		/// <param name="ALUOp">the Function code of the operation</param>
		/// <param name="result">ALU result</param>
		private static void ALU(int in1, int in2,int ALUOp, ref int result)
		{
			switch (ALUOp)
			{
				//Add
				case 32:
				case -1://if I-type instrction
					result = in1 + in2;
					break;
				//Sub
				case 34:
					result = in1 - in2;
					break;
				//AND
				case 36:
					result = in1 & in2;
					break;
				//OR
				case 37:
					result = in1 | in2;
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Apply Access Memory phase,
		/// stores ALU result, Destination regester, ReadData2 of the regester file,
		/// and OP code of the instruction.
		/// </summary>
		internal static void AccessMem()
		{
			MEM_WB.Funct = EX_MEM.Funct;
			MEM_WB.ALUResult = EX_MEM.Result;
			MEM_WB.RegDst = EX_MEM.RegDst;
			MEM_WB.ReadData = 99;
		}

		/// <summary>
		/// Apply the Write back phase,
		/// write the result of the excuted operation in the destination regester.
		/// </summary>
		internal static void WriteBack()
		{
			RegesterFile.writeReg = MEM_WB.RegDst;
			//if current instruction is R-type
			if (MEM_WB.Funct != -1)
			{
				RegesterFile.writeData = MEM_WB.ALUResult;
			}
			//if current instruction is I-type
			else
			{
				RegesterFile.writeData = MEM_WB.ReadData;
			}
			REGESTERS[RegesterFile.writeReg] = RegesterFile.writeData;
		}
	}
}
