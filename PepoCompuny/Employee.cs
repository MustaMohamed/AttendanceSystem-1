using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoCompuny {
	[Serializable]
	public class Employee {
		
		private String mEmployeeName;
		private double mEmployeeSalary;
		private double mDefaultHourSalary;
		private Dictionary<String, MonthSamary> mWorkMonths;
		private int mHolidayDays;

		public String EmployeeName { get { return mEmployeeName; } set { mEmployeeName = value; } }
		public double EmployeeSalary { get { return mEmployeeSalary; } set { mEmployeeSalary = value; } }
		public Dictionary<String, MonthSamary> WorkMonths { get { return mWorkMonths; } set { mWorkMonths = new Dictionary<string, MonthSamary>(value); } }
		public int HolidayDays { get { return mHolidayDays; } set { mHolidayDays = value; } }
		public double EmployeeHourSalary { get { return mDefaultHourSalary; } set { mDefaultHourSalary = value; } }

		public Employee(String empName, double empSalary) {
			this.mEmployeeName = empName;
			this.mEmployeeSalary = empSalary;
			this.mDefaultHourSalary = this.mEmployeeSalary / (30.0 * 24.0);
			this.mHolidayDays = 21;
			this.mWorkMonths = new Dictionary<string, MonthSamary>();
		}

		public Employee(Employee tempEmployee) {
			this.mEmployeeName = tempEmployee.EmployeeName;
			this.mEmployeeSalary = tempEmployee.EmployeeSalary;
			this.mDefaultHourSalary = tempEmployee.mDefaultHourSalary;
			this.mHolidayDays = tempEmployee.HolidayDays;
			this.mWorkMonths = new Dictionary<String, MonthSamary>(tempEmployee.WorkMonths);
		}

		public void AddDay(Day tempDay) {
			String monthKey = tempDay.Date.Date.ToString("yyyy/MM");
			tempDay.DefaultHourSalary = this.mDefaultHourSalary;
			if (!this.mWorkMonths.ContainsKey(monthKey)) {
				this.mWorkMonths.Add(monthKey, new MonthSamary(tempDay.Date.Date.ToString("yyyy/MM"), this.mEmployeeSalary));
				if(tempDay.Date.Date.Month == 9) this.mHolidayDays = 21;
			} this.mWorkMonths[monthKey].AddDay(new Day(tempDay));
			if (tempDay.HoliDayPermission) this.mHolidayDays--;
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
