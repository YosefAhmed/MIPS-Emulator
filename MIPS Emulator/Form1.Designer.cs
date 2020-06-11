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
			this.RegesterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.IF_IDGrid = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.memoryGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pcTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.initializeBtn = new System.Windows.Forms.Button();
			this.runBtn = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ID_EXGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.EX_MEMGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label9 = new System.Windows.Forms.Label();
			this.MEM_WBGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.mipsRegsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IF_IDGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID_EXGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EX_MEMGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MEM_WBGrid)).BeginInit();
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
			this.userCodeTxt.Size = new System.Drawing.Size(246, 275);
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
			this.mipsRegsGrid.Location = new System.Drawing.Point(267, 64);
			this.mipsRegsGrid.Name = "mipsRegsGrid";
			this.mipsRegsGrid.ReadOnly = true;
			this.mipsRegsGrid.RowHeadersVisible = false;
			this.mipsRegsGrid.Size = new System.Drawing.Size(181, 275);
			this.mipsRegsGrid.TabIndex = 2;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "IF/ID";
			// 
			// IF_IDGrid
			// 
			this.IF_IDGrid.AllowUserToAddRows = false;
			this.IF_IDGrid.AllowUserToDeleteRows = false;
			this.IF_IDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.IF_IDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.IF_IDGrid.Location = new System.Drawing.Point(6, 52);
			this.IF_IDGrid.Name = "IF_IDGrid";
			this.IF_IDGrid.ReadOnly = true;
			this.IF_IDGrid.RowHeadersVisible = false;
			this.IF_IDGrid.Size = new System.Drawing.Size(124, 269);
			this.IF_IDGrid.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(980, 48);
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
			this.memoryGrid.Location = new System.Drawing.Point(983, 64);
			this.memoryGrid.Name = "memoryGrid";
			this.memoryGrid.ReadOnly = true;
			this.memoryGrid.RowHeadersVisible = false;
			this.memoryGrid.Size = new System.Drawing.Size(177, 275);
			this.memoryGrid.TabIndex = 2;
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
			this.dataGridViewTextBoxColumn1.HeaderText = "Data";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 70;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Value";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 50;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(0, -16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Pipeline Regesters";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.MEM_WBGrid);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.EX_MEMGrid);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.ID_EXGrid);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.IF_IDGrid);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(454, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(523, 327);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pipeline Regesters";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(131, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "ID/EX";
			// 
			// ID_EXGrid
			// 
			this.ID_EXGrid.AllowUserToAddRows = false;
			this.ID_EXGrid.AllowUserToDeleteRows = false;
			this.ID_EXGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ID_EXGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.ID_EXGrid.Location = new System.Drawing.Point(134, 52);
			this.ID_EXGrid.Name = "ID_EXGrid";
			this.ID_EXGrid.ReadOnly = true;
			this.ID_EXGrid.RowHeadersVisible = false;
			this.ID_EXGrid.Size = new System.Drawing.Size(124, 269);
			this.ID_EXGrid.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Data";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 70;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Value";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 50;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(259, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "EX/MEM";
			// 
			// EX_MEMGrid
			// 
			this.EX_MEMGrid.AllowUserToAddRows = false;
			this.EX_MEMGrid.AllowUserToDeleteRows = false;
			this.EX_MEMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EX_MEMGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.EX_MEMGrid.Location = new System.Drawing.Point(262, 52);
			this.EX_MEMGrid.Name = "EX_MEMGrid";
			this.EX_MEMGrid.ReadOnly = true;
			this.EX_MEMGrid.RowHeadersVisible = false;
			this.EX_MEMGrid.Size = new System.Drawing.Size(124, 269);
			this.EX_MEMGrid.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Data";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 70;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Value";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 50;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(387, 31);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "MEM/WB";
			// 
			// MEM_WBGrid
			// 
			this.MEM_WBGrid.AllowUserToAddRows = false;
			this.MEM_WBGrid.AllowUserToDeleteRows = false;
			this.MEM_WBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MEM_WBGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.MEM_WBGrid.Location = new System.Drawing.Point(390, 52);
			this.MEM_WBGrid.Name = "MEM_WBGrid";
			this.MEM_WBGrid.ReadOnly = true;
			this.MEM_WBGrid.RowHeadersVisible = false;
			this.MEM_WBGrid.Size = new System.Drawing.Size(124, 269);
			this.MEM_WBGrid.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "Data";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 70;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "Value";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.runBtn);
			this.Controls.Add(this.initializeBtn);
			this.Controls.Add(this.pcTxt);
			this.Controls.Add(this.memoryGrid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mipsRegsGrid);
			this.Controls.Add(this.userCodeTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.mipsRegsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IF_IDGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID_EXGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EX_MEMGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MEM_WBGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox userCodeTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView mipsRegsGrid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView IF_IDGrid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView memoryGrid;
		private System.Windows.Forms.TextBox pcTxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button initializeBtn;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegesterColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView MEM_WBGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView EX_MEMGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView ID_EXGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Label label7;
	}
}

