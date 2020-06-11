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
		public int ExtendOffset;
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
		public static int[] REGESTERS = new int[32];
		public static int PC;
		public static IF_ID IF_ID = new IF_ID();
		public static ID_EX ID_EX = new ID_EX();
		public static EX_MEM EX_MEM = new EX_MEM();
		public static MEM_WB MEM_WB = new MEM_WB();
		//public static Dictionary<int, int> MEMORY = new Dictionary<int, int>();
		public static int[] MEMORY = new int[2000];
		public static Dictionary<int, string> INSTRUCTION_MEM = new Dictionary<int, string>();
		
		public static RegesterFile RegesterFile = new RegesterFile();

		//private static string CurrentInstruction;
		/// <summary>
		/// Class Constructor
		/// </summary>
		/// <param name="PC"> program counter</param>
		/// <param name="Instructions">set of instructions</param>
		public MIPS()
		{
			//for (int i = 0; i < 32; i++)
			//{
			//	if (i == 0)
			//		REGESTERS[i] = 0;
			//	else
			//		REGESTERS[i] = i + 100;
			//}
			//SplitInstructions(Instructions);
		}

		/// <summary>
		/// splits the instructions into PC and Value
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

		internal static void Fetch()
		{
			string instruction = INSTRUCTION_MEM[PC];
			PC += 4;
			IF_ID.PC = PC;
			string Iterator = "";
			for (int i = 0; i < instruction.Length; i++)
			{
				Iterator += instruction[i];
				if (i == 5)
				{
					int op = Convert.ToInt32(Iterator, 2);
					IF_ID.OP = op;
					Iterator = "";
				}
				if (i == 10)
				{
					int rs = Convert.ToInt32(Iterator, 2);
					IF_ID.RS = rs;
					Iterator = "";
				}
				if (i == 15)
				{
					int rt = Convert.ToInt32(Iterator, 2);
					IF_ID.RT = rt;
					Iterator = "";
				}
				if (i == 20 && IF_ID.OP == 0)
				{
					int rd = Convert.ToInt32(Iterator, 2);
					IF_ID.RD = rd;
					Iterator = "";
				}
				if (i == 25 && IF_ID.OP == 0)
				{
					Iterator = "";
				}
				if (i == 31 && IF_ID.OP == 0)
				{
					int funct = Convert.ToInt32(Iterator, 2);
					IF_ID.Funct = funct;
					Iterator = "";
				}
				if (i == 31 && IF_ID.OP == 35)
				{
					int offset = Convert.ToInt32(Iterator, 2);
					IF_ID.Offset = offset;
					IF_ID.Funct = -1;
					Iterator = "";
				}
			}
		}

		internal static void Decode()
		{
			RegesterFile.readReg1 = IF_ID.RS;
			RegesterFile.readReg2 = IF_ID.RT;
			//RegesterFile.writeReg = IF_ID.RD;
			RegesterFile.readData1 = REGESTERS[RegesterFile.readReg1];
			RegesterFile.readData2 = REGESTERS[RegesterFile.readReg2];

			ID_EX.ExtendOffset = IF_ID.Offset;
			ID_EX.IRegDst = IF_ID.RT;
			ID_EX.RRegDst = IF_ID.RD;
			ID_EX.ReadData1 = RegesterFile.readData1;
			ID_EX.ReadData2 = RegesterFile.readData2;
			ID_EX.ALUOp = IF_ID.Funct;
		}

		internal static void Excute()
		{
			int in1, in2;
			in1 = ID_EX.ReadData1;
			//R
			if(ID_EX.ALUOp != -1)
			{
				in2 = ID_EX.ReadData2;
				EX_MEM.RegDst = ID_EX.RRegDst;
			}
			//I
			else
			{
				in2 = ID_EX.ExtendOffset;
				EX_MEM.RegDst = ID_EX.IRegDst;
				EX_MEM.Data2 = ID_EX.ReadData2;
			}
			ALU(in1, in2, ID_EX.ALUOp, ref EX_MEM.Result);
			EX_MEM.Funct = ID_EX.ALUOp;
		}

		private static void ALU(int in1, int in2,int ALUOp, ref int result)
		{
			switch (ALUOp)
			{
				//Add
				case 32:
				case -1:
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

		internal static void AccessMem()
		{
			MEM_WB.Funct = EX_MEM.Funct;
			MEM_WB.ALUResult = EX_MEM.Result;
			MEM_WB.RegDst = EX_MEM.RegDst;
			//MEM_WB.ReadData = MEMORY[MEM_WB.ALUResult];
			MEM_WB.ReadData = 99;
		}
		internal static void WriteBack()
		{
			RegesterFile.writeReg = MEM_WB.RegDst;
			//R
			if(MEM_WB.Funct != -1)
			{
				RegesterFile.writeData = MEM_WB.ALUResult;
			}
			//I
			else
			{
				RegesterFile.writeData = MEM_WB.ReadData;
			}
			REGESTERS[RegesterFile.writeReg] = RegesterFile.writeData;
		}
	}
}
