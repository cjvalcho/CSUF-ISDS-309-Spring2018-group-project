using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring2018_Group3_Project
{
    public class CarRegistration
    {
        // Variables
        public Car car { get; set; }
        public int iDays { get; private set; }
        public int iDay
        {
            get
            {
                return iDays;
            }
            set
            {
                if (value <= 0)
                {
                    NegativeDateException nde = new NegativeDateException();
                    throw (nde);
                }
                iDays = value;
            }
        }
        public DateTime dtStart { get; set; }
        public DateTime dtReturn { get; set; }
        public TimeSpan tCalcTime { get; set; }

        // Default constructor
        public CarRegistration()
        {
            car = null;
            iDays = 0;
            iDay = 1;
            dtStart = DateTime.Today;
            dtReturn = DateTime.Today;
            tCalcTime = dtReturn - dtStart;
        }

        // Constructor with parameters
        public CarRegistration(Car carTemp, int days, DateTime dtBegin, DateTime dtEnd)
        {
            car = carTemp;
            iDays = days;
            dtStart = dtBegin;
            dtReturn = dtEnd;
        }

        // Calculate total days
        public void dayConvert()
        {
            tCalcTime = dtReturn - dtStart;
            iDay = (Convert.ToInt32(tCalcTime.TotalDays) + 1);
        }
    }
}
