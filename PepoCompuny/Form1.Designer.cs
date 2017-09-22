namespace PepoCompuny {
	partial class Form1 {
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
			this.btn_ShowData = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.rdbtn_AbsentNoPermissionDay = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.pnl_AddDay = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_AddThisDay = new System.Windows.Forms.Button();
			this.rdbtn_AbsentPermissionHoliday = new System.Windows.Forms.RadioButton();
			this.rdbtn_AbsentPermissionDay = new System.Windows.Forms.RadioButton();
			this.rdbtn_DelayPermissionHours = new System.Windows.Forms.RadioButton();
			this.txt_Solfa = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_LeaveM = new System.Windows.Forms.TextBox();
			this.txt_LeaveH = new System.Windows.Forms.TextBox();
			this.txt_ArriveH = new System.Windows.Forms.TextBox();
			this.txt_ArriveM = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbx_EmployeeNames = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_AddNewEmployee = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_AddDay = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pnl_AddEmployee = new System.Windows.Forms.Panel();
			this.btn_AddEmployee = new System.Windows.Forms.Button();
			this.txt_EmployeeSalary = new System.Windows.Forms.TextBox();
			this.txt_EmployeeName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pnl_AddDay.SuspendLayout();
			this.pnl_AddEmployee.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_ShowData
			// 
			this.btn_ShowData.Location = new System.Drawing.Point(251, 396);
			this.btn_ShowData.Name = "btn_ShowData";
			this.btn_ShowData.Size = new System.Drawing.Size(141, 34);
			this.btn_ShowData.TabIndex = 12;
			this.btn_ShowData.Text = "عرض بيانات الموظفين";
			this.btn_ShowData.UseVisualStyleBackColor = true;
			this.btn_ShowData.Click += new System.EventHandler(this.btn_ShowData_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(543, 205);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(12, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "د";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(407, 205);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 13);
			this.label12.TabIndex = 26;
			this.label12.Text = "د";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(470, 203);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(20, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "س";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(328, 203);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(20, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "س";
			// 
			// rdbtn_AbsentNoPermissionDay
			// 
			this.rdbtn_AbsentNoPermissionDay.AutoSize = true;
			this.rdbtn_AbsentNoPermissionDay.Location = new System.Drawing.Point(28, 231);
			this.rdbtn_AbsentNoPermissionDay.Name = "rdbtn_AbsentNoPermissionDay";
			this.rdbtn_AbsentNoPermissionDay.Size = new System.Drawing.Size(90, 17);
			this.rdbtn_AbsentNoPermissionDay.TabIndex = 23;
			this.rdbtn_AbsentNoPermissionDay.TabStop = true;
			this.rdbtn_AbsentNoPermissionDay.Text = "غياب بدون إذن";
			this.rdbtn_AbsentNoPermissionDay.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(165, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 22);
			this.label8.TabIndex = 22;
			this.label8.Text = "قيمة السلفة اذا وجدت";
			// 
			// pnl_AddDay
			// 
			this.pnl_AddDay.Controls.Add(this.label13);
			this.pnl_AddDay.Controls.Add(this.label12);
			this.pnl_AddDay.Controls.Add(this.label11);
			this.pnl_AddDay.Controls.Add(this.label9);
			this.pnl_AddDay.Controls.Add(this.rdbtn_AbsentNoPermissionDay);
			this.pnl_AddDay.Controls.Add(this.label8);
			this.pnl_AddDay.Controls.Add(this.label7);
			this.pnl_AddDay.Controls.Add(this.label6);
			this.pnl_AddDay.Controls.Add(this.btn_AddThisDay);
			this.pnl_AddDay.Controls.Add(this.rdbtn_AbsentPermissionHoliday);
			this.pnl_AddDay.Controls.Add(this.rdbtn_AbsentPermissionDay);
			this.pnl_AddDay.Controls.Add(this.rdbtn_DelayPermissionHours);
			this.pnl_AddDay.Controls.Add(this.txt_Solfa);
			this.pnl_AddDay.Controls.Add(this.label10);
			this.pnl_AddDay.Controls.Add(this.txt_LeaveM);
			this.pnl_AddDay.Controls.Add(this.txt_LeaveH);
			this.pnl_AddDay.Controls.Add(this.txt_ArriveH);
			this.pnl_AddDay.Controls.Add(this.txt_ArriveM);
			this.pnl_AddDay.Controls.Add(this.dateTimePicker1);
			this.pnl_AddDay.Controls.Add(this.label5);
			this.pnl_AddDay.Controls.Add(this.cmbx_EmployeeNames);
			this.pnl_AddDay.Controls.Add(this.label4);
			this.pnl_AddDay.Location = new System.Drawing.Point(15, 12);
			this.pnl_AddDay.Name = "pnl_AddDay";
			this.pnl_AddDay.Size = new System.Drawing.Size(625, 360);
			this.pnl_AddDay.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(353, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 22);
			this.label7.TabIndex = 21;
			this.label7.Text = "وقت الانصراف";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(489, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 22);
			this.label6.TabIndex = 20;
			this.label6.Text = "وقت الوصول";
			// 
			// btn_AddThisDay
			// 
			this.btn_AddThisDay.Location = new System.Drawing.Point(267, 282);
			this.btn_AddThisDay.Name = "btn_AddThisDay";
			this.btn_AddThisDay.Size = new System.Drawing.Size(75, 23);
			this.btn_AddThisDay.TabIndex = 19;
			this.btn_AddThisDay.Text = "اضافة";
			this.btn_AddThisDay.UseVisualStyleBackColor = true;
			this.btn_AddThisDay.Click += new System.EventHandler(this.btn_AddThisDay_Click);
			// 
			// rdbtn_AbsentPermissionHoliday
			// 
			this.rdbtn_AbsentPermissionHoliday.AutoSize = true;
			this.rdbtn_AbsentPermissionHoliday.Location = new System.Drawing.Point(28, 258);
			this.rdbtn_AbsentPermissionHoliday.Name = "rdbtn_AbsentPermissionHoliday";
			this.rdbtn_AbsentPermissionHoliday.Size = new System.Drawing.Size(127, 17);
			this.rdbtn_AbsentPermissionHoliday.TabIndex = 18;
			this.rdbtn_AbsentPermissionHoliday.TabStop = true;
			this.rdbtn_AbsentPermissionHoliday.Text = "غيايب من أيام الاجازات";
			this.rdbtn_AbsentPermissionHoliday.UseVisualStyleBackColor = true;
			// 
			// rdbtn_AbsentPermissionDay
			// 
			this.rdbtn_AbsentPermissionDay.AutoSize = true;
			this.rdbtn_AbsentPermissionDay.Location = new System.Drawing.Point(28, 203);
			this.rdbtn_AbsentPermissionDay.Name = "rdbtn_AbsentPermissionDay";
			this.rdbtn_AbsentPermissionDay.Size = new System.Drawing.Size(69, 17);
			this.rdbtn_AbsentPermissionDay.TabIndex = 17;
			this.rdbtn_AbsentPermissionDay.TabStop = true;
			this.rdbtn_AbsentPermissionDay.Text = "غياب بإذن";
			this.rdbtn_AbsentPermissionDay.UseVisualStyleBackColor = true;
			// 
			// rdbtn_DelayPermissionHours
			// 
			this.rdbtn_DelayPermissionHours.AutoSize = true;
			this.rdbtn_DelayPermissionHours.Location = new System.Drawing.Point(28, 180);
			this.rdbtn_DelayPermissionHours.Name = "rdbtn_DelayPermissionHours";
			this.rdbtn_DelayPermissionHours.Size = new System.Drawing.Size(68, 17);
			this.rdbtn_DelayPermissionHours.TabIndex = 15;
			this.rdbtn_DelayPermissionHours.TabStop = true;
			this.rdbtn_DelayPermissionHours.Text = "تأخير بإذن";
			this.rdbtn_DelayPermissionHours.UseVisualStyleBackColor = true;
			// 
			// txt_Solfa
			// 
			this.txt_Solfa.Location = new System.Drawing.Point(180, 200);
			this.txt_Solfa.Name = "txt_Solfa";
			this.txt_Solfa.Size = new System.Drawing.Size(113, 20);
			this.txt_Solfa.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(407, 157);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 13);
			this.label10.TabIndex = 13;
			// 
			// txt_LeaveM
			// 
			this.txt_LeaveM.Location = new System.Drawing.Point(425, 202);
			this.txt_LeaveM.Name = "txt_LeaveM";
			this.txt_LeaveM.Size = new System.Drawing.Size(31, 20);
			this.txt_LeaveM.TabIndex = 10;
			// 
			// txt_LeaveH
			// 
			this.txt_LeaveH.Location = new System.Drawing.Point(357, 202);
			this.txt_LeaveH.Name = "txt_LeaveH";
			this.txt_LeaveH.Size = new System.Drawing.Size(31, 20);
			this.txt_LeaveH.TabIndex = 9;
			// 
			// txt_ArriveH
			// 
			this.txt_ArriveH.Location = new System.Drawing.Point(500, 202);
			this.txt_ArriveH.Name = "txt_ArriveH";
			this.txt_ArriveH.Size = new System.Drawing.Size(31, 20);
			this.txt_ArriveH.TabIndex = 8;
			// 
			// txt_ArriveM
			// 
			this.txt_ArriveM.Location = new System.Drawing.Point(561, 202);
			this.txt_ArriveM.Name = "txt_ArriveM";
			this.txt_ArriveM.Size = new System.Drawing.Size(31, 20);
			this.txt_ArriveM.TabIndex = 7;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(214, 101);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(496, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 22);
			this.label5.TabIndex = 2;
			this.label5.Text = "اسم الموظف";
			// 
			// cmbx_EmployeeNames
			// 
			this.cmbx_EmployeeNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbx_EmployeeNames.FormattingEnabled = true;
			this.cmbx_EmployeeNames.Location = new System.Drawing.Point(169, 62);
			this.cmbx_EmployeeNames.Name = "cmbx_EmployeeNames";
			this.cmbx_EmployeeNames.Size = new System.Drawing.Size(251, 26);
			this.cmbx_EmployeeNames.TabIndex = 1;
			this.cmbx_EmployeeNames.SelectedIndexChanged += new System.EventHandler(this.cmbx_EmployeeNames_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(214, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "اضافة يوم عمل جديد";
			// 
			// btn_AddNewEmployee
			// 
			this.btn_AddNewEmployee.Location = new System.Drawing.Point(479, 396);
			this.btn_AddNewEmployee.Name = "btn_AddNewEmployee";
			this.btn_AddNewEmployee.Size = new System.Drawing.Size(107, 35);
			this.btn_AddNewEmployee.TabIndex = 8;
			this.btn_AddNewEmployee.Text = "إضافة موظف جديد";
			this.btn_AddNewEmployee.UseVisualStyleBackColor = true;
			this.btn_AddNewEmployee.Click += new System.EventHandler(this.btn_AddNewEmployee_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "إضافة موظف جديد";
			// 
			// btn_AddDay
			// 
			this.btn_AddDay.Location = new System.Drawing.Point(58, 396);
			this.btn_AddDay.Name = "btn_AddDay";
			this.btn_AddDay.Size = new System.Drawing.Size(112, 35);
			this.btn_AddDay.TabIndex = 9;
			this.btn_AddDay.Text = "اضافة يوم";
			this.btn_AddDay.UseVisualStyleBackColor = true;
			this.btn_AddDay.Click += new System.EventHandler(this.btn_AddDay_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(513, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "اسم الموظف";
			// 
			// pnl_AddEmployee
			// 
			this.pnl_AddEmployee.Controls.Add(this.btn_AddEmployee);
			this.pnl_AddEmployee.Controls.Add(this.txt_EmployeeSalary);
			this.pnl_AddEmployee.Controls.Add(this.txt_EmployeeName);
			this.pnl_AddEmployee.Controls.Add(this.label3);
			this.pnl_AddEmployee.Controls.Add(this.label2);
			this.pnl_AddEmployee.Controls.Add(this.label1);
			this.pnl_AddEmployee.Location = new System.Drawing.Point(15, 12);
			this.pnl_AddEmployee.Name = "pnl_AddEmployee";
			this.pnl_AddEmployee.Size = new System.Drawing.Size(625, 363);
			this.pnl_AddEmployee.TabIndex = 10;
			// 
			// btn_AddEmployee
			// 
			this.btn_AddEmployee.Location = new System.Drawing.Point(266, 252);
			this.btn_AddEmployee.Name = "btn_AddEmployee";
			this.btn_AddEmployee.Size = new System.Drawing.Size(75, 23);
			this.btn_AddEmployee.TabIndex = 5;
			this.btn_AddEmployee.Text = "اضافة";
			this.btn_AddEmployee.UseVisualStyleBackColor = true;
			this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
			// 
			// txt_EmployeeSalary
			// 
			this.txt_EmployeeSalary.Location = new System.Drawing.Point(179, 150);
			this.txt_EmployeeSalary.Name = "txt_EmployeeSalary";
			this.txt_EmployeeSalary.Size = new System.Drawing.Size(288, 20);
			this.txt_EmployeeSalary.TabIndex = 4;
			// 
			// txt_EmployeeName
			// 
			this.txt_EmployeeName.Location = new System.Drawing.Point(179, 89);
			this.txt_EmployeeName.Name = "txt_EmployeeName";
			this.txt_EmployeeName.Size = new System.Drawing.Size(288, 20);
			this.txt_EmployeeName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(542, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "المرتب";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 452);
			this.Controls.Add(this.btn_ShowData);
			this.Controls.Add(this.btn_AddNewEmployee);
			this.Controls.Add(this.btn_AddDay);
			this.Controls.Add(this.pnl_AddDay);
			this.Controls.Add(this.pnl_AddEmployee);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.pnl_AddDay.ResumeLayout(false);
			this.pnl_AddDay.PerformLayout();
			this.pnl_AddEmployee.ResumeLayout(false);
			this.pnl_AddEmployee.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_ShowData;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdbtn_AbsentNoPermissionDay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel pnl_AddDay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_AddThisDay;
		private System.Windows.Forms.RadioButton rdbtn_AbsentPermissionHoliday;
		private System.Windows.Forms.RadioButton rdbtn_AbsentPermissionDay;
		private System.Windows.Forms.RadioButton rdbtn_DelayPermissionHours;
		private System.Windows.Forms.TextBox txt_Solfa;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_LeaveM;
		private System.Windows.Forms.TextBox txt_LeaveH;
		private System.Windows.Forms.TextBox txt_ArriveH;
		private System.Windows.Forms.TextBox txt_ArriveM;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbx_EmployeeNames;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_AddNewEmployee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_AddDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnl_AddEmployee;
		private System.Windows.Forms.Button btn_AddEmployee;
		private System.Windows.Forms.TextBox txt_EmployeeSalary;
		private System.Windows.Forms.TextBox txt_EmployeeName;
		private System.Windows.Forms.Label label3;
	}
}

