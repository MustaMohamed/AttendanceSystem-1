namespace PepoCompuny {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbx_EmployeeNames = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(298, 115);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(396, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 159);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(937, 282);
			this.dataGridView1.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(755, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "اسم الموظف";
			// 
			// cmbx_EmployeeNames
			// 
			this.cmbx_EmployeeNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbx_EmployeeNames.FormattingEnabled = true;
			this.cmbx_EmployeeNames.Location = new System.Drawing.Point(268, 59);
			this.cmbx_EmployeeNames.Name = "cmbx_EmployeeNames";
			this.cmbx_EmployeeNames.Size = new System.Drawing.Size(447, 26);
			this.cmbx_EmployeeNames.TabIndex = 9;
			this.cmbx_EmployeeNames.SelectedIndexChanged += new System.EventHandler(this.cmbx_EmployeeNames_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(413, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 22);
			this.label4.TabIndex = 8;
			this.label4.Text = "بيانات الموظفين";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 467);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbx_EmployeeNames);
			this.Controls.Add(this.label4);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbx_EmployeeNames;
		private System.Windows.Forms.Label label4;
	}
}