using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoCompuny {

	public class TimeNode {
		private int mHour;
		private int mMinut;

		public int Hour { get { return mHour; } set { mHour = value; } }
		public int Minut { get { return mMinut; } set { mMinut = value; } }

		public TimeNode(int hour, int minuts) {
			this.mHour = hour;
			this.mMinut = minuts;
		}

		public TimeNode(TimeNode tempNode) {
			this.mHour = tempNode.Hour;
			this.mMinut = tempNode.Minut;
		}

		public static bool operator ==(TimeNode tempNode1, TimeNode tempNode2) {
			return (tempNode1.Hour == tempNode2.Hour && tempNode1.Minut == tempNode2.Minut);
		}

		public static bool operator !=(TimeNode tempNode1, TimeNode tempNode2) {
			return !(tempNode1.Hour == tempNode2.Hour && tempNode1.Minut == tempNode2.Minut);
		}

		public static int operator -(TimeNode tempNode1, TimeNode tempNode2) {
			return (tempNode1.Hour - tempNode2.Hour) * 60 + (tempNode1.Minut - tempNode2.Minut);
		}

		public override string ToString() {
			return mHour.ToString() + " : " + mMinut.ToString() + "\n";
		}
	}

	public class WorkTime {
		private TimeNode mArriveTime;
		private TimeNode mLeaveTime;
		private static readonly TimeNode mDefaultArrive = new TimeNode(9, 0);
		private static readonly TimeNode mDefaultLeave = new TimeNode(5, 0);
		private int mDelayMinuts;
		private int mPenaltyDelayHours;
		private int mOverTimeMunits;
		private double mOverTimeHours;
		private bool mHoursDelayPermission;
		private bool mAbsentDayPermission;
		private bool mAbsentDayNoPermission;
		private bool mHolidayPermission;

		public TimeNode ArriveTime { get { return mArriveTime; } set { mArriveTime = value; } }
		public TimeNode LeaveTime { get { return mLeaveTime; } set { mLeaveTime = value; } }
		public int DelayMinuts { get { return mDelayMinuts; } set { mDelayMinuts = value; } }
		public int PenaltyDelayHours { get { return mPenaltyDelayHours; } set { mPenaltyDelayHours = value; } }
		public int OverTimeMinuts { get { return mOverTimeMunits; } set { mOverTimeMunits = value; } }
		public double OverTimeHours { get { return mOverTimeHours; } set { mOverTimeHours = value; } }
		public bool HoursDelayPermission { get { return mHoursDelayPermission; } set { mHoursDelayPermission = value; } }
		public bool AbsentDayPermission { get { return mAbsentDayPermission; } set { mAbsentDayPermission = value; } }
		public bool AbsentDayNoPermission { get { return mAbsentDayNoPermission; } set { mAbsentDayNoPermission = value; } }
		public bool HoliDayPermission { get { return mHolidayPermission; } set { mHolidayPermission = value; } }
		
		public WorkTime(TimeNode arriveTime, TimeNode leaveTime, bool delayPermission, bool absentPermission,
			bool absentNoPermission, bool holidayPermission) {
			this.mArriveTime = new TimeNode(arriveTime);
			this.mLeaveTime = new TimeNode(leaveTime);
			this.mHoursDelayPermission = delayPermission;
			this.mAbsentDayPermission = absentPermission;
			this.mAbsentDayNoPermission = absentNoPermission;
			this.mHolidayPermission = holidayPermission;
			this.mDelayMinuts = this.CalculateDelayMinuts();
			this.mPenaltyDelayHours = this.CalculatePenaltyHours();
			this.mOverTimeMunits = this.CalculateOverTimeMunits();
			this.mOverTimeHours = (double)(this.mOverTimeMunits / 60.0);
		}

		public WorkTime(WorkTime tempWorkTime) {
			this.mArriveTime = new TimeNode(tempWorkTime.ArriveTime);
			this.mLeaveTime = new TimeNode(tempWorkTime.LeaveTime);
			this.mHoursDelayPermission = tempWorkTime.HoursDelayPermission;
			this.mAbsentDayPermission = tempWorkTime.AbsentDayPermission;
			this.mAbsentDayNoPermission = tempWorkTime.AbsentDayNoPermission;
			this.mHolidayPermission = tempWorkTime.HoliDayPermission;
			this.mDelayMinuts = this.CalculateDelayMinuts();
			this.mPenaltyDelayHours = this.CalculatePenaltyHours();
			this.mOverTimeMunits = this.CalculateOverTimeMunits();
			this.mOverTimeHours = (double)(this.mOverTimeMunits / 60.0);
		}

		private int CalculateOverTimeMunits() {
			int pnt = this.mLeaveTime - mDefaultLeave;
			return (pnt <= 15) ? 0 : pnt;
		}

		private int CalculatePenaltyHours() {
			if (mHolidayPermission) return 0;
			if (mAbsentDayPermission) return 8;
			if (mAbsentDayNoPermission) return 16;
			int penaltyMinuts = 0;
			if (mDelayMinuts <= 15) penaltyMinuts = 0;
			else if (mDelayMinuts <= 30) penaltyMinuts = 1;
			else if (mDelayMinuts <= 45) penaltyMinuts = 2;
			else if (mDelayMinuts <= 60) penaltyMinuts = 4;
			else if (mDelayMinuts <= 120) penaltyMinuts = 8;
			else if (mDelayMinuts > 120) penaltyMinuts = 16;
			if (mHoursDelayPermission) penaltyMinuts = (int)Math.Ceiling(mDelayMinuts / 60.0);
			return penaltyMinuts;
		}

		private int CalculateDelayMinuts() {
			int pnt = this.mArriveTime - mDefaultArrive;
			return (pnt <= 15) ? 0 : pnt;
		}

		public override string ToString() {
			String str = mArriveTime.ToString() + mLeaveTime.ToString();
			str += this.DelayMinuts.ToString() + " | " + this.PenaltyDelayHours.ToString() + "\n";
			str += this.OverTimeMinuts.ToString() + " | " + this.OverTimeHours.ToString() + "\n";
			return str;
		}

	}
}
