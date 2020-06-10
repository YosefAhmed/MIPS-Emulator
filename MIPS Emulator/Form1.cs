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
			for (int i = 0; i < 32; i++)
			{
				if (i == 0)
					MIPS.REGESTERS[i] = 0;
				else
					MIPS.REGESTERS[i] = i + 100;

				string reg = "$" + i.ToString();
				mipsRegsGrid.Rows.Add(reg, MIPS.REGESTERS[i]);
			}
			
		}

		private void initializeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				//Dictionary<int, string> INSTRUCTION_MEM = new Dictionary<int, string>();
				string[] instructions = userCodeTxt.Text.Split('\n');
				MIPS.PC = Convert.ToInt32(pcTxt.Text);
				MIPS.SplitInstructions(instructions);	

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void runBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (MIPS.INSTRUCTION_MEM.ContainsKey(MIPS.PC))
				{
					
					MIPS.WriteBack();
					MIPS.AccessMem();
					MIPS.Excute();
					MIPS.Decode();
					MIPS.Fetch();



				}
				else
					MessageBox.Show("no instructions to excute");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
