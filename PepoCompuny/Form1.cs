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
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			WorkTime workTime = new WorkTime(new TimeNode(9, 0), new TimeNode(6, 6), true, false, false, false );
			MessageBox.Show(workTime.ToString());
			Day newDay = new Day(DateTime.Now, 0, 0, workTime);
			MessageBox.Show(newDay.ToString());
			Employee emp = new Employee("Bla", 2500);
			MessageBox.Show(emp.AddDay(newDay));
			MessageBox.Show(emp.ToString());
			MessageBox.Show(emp.WorkMonths.Values.ElementAt(0).TotalSalary().ToString());
		}
	}
}
