using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoCompuny {
	public class Day : WorkTime , IComparable {
		private String mDayName;
		private DateTime mDate;
		private double mDefaultHourSalary;
		private double mDefaultOverTimeHourSalary;
		private double mDelayPenaltySalary;
		private double mDaySolfa;
		private double mOverTimeSalary;

		public String DayName { get { return mDayName; } set { mDayName = value; } }
		public DateTime Date { get { return mDate; } set { mDate = value; } }
		public double DelayPenaltyMoney { get { return mDefaultHourSalary; } set { mDelayPenaltySalary = value; } }
		public double Solfa { get { return mDaySolfa; } set { mDaySolfa = value; } }
		public double OverTimeMoney { get { return mOverTimeSalary; } set { mOverTimeSalary = value; } }
		public double DefaultHourSalary { get { return mDefaultHourSalary; } set { mDefaultHourSalary = value; mDefaultOverTimeHourSalary = mDefaultHourSalary * 1.5; } }

		public Day(DateTime date, double defaultHourSalary, double daySolfa, TimeNode arriveTime, TimeNode leaveTime,
			bool delayPermission, bool absentPermission, bool absentNoPermission, bool holidayPermission)
			: base(arriveTime, leaveTime, delayPermission, absentPermission, absentNoPermission, holidayPermission) {
			this.mDate = date;
			this.mDayName = date.Date.ToString("yyyy/MM/dd");
			this.mDefaultHourSalary = defaultHourSalary;
			this.mDaySolfa = daySolfa;
			this.mDefaultOverTimeHourSalary = defaultHourSalary * 1.5;
			this.mDelayPenaltySalary = this.PenaltyDelayHours * this.mDefaultHourSalary;
			this.mOverTimeSalary = this.OverTimeHours * this.mDefaultOverTimeHourSalary;
		}

		public Day(DateTime date, double defaultHourSalary, double daySolfa, WorkTime tempWorkTime)
			: base(tempWorkTime.ArriveTime, tempWorkTime.LeaveTime, tempWorkTime.HoursDelayPermission,
			tempWorkTime.AbsentDayPermission, tempWorkTime.AbsentDayNoPermission, tempWorkTime.HoliDayPermission) {
			this.mDate = date;
			this.mDayName = date.Date.ToString("yyyy/MM/dd");
			this.mDefaultHourSalary = defaultHourSalary;
			this.mDaySolfa = daySolfa;
			this.mDefaultOverTimeHourSalary = defaultHourSalary * 1.5;
			this.mDelayPenaltySalary = this.PenaltyDelayHours * this.mDefaultHourSalary;
			this.mOverTimeSalary = this.OverTimeHours * this.mDefaultOverTimeHourSalary;
		}

		public Day(Day tempDay) : base(tempDay.ArriveTime, tempDay.LeaveTime, tempDay.HoursDelayPermission,
			tempDay.AbsentDayPermission, tempDay.AbsentDayNoPermission, tempDay.HoliDayPermission) {
			this.mDate = tempDay.Date;
			this.mDayName = tempDay.DayName;
			this.mDefaultHourSalary = tempDay.DelayPenaltyMoney;
			this.mDaySolfa = tempDay.Solfa;
			this.mDefaultOverTimeHourSalary = tempDay.mDefaultOverTimeHourSalary;
			this.mDelayPenaltySalary = this.PenaltyDelayHours * this.mDefaultHourSalary;
			this.mOverTimeSalary = this.OverTimeHours * this.mDefaultOverTimeHourSalary;
		}

		public static bool operator ==(Day tempday1, Day tempDay2) {
			return (tempday1.DayName.Equals(tempDay2.DayName));
		}

		public static bool operator !=(Day tempday1, Day tempDay2) {
			return !(tempday1.DayName.Equals(tempDay2.DayName));
		}

		public override bool Equals(object obj) {
			if (obj == null) return false;
			Day tempDay = obj as Day;
			if (tempDay == null) return false;
			return this.DayName.Equals(tempDay.DayName);
		}

		public override string ToString() {
			String str = base.ToString();
			str += this.DayName + "\n";
			str += this.mDefaultHourSalary.ToString() + " | " + this.mDefaultOverTimeHourSalary + "\n";
			str += this.mDelayPenaltySalary + " | " + this.Solfa + " | " + this.OverTimeMoney + "\n";
			str += (this.OverTimeMoney - this.DelayPenaltyMoney - this.Solfa).ToString();
			return str;
		}

		public int CompareTo(object obj) {
			if (obj == null) return 1;
			Day day = obj as Day;
			if (day != null) return this.Date.CompareTo(day.Date);
			else throw new ArgumentException("Object is not a Temperature");
		}
		
	}
}
