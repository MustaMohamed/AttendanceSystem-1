using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepoCompuny {
	public partial class Form2 : Form {
		Dictionary<String, Employee> EmployeeContainer;
		Day TempDay; Employee TempEmployee;

		public Form2(Dictionary<String, Employee> Dic) {
			InitializeComponent();
			EmployeeContainer = new Dictionary<String, Employee>(Dic);
			String[] EmployeeNames = new String[EmployeeContainer.Keys.Count + 1];
			EmployeeNames[0] = "أختر اسم الموظف !";
			for (int i = 0; i < EmployeeContainer.Keys.Count; i++)
				EmployeeNames[i + 1] = EmployeeContainer.Keys.ElementAt(i);
			cmbx_EmployeeNames.Items.AddRange(EmployeeNames);
			cmbx_EmployeeNames.SelectedIndex = 0;
			String[] ColNames = { "الشهر", "التاريخ", "حضور", "انصراف", "تأخير", "وقت اضافي", "خصومات ادارية", "سلفة" };
			dataGridView1.ColumnCount = ColNames.Length;
			for (int i = 0; i < ColNames.Length; i++)
				dataGridView1.Columns[i].Name = ColNames[i];
		}

		private void DisplayMonthData(MonthSamary month, Employee emp) {
			String[] row = new String[dataGridView1.ColumnCount]; String monthName = month.MonthName;
			int DelayHours = 0; double OverTimeMin = 0.0, TotSolfa = 0.0, TotPenalty = 0.0;
			foreach (Day day in month.MonthHistory.Values) {
				row[0] = day.Date.Date.Month.ToString();
				row[1] = day.DayName;
				row[2] = day.ArriveTime.ToString();
				row[3] = day.LeaveTime.ToString();
				row[4] = ((double)day.DelayMinuts / 60.0).ToString();
				row[5] = day.OverTimeHours.ToString();
				row[6] = day.DelayPenaltyMoney.ToString();
				row[7] = day.Solfa.ToString();
				dataGridView1.Rows.Add(row);
			}
			row[0] = monthName;
			row[1] = "اجمالي الشهر";
			row[2] = month.TotalSalary().ToString();
			row[3] = "-----";
			row[4] = month.TotalDelayHours().ToString();
			row[5] = month.TotalOverTimeSalary().ToString();
			row[6] = month.TotalPenaltyMoney().ToString();
			row[7] = month.TotalSolfaMoney().ToString();
			dataGridView1.Rows.Add(row);
		}

		private void cmbx_EmployeeNames_SelectedIndexChanged(object sender, EventArgs e) {
			dataGridView1.Rows.Clear();
			if (cmbx_EmployeeNames.SelectedIndex == 0) return;
			String EmpName = cmbx_EmployeeNames.SelectedItem.ToString();
			foreach (String month in EmployeeContainer[EmpName].WorkMonths.Keys) {
				DisplayMonthData(EmployeeContainer[EmpName].WorkMonths[month], EmployeeContainer[EmpName]);
			}
		}



	}
}
