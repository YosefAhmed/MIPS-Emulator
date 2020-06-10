namespace MIPS_Emulator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.userCodeTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mipsRegsGrid = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.pipRegsGrid = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.memoryGrid = new System.Windows.Forms.DataGridView();
			this.pcTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.initializeBtn = new System.Windows.Forms.Button();
			this.runBtn = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RegesterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.mipsRegsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipRegsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Code";
			// 
			// userCodeTxt
			// 
			this.userCodeTxt.Location = new System.Drawing.Point(15, 64);
			this.userCodeTxt.Multiline = true;
			this.userCodeTxt.Name = "userCodeTxt";
			this.userCodeTxt.Size = new System.Drawing.Size(219, 275);
			this.userCodeTxt.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "MIPS Regesters";
			// 
			// mipsRegsGrid
			// 
			this.mipsRegsGrid.AllowUserToAddRows = false;
			this.mipsRegsGrid.AllowUserToDeleteRows = false;
			this.mipsRegsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mipsRegsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegesterColumn,
            this.ValueColumn});
			this.mipsRegsGrid.Location = new System.Drawing.Point(243, 64);
			this.mipsRegsGrid.Name = "mipsRegsGrid";
			this.mipsRegsGrid.ReadOnly = true;
			this.mipsRegsGrid.RowHeadersVisible = false;
			this.mipsRegsGrid.Size = new System.Drawing.Size(177, 275);
			this.mipsRegsGrid.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(425, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Pipeline Regesters";
			// 
			// pipRegsGrid
			// 
			this.pipRegsGrid.AllowUserToAddRows = false;
			this.pipRegsGrid.AllowUserToDeleteRows = false;
			this.pipRegsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pipRegsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.pipRegsGrid.Location = new System.Drawing.Point(428, 64);
			this.pipRegsGrid.Name = "pipRegsGrid";
			this.pipRegsGrid.ReadOnly = true;
			this.pipRegsGrid.RowHeadersVisible = false;
			this.pipRegsGrid.Size = new System.Drawing.Size(177, 275);
			this.pipRegsGrid.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(608, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Data Memory";
			// 
			// memoryGrid
			// 
			this.memoryGrid.AllowUserToAddRows = false;
			this.memoryGrid.AllowUserToDeleteRows = false;
			this.memoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.memoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.memoryGrid.Location = new System.Drawing.Point(611, 64);
			this.memoryGrid.Name = "memoryGrid";
			this.memoryGrid.ReadOnly = true;
			this.memoryGrid.RowHeadersVisible = false;
			this.memoryGrid.Size = new System.Drawing.Size(177, 275);
			this.memoryGrid.TabIndex = 2;
			// 
			// pcTxt
			// 
			this.pcTxt.Location = new System.Drawing.Point(39, 397);
			this.pcTxt.Name = "pcTxt";
			this.pcTxt.Size = new System.Drawing.Size(100, 20);
			this.pcTxt.TabIndex = 3;
			this.pcTxt.Text = "1000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 400);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "PC";
			// 
			// initializeBtn
			// 
			this.initializeBtn.Location = new System.Drawing.Point(179, 386);
			this.initializeBtn.Name = "initializeBtn";
			this.initializeBtn.Size = new System.Drawing.Size(145, 40);
			this.initializeBtn.TabIndex = 4;
			this.initializeBtn.Text = "Initialize";
			this.initializeBtn.UseVisualStyleBackColor = true;
			this.initializeBtn.Click += new System.EventHandler(this.initializeBtn_Click);
			// 
			// runBtn
			// 
			this.runBtn.Location = new System.Drawing.Point(340, 386);
			this.runBtn.Name = "runBtn";
			this.runBtn.Size = new System.Drawing.Size(145, 40);
			this.runBtn.TabIndex = 4;
			this.runBtn.Text = "Run 1 Cycle";
			this.runBtn.UseVisualStyleBackColor = true;
			this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Regester";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 90;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Value";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 90;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Address";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 90;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Value";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 90;
			// 
			// RegesterColumn
			// 
			this.RegesterColumn.HeaderText = "Regester";
			this.RegesterColumn.Name = "RegesterColumn";
			this.RegesterColumn.ReadOnly = true;
			this.RegesterColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.RegesterColumn.Width = 90;
			// 
			// ValueColumn
			// 
			this.ValueColumn.HeaderText = "Value";
			this.ValueColumn.Name = "ValueColumn";
			this.ValueColumn.ReadOnly = true;
			this.ValueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ValueColumn.Width = 90;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.runBtn);
			this.Controls.Add(this.initializeBtn);
			this.Controls.Add(this.pcTxt);
			this.Controls.Add(this.memoryGrid);
			this.Controls.Add(this.pipRegsGrid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mipsRegsGrid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.userCodeTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.mipsRegsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipRegsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox userCodeTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView mipsRegsGrid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView pipRegsGrid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView memoryGrid;
		private System.Windows.Forms.TextBox pcTxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button initializeBtn;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegesterColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	}
}

