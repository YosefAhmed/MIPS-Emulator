using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPS_Emulator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//if (MIPS.REGESTERS.Length == 0)
			//{
				for (int i = 0; i < 32; i++)
				{
					if (i == 0)
						MIPS.REGESTERS[i] = 0;
					else
						MIPS.REGESTERS[i] = i + 100;

					string reg = "$" + i.ToString();
					mipsRegsGrid.Rows.Add(reg, MIPS.REGESTERS[i]);
				}
				for (int i = 0; i < MIPS.MEMORY.Length; i++)
				{
					MIPS.MEMORY[i] = 99;
					memoryGrid.Rows.Add(i, 99);
				}
			//}
			pipRegsGrid.Rows.Add("IF/ID", "");//0
			pipRegsGrid.Rows.Add("      OP", MIPS.IF_ID.OP);//1
			pipRegsGrid.Rows.Add("      RS", MIPS.IF_ID.RS);//2
			pipRegsGrid.Rows.Add("      RT", MIPS.IF_ID.RT);//3
			pipRegsGrid.Rows.Add("      RD", MIPS.IF_ID.RD);//4
			pipRegsGrid.Rows.Add("      Offset", MIPS.IF_ID.Offset);//5
			pipRegsGrid.Rows.Add("      Funct", MIPS.IF_ID.Funct);//6

			pipRegsGrid.Rows.Add("ID/EX", "");//7
			pipRegsGrid.Rows.Add("      ALU OP", MIPS.ID_EX.ALUOp);//8
			pipRegsGrid.Rows.Add("      Inst [15-0]", MIPS.ID_EX.ExtendOffset);//9
			pipRegsGrid.Rows.Add("      Inst [16-20]", MIPS.ID_EX.IRegDst);//10
			pipRegsGrid.Rows.Add("      Inst [15-11]", MIPS.ID_EX.RRegDst);//11
			pipRegsGrid.Rows.Add("      Read Data1", MIPS.ID_EX.ReadData1);//12
			pipRegsGrid.Rows.Add("      Read Data2", MIPS.ID_EX.ReadData2);//13

			pipRegsGrid.Rows.Add("EX/MEM", "");//14
			pipRegsGrid.Rows.Add("      ALU Output", MIPS.EX_MEM.Result);//15
			pipRegsGrid.Rows.Add("      RegDst", MIPS.EX_MEM.RegDst);//16
			pipRegsGrid.Rows.Add("      Read Data2", MIPS.EX_MEM.Data2);//17
			pipRegsGrid.Rows.Add("      Funct", MIPS.EX_MEM.Funct);//18

			pipRegsGrid.Rows.Add("MEM/WB", "");//19
			pipRegsGrid.Rows.Add("      Memory Read Data", MIPS.MEM_WB.ReadData);//20
			pipRegsGrid.Rows.Add("      ALU Output", MIPS.MEM_WB.ALUResult);//21
			pipRegsGrid.Rows.Add("      RegDst", MIPS.MEM_WB.RegDst);//22
			pipRegsGrid.Rows.Add("      Funct", MIPS.MEM_WB.Funct);//23

		}
		private void Refresh()
		{
			pipRegsGrid.Rows[1].Cells[1].Value = MIPS.IF_ID.OP;
			pipRegsGrid.Rows[2].Cells[1].Value = MIPS.IF_ID.RS;
			pipRegsGrid.Rows[3].Cells[1].Value = MIPS.IF_ID.RT;
			pipRegsGrid.Rows[4].Cells[1].Value = MIPS.IF_ID.RD;
			pipRegsGrid.Rows[5].Cells[1].Value = MIPS.IF_ID.Offset;
			pipRegsGrid.Rows[6].Cells[1].Value = MIPS.IF_ID.Funct; 
		
			pipRegsGrid.Rows[8].Cells[1].Value = MIPS.ID_EX.ALUOp; 
			pipRegsGrid.Rows[9].Cells[1].Value = MIPS.ID_EX.ExtendOffset; 
			pipRegsGrid.Rows[10].Cells[1].Value = MIPS.ID_EX.IRegDst; 
			pipRegsGrid.Rows[11].Cells[1].Value = MIPS.ID_EX.RRegDst; 
			pipRegsGrid.Rows[12].Cells[1].Value = MIPS.ID_EX.ReadData1; 
			pipRegsGrid.Rows[13].Cells[1].Value = MIPS.ID_EX.ReadData2;

			pipRegsGrid.Rows[15].Cells[1].Value = MIPS.EX_MEM.Result;
			pipRegsGrid.Rows[16].Cells[1].Value = MIPS.EX_MEM.RegDst;
			pipRegsGrid.Rows[17].Cells[1].Value = MIPS.EX_MEM.Data2;
			pipRegsGrid.Rows[18].Cells[1].Value = MIPS.EX_MEM.Funct;

			pipRegsGrid.Rows[20].Cells[1].Value = MIPS.MEM_WB.ReadData;
			pipRegsGrid.Rows[21].Cells[1].Value = MIPS.MEM_WB.ALUResult;
			pipRegsGrid.Rows[22].Cells[1].Value = MIPS.MEM_WB.RegDst;
			pipRegsGrid.Rows[23].Cells[1].Value = MIPS.MEM_WB.Funct;


			mipsRegsGrid.Rows[MIPS.RegesterFile.writeReg].Cells[1].Value = MIPS.REGESTERS[MIPS.RegesterFile.writeReg];
			mipsRegsGrid.Rows[MIPS.RegesterFile.writeReg].Selected = true;

			pipRegsGrid.Update();
			pipRegsGrid.Refresh();
			mipsRegsGrid.Update();
			mipsRegsGrid.Refresh();


		}
		bool initialized = false;
		private void initializeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (!initialized)
				{
					//Dictionary<int, string> INSTRUCTION_MEM = new Dictionary<int, string>();
					string[] instructions = userCodeTxt.Text.Split('\n');
					MIPS.PC = Convert.ToInt32(pcTxt.Text);
					MIPS.SplitInstructions(instructions);
					initialized = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		int CycleNumber = 0;
		private void runBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (initialized) { 
					int NumberOfInstructions = MIPS.INSTRUCTION_MEM.Count;
					if (CycleNumber < 5 + (NumberOfInstructions - 1))
					{
						if (CycleNumber - 4 < NumberOfInstructions && CycleNumber - 4 >= 0)
						{
							MIPS.WriteBack();
							MIPS.MEM_WB = new MEM_WB();
						}
						if (CycleNumber - 3 < NumberOfInstructions && CycleNumber - 3 >= 0)
						{
							MIPS.AccessMem();
							MIPS.EX_MEM = new EX_MEM();
						}
						if (CycleNumber - 2 < NumberOfInstructions && CycleNumber - 2 >= 0)
						{
							MIPS.Excute();
							MIPS.ID_EX = new ID_EX();
						}
						if (CycleNumber - 1 < NumberOfInstructions && CycleNumber - 1 >= 0)
						{
							MIPS.Decode();
							MIPS.IF_ID = new IF_ID();
						}
						if (CycleNumber < NumberOfInstructions)
							MIPS.Fetch();

						CycleNumber++;
						Refresh();
					}
					else
						MessageBox.Show("no instructions to excute");
				}
				else
					MessageBox.Show("Please initialize the the values (Press Initialize button!)", "Values not initialized", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
