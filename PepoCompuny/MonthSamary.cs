using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoCompuny {
	[Serializable]
	public class MonthSamary : IComparable {
		private String mMonthName;
		private double mDefaultMonthSalary;
		private double mDefaultHourSalary;
		private Dictionary<String, Day> mMonthHistory;

		public String MonthName { get { return mMonthName; } set { mMonthName = value; } }
		public double DefaultMonthSalary { get { return mDefaultMonthSalary; } set { mDefaultMonthSalary = value; } }
		public double DefaultHourSalary { get { return mDefaultHourSalary; } set { mDefaultHourSalary = value; } }
		public Dictionary<String, Day> MonthHistory { get { return new Dictionary<string, Day>(mMonthHistory); } set { mMonthHistory = new Dictionary<string, Day>(value); } }

		public MonthSamary(String monthName, double monthSalary) {
			this.mMonthName = monthName;
			this.mDefaultMonthSalary = monthSalary;
			this.mDefaultHourSalary = monthSalary / (30.0 * 24.0);
			this.mMonthHistory = new Dictionary<String,Day>();
		}

		public MonthSamary(MonthSamary monthSamary) {
			this.mMonthName = monthSamary.MonthName;
			this.mDefaultMonthSalary = monthSamary.DefaultMonthSalary;
			this.mDefaultHourSalary = monthSamary.DefaultHourSalary;
			this.mMonthHistory = new Dictionary<string, Day>(monthSamary.MonthHistory);
		}

		public void AddDay(Day tempDay) {
			if (!this.mMonthHistory.ContainsKey(tempDay.DayName)) {
				this.mMonthHistory.Add(tempDay.DayName, new Day(tempDay));
			} else this.mMonthHistory[tempDay.DayName] = new Day(tempDay);
		}

		public double TotalSalary() {
			double totalSalary = this.mDefaultMonthSalary - this.TotalSolfaMoney()
				- this.TotalPenaltyMoney() + this.TotalOverTimeSalary();
			return totalSalary;
		}

		public double TotalOverTimeSalary() {
			double totalOverTimeSalary = 0.0;
			foreach (Day tempDay in this.mMonthHistory.Values) {
				totalOverTimeSalary += tempDay.OverTimeMoney;
			} return totalOverTimeSalary;
		}

		public double TotalSolfaMoney() {
			double totalSolfaMoney = 0.0;
			foreach (Day tempDay in this.mMonthHistory.Values) {
				totalSolfaMoney += tempDay.Solfa;
			} return totalSolfaMoney;
		}

		public double TotalPenaltyMoney() {
			double totalPenaltyMoney = 0.0;
			foreach (Day tempDay in this.mMonthHistory.Values) {
				totalPenaltyMoney += tempDay.DelayPenaltyMoney;
			} return totalPenaltyMoney;
		}

		public double TotalDelayHours() {
			double totalDelayHours = 0.0;
			foreach (Day tempDay in this.mMonthHistory.Values) {
				totalDelayHours += tempDay.DelayMinuts;
			} return totalDelayHours / 60.0;
		}

		public double TotalOverTimeHours() {
			double totalOverTimeHours = 0.0;
			foreach (Day tempDay in this.mMonthHistory.Values) {
				totalOverTimeHours += tempDay.OverTimeHours;
			} return totalOverTimeHours;
		}

		public override string ToString() {
			String str = this.MonthName + " | " + this.DefaultMonthSalary.ToString() + "\n";
			str += this.MonthHistory.Count.ToString();
			return str;
		}

		public override bool Equals(object obj) {
			if (obj == null) return false;
			MonthSamary tempMonth = obj as MonthSamary;
			if (tempMonth == null) return false;
			return this.MonthName.Equals(tempMonth.MonthName);
		}

		public int CompareTo(object obj) {
			if (obj == null) return 1;
			MonthSamary tempMonth = obj as MonthSamary;
			if (tempMonth != null) return this.MonthName.CompareTo(tempMonth.MonthName);
			else throw new ArgumentException("Object is not a Temperature");
		}

	}
}
