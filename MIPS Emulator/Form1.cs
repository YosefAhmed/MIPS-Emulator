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
			//fill Regesters array and data grid view.
			for (int i = 0; i < 32; i++)
			{
				if (i == 0)
					MIPS.REGESTERS[i] = 0;
				else
					MIPS.REGESTERS[i] = i + 100;

				string reg = "$" + i.ToString();
				mipsRegsGrid.Rows.Add(reg, MIPS.REGESTERS[i]);
			}
			//fill data memory array and data grid view
			for (int i = 0; i < MIPS.MEMORY.Length; i++)
			{
				MIPS.MEMORY[i] = 99;
				memoryGrid.Rows.Add(i, 99);
			}

			//fill IF/ID regester data grid view
			IF_IDGrid.Rows.Add("OP", MIPS.IF_ID.OP);//1
			IF_IDGrid.Rows.Add("RS", MIPS.IF_ID.RS);//2
			IF_IDGrid.Rows.Add("RT", MIPS.IF_ID.RT);//3
			IF_IDGrid.Rows.Add("RD", MIPS.IF_ID.RD);//4
			IF_IDGrid.Rows.Add("Offset", MIPS.IF_ID.Offset);//5
			IF_IDGrid.Rows.Add("Funct", MIPS.IF_ID.Funct);//6

			//fill ID/EX regester data grid view
			ID_EXGrid.Rows.Add("ALU OP", MIPS.ID_EX.ALUOp);//8
			ID_EXGrid.Rows.Add("Inst [15-0]", MIPS.ID_EX.Offset);//9
			ID_EXGrid.Rows.Add("Inst [16-20]", MIPS.ID_EX.IRegDst);//10
			ID_EXGrid.Rows.Add("Inst [15-11]", MIPS.ID_EX.RRegDst);//11
			ID_EXGrid.Rows.Add("Read Data1", MIPS.ID_EX.ReadData1);//12
			ID_EXGrid.Rows.Add("Read Data2", MIPS.ID_EX.ReadData2);//13

			//fill EX/MEM regester data grid view
			EX_MEMGrid.Rows.Add("ALU Output", MIPS.EX_MEM.Result);//15
			EX_MEMGrid.Rows.Add("RegDst", MIPS.EX_MEM.RegDst);//16
			EX_MEMGrid.Rows.Add("Read Data2", MIPS.EX_MEM.Data2);//17
			EX_MEMGrid.Rows.Add("Funct", MIPS.EX_MEM.Funct);//18

			//fill MEM/WB regester data grid view
			MEM_WBGrid.Rows.Add("Memory Read Data", MIPS.MEM_WB.ReadData);//20
			MEM_WBGrid.Rows.Add("ALU Output", MIPS.MEM_WB.ALUResult);//21
			MEM_WBGrid.Rows.Add("RegDst", MIPS.MEM_WB.RegDst);//22
			MEM_WBGrid.Rows.Add("Funct", MIPS.MEM_WB.Funct);//23

			//deselect all selected raws
			mipsRegsGrid.ClearSelection();
			IF_IDGrid.ClearSelection();
			ID_EXGrid.ClearSelection();
			EX_MEMGrid.ClearSelection();
			MEM_WBGrid.ClearSelection();
			memoryGrid.ClearSelection();

		}

		/// <summary>
		/// Resets all to default values
		/// </summary>
		private void Reset()
		{
			for (int i = 0; i < 32; i++)
			{
				if (i == 0)
					MIPS.REGESTERS[i] = 0;
				else
					MIPS.REGESTERS[i] = i + 100;

				string reg = "$" + i.ToString();
				mipsRegsGrid.Rows[i].Cells[1].Value = MIPS.REGESTERS[i];
			}
			for (int i = 0; i < MIPS.MEMORY.Length; i++)
			{
				MIPS.MEMORY[i] = 99;
				memoryGrid.Rows[i].Cells[1].Value = 99;
			}

			MIPS.INSTRUCTION_MEM = new Dictionary<int, string>();
			MIPS.MEM_WB = new MEM_WB();
			MIPS.EX_MEM = new EX_MEM();
			MIPS.ID_EX = new ID_EX();
			MIPS.IF_ID = new IF_ID();

			initialized = false;
			CycleNumber = 0;
			Refresh();
			mipsRegsGrid.ClearSelection();

		}

		/// <summary>
		/// Refesh the data grid views after each cycles updates
		/// </summary>
		private void Refresh()
		{
			IF_IDGrid.Rows[0].Cells[1].Value = MIPS.IF_ID.OP;
			IF_IDGrid.Rows[1].Cells[1].Value = MIPS.IF_ID.RS;
			IF_IDGrid.Rows[2].Cells[1].Value = MIPS.IF_ID.RT;
			IF_IDGrid.Rows[3].Cells[1].Value = MIPS.IF_ID.RD;
			IF_IDGrid.Rows[4].Cells[1].Value = MIPS.IF_ID.Offset;
			IF_IDGrid.Rows[5].Cells[1].Value = MIPS.IF_ID.Funct;

			ID_EXGrid.Rows[0].Cells[1].Value = MIPS.ID_EX.ALUOp;
			ID_EXGrid.Rows[1].Cells[1].Value = MIPS.ID_EX.Offset;
			ID_EXGrid.Rows[2].Cells[1].Value = MIPS.ID_EX.IRegDst;
			ID_EXGrid.Rows[3].Cells[1].Value = MIPS.ID_EX.RRegDst;
			ID_EXGrid.Rows[4].Cells[1].Value = MIPS.ID_EX.ReadData1;
			ID_EXGrid.Rows[5].Cells[1].Value = MIPS.ID_EX.ReadData2;

			EX_MEMGrid.Rows[0].Cells[1].Value = MIPS.EX_MEM.Result;
			EX_MEMGrid.Rows[1].Cells[1].Value = MIPS.EX_MEM.RegDst;
			EX_MEMGrid.Rows[2].Cells[1].Value = MIPS.EX_MEM.Data2;
			EX_MEMGrid.Rows[3].Cells[1].Value = MIPS.EX_MEM.Funct;

			MEM_WBGrid.Rows[0].Cells[1].Value = MIPS.MEM_WB.ReadData;
			MEM_WBGrid.Rows[1].Cells[1].Value = MIPS.MEM_WB.ALUResult;
			MEM_WBGrid.Rows[2].Cells[1].Value = MIPS.MEM_WB.RegDst;
			MEM_WBGrid.Rows[3].Cells[1].Value = MIPS.MEM_WB.Funct;



			if (initialized && CycleNumber >= 5)
			{
				mipsRegsGrid.Rows[MIPS.RegesterFile.writeReg].Cells[1].Value = MIPS.REGESTERS[MIPS.RegesterFile.writeReg];
				mipsRegsGrid.Rows[MIPS.RegesterFile.writeReg].Selected = true;
			}
			IF_IDGrid.Update();
			IF_IDGrid.Refresh();

			ID_EXGrid.Update();
			ID_EXGrid.Refresh();

			EX_MEMGrid.Update();
			EX_MEMGrid.Refresh();

			MEM_WBGrid.Update();
			MEM_WBGrid.Refresh();

			mipsRegsGrid.Update();
			mipsRegsGrid.Refresh();


		}

		/// <summary>
		/// used to check if all values are initialized
		/// </summary>
		bool initialized = false;

		private void initializeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				//reset all values to its default
				Reset();
				//split the instructions string into separate instructions
				string[] instructions = userCodeTxt.Text.Split('\n');
				//set the PC of MIPS with the given
				MIPS.PC = Convert.ToInt32(pcTxt.Text);
				//splits the instructions into PC and instruction machine code
				MIPS.SplitInstructions(instructions);
				initialized = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Represents the cycle number
		/// </summary>
		int CycleNumber = 0;
		private void runBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (initialized) {
					cycleNumberLbl.Text = (CycleNumber+1).ToString();
					int NumberOfInstructions = MIPS.INSTRUCTION_MEM.Count;
					if (CycleNumber < 5 + (NumberOfInstructions - 1))
					{
						//****
						//the next condetions are to excute each phase with instructions in there oreder
						//****
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
					{
						MessageBox.Show("no instructions to excute");
					}
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
