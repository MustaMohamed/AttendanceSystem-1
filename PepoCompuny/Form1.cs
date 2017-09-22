using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepoCompuny {
	public partial class Form1 : Form {
		Employee TempEmployee;
		Dictionary<String, Employee> EmployeeList;
		List<string> EmployeeNamesList;
		public Form1() {
			InitializeComponent();
			EmployeeNamesList = new List<String>();
			EmployeeNamesList.Add("اختر اسم الموظف");
			EmployeeList = new Dictionary<String, Employee>();
			initData(); initPanel(true);
		}

		private void initData() {
			BinaryFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("MyFile.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
			try {
				EmployeeList = new Dictionary<String, Employee>((Dictionary<String, Employee>)formatter.Deserialize(stream));
				foreach (string s in EmployeeList.Keys) {
					EmployeeNamesList.Add(s);
				}
			} catch (Exception) {
				MessageBox.Show("Didn't");
			} finally {
				stream.Close();
			}
			
		}

		/*
		 * Change the Panel to add new Employee
		 */
		private void btn_AddNewEmployee_Click(object sender, EventArgs e) {
			pnl_AddDay.Hide(); pnl_AddEmployee.Show();
			txt_EmployeeName.Clear(); txt_EmployeeSalary.Clear();
		}

		/*
		 * Change the Panel to add new Day for Employee
		 */
		private void btn_AddDay_Click(object sender, EventArgs e) {
			pnl_AddDay.Show(); pnl_AddEmployee.Hide();
			initPanel(true);
		}

		/*
		 * This Section for adding Employee Data and validate it
		 */
		private void btn_AddEmployee_Click(object sender, EventArgs e) {
			String tempEmpName = txt_EmployeeName.Text, tempEmpSalary = txt_EmployeeSalary.Text;
			double empSalary = 0.0;
			if (tempEmpName == "") {
				MessageBox.Show("! يوجد خطأ في خانة اسم الموظف"); return;
			} else if(EmployeeList.ContainsKey(tempEmpName)) {
				MessageBox.Show("! هذا الاسم موجود مسبقاً"); return;
			}
			try {
				empSalary = Double.Parse(tempEmpSalary);
			} catch (Exception) {
				MessageBox.Show("! يوجد خطأ في خانة المرتب"); return;
			} TempEmployee = new Employee(tempEmpName, empSalary);
			EmployeeList[tempEmpName] = TempEmployee;  MessageBox.Show("تم الحفظ !");
			EmployeeNamesList.Add(tempEmpName); txt_EmployeeName.Clear(); txt_EmployeeSalary.Clear();
		}

		private void initPanel(bool stat) {
			txt_ArriveH.Clear(); txt_ArriveM.Clear(); txt_LeaveH.Clear();
			txt_LeaveM.Clear(); txt_Solfa.Clear(); rdbtn_AbsentNoPermissionDay.Checked = false;
			rdbtn_AbsentPermissionDay.Checked = false; rdbtn_AbsentPermissionHoliday.Checked = false;
			rdbtn_DelayPermissionHours.Checked = false; 
			foreach(String s in EmployeeNamesList) {
				if (!cmbx_EmployeeNames.Items.Contains(s)) cmbx_EmployeeNames.Items.Add(s);
			} if (stat) cmbx_EmployeeNames.SelectedIndex = 0;
		}
		/*
		 * This Section for adding Day Data and validate it for an Employee
		 */

		// Select Employee
		private void cmbx_EmployeeNames_SelectedIndexChanged(object sender, EventArgs e) {
			initPanel(false);
		}

		// Select Day
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
			initPanel(false);
		}

		// Validate the Day Data
		private void btn_AddThisDay_Click(object sender, EventArgs e) {
			TimeNode tempArriveNode, tempLeaveNode;
			if (cmbx_EmployeeNames.SelectedIndex == 0) {
				MessageBox.Show("اختر اسم الموظف أولاً !");
				return;
			} if (!CheckArriveTime() && !(rdbtn_AbsentPermissionHoliday.Checked ||
				rdbtn_AbsentPermissionDay.Checked || rdbtn_AbsentNoPermissionDay.Checked)) {
				MessageBox.Show("يوجد خطأ في وقت الوصول !"); return;
			} else {
				if ((rdbtn_AbsentPermissionHoliday.Checked ||
				rdbtn_AbsentPermissionDay.Checked || rdbtn_AbsentNoPermissionDay.Checked)) {
					tempArriveNode = new TimeNode(-1, -1);
					tempLeaveNode = new TimeNode(-1, -1);
				} else {
					tempArriveNode = new TimeNode(int.Parse(txt_ArriveH.Text), int.Parse(txt_ArriveM.Text));
				}
			}
			if (!CheckLeaveTime() && !(rdbtn_AbsentPermissionHoliday.Checked ||
				rdbtn_AbsentPermissionDay.Checked || rdbtn_AbsentNoPermissionDay.Checked)) {
				MessageBox.Show("يوجد خطأ في وقت الانصراف !"); return;
			} else {
				if ((rdbtn_AbsentPermissionHoliday.Checked ||
				rdbtn_AbsentPermissionDay.Checked || rdbtn_AbsentNoPermissionDay.Checked)) {
					tempArriveNode = new TimeNode(-1, -1);
					tempLeaveNode = new TimeNode(-1, -1);
				} else {
					tempLeaveNode = new TimeNode(int.Parse(txt_LeaveH.Text), int.Parse(txt_LeaveM.Text));
				}
			} double Solfa = 0.0;
			if (!CheckSolfa()) {
				MessageBox.Show("يوجد خطأ في خانة السلفة !"); return;
			} else if (txt_Solfa.Text != "") Solfa = Double.Parse(txt_Solfa.Text);
			String EmpName = cmbx_EmployeeNames.SelectedItem.ToString(), SelectedDate = "";
			TempEmployee = new Employee(EmployeeList[EmpName]);
			if (!CheckPermission()) {
				return;
			} WorkTime tempWorkTime = new WorkTime(tempArriveNode, tempLeaveNode, rdbtn_DelayPermissionHours.Checked,
				rdbtn_AbsentPermissionDay.Checked, rdbtn_AbsentNoPermissionDay.Checked, rdbtn_AbsentPermissionHoliday.Checked);
			String monthKey = dateTimePicker1.Value.Date.ToString("yyyy/MM");
			String dayKey = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
			if (TempEmployee.WorkMonths.ContainsKey(monthKey)
				&& TempEmployee.WorkMonths[monthKey].MonthHistory.ContainsKey(dayKey)) {
				DialogResult dialogResult = MessageBox.Show("هذا التاريخ موجود بالفعل .. هل تريد التعديل ؟", "تعديل التاريخ", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No) return;
			}
			TempEmployee.AddDay(new Day(dateTimePicker1.Value.Date, 0, Solfa, tempWorkTime));
			EmployeeList[EmpName] = new Employee(TempEmployee);
			initPanel(false);
		}
		private bool CheckPermission() {
			if (TempEmployee.HolidayDays == 0 && rdbtn_AbsentPermissionHoliday.Checked) {
				MessageBox.Show("! لقد استوفى الموظف جميع ايام الاجازات المتاحة");
				return false;
			} return true;
		}

		private bool CheckSolfa() {
			if (txt_Solfa.Text == "") return true;
			try {
				double hh = Double.Parse(txt_Solfa.Text);
				return true;
			} catch (Exception) {
				return false;
			}
		}

		private bool CheckLeaveTime() {
			try {
				int hh = int.Parse(txt_LeaveH.Text);
				int mm = int.Parse(txt_LeaveM.Text);
				return (hh > 0 && hh <= 12 && mm >= 0 && mm < 60);
			} catch (Exception) {
				return false;
			}
		}

		private bool CheckArriveTime() {
			try {
				int hh = int.Parse(txt_ArriveH.Text);
				int mm = int.Parse(txt_ArriveM.Text);
				return (hh > 0 && hh <= 12 && mm >= 0 && mm < 60);
			} catch (Exception) {
				return false;
			}
		}

		private void btn_ShowData_Click(object sender, EventArgs e) {
			Form2 f = new Form2(EmployeeList);
			f.Show();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			BinaryFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("MyFile.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
			try {
				formatter.Serialize(stream, EmployeeList);
				stream.Close();
			} catch(Exception) {}
			finally {
				if (null != stream)
					stream.Close();
			}
		}


	

	}
}
