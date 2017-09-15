using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoCompuny {
	public class Employee {
		private String mEmployeeName;
		private double mEmployeeSalary;
		private Dictionary<String, MonthSamary> mWorkMonths;

		public String EmployeeName { get { return mEmployeeName; } set { mEmployeeName = value; } }
		public double EmployeeSalary { get { return mEmployeeSalary; } set { mEmployeeSalary = value; } }
		public Dictionary<String, MonthSamary> WorkMonths { get { return mWorkMonths; } set { mWorkMonths = new Dictionary<string, MonthSamary>(value); } }

		public Employee(String empName, double empSalary) {
			this.mEmployeeName = empName;
			this.mEmployeeSalary = empSalary;
			this.mWorkMonths = new Dictionary<string, MonthSamary>();
		}

		public Employee(Employee tempEmployee) {
			this.mEmployeeName = tempEmployee.EmployeeName;
			this.mEmployeeSalary = tempEmployee.EmployeeSalary;
			this.mWorkMonths = new Dictionary<String, MonthSamary>(tempEmployee.WorkMonths);
		}

		public String AddDay(Day tempDay) {
			String monthKey = tempDay.Date.Date.ToString("yyyy/MM/dd");
			if (!this.mWorkMonths.ContainsKey(monthKey)) {
				this.mWorkMonths.Add(monthKey, new MonthSamary(tempDay.Date.Date.ToString("yyyy/MM"), this.mEmployeeSalary));
			} this.mWorkMonths[monthKey].AddDay(tempDay);
			return this.mWorkMonths[monthKey].MonthHistory.Values.ElementAt(0).ToString();
		}

		public override bool Equals(object obj) {
			if (obj == null) return false;
			Employee tempEmployee = obj as Employee;
			if (tempEmployee == null) return false;
			return this.mEmployeeName.Equals(tempEmployee.EmployeeName);
		}

		public override string ToString() {
			return this.EmployeeName + " | " + this.EmployeeSalary.ToString() + " | " + this.WorkMonths.Count.ToString();
		}
	}
}
