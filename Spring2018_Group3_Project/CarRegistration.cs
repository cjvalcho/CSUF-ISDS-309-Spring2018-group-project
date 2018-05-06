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
        private int _iDays;
        public int iDays
        {
            get
            {
                return _iDays;
            }
            set
            {
                if (value <= 0)
                {
                    NegativeDateException nde = new NegativeDateException();
                    throw (nde);
                }
                _iDays = value;
            }
        }
        public DateTime dtStart { get; set; }
        public DateTime dtReturn { get; set; }
        public TimeSpan tCalcTime { get; set; }

        // Default constructor
        public CarRegistration()
        {
            car = null;
            iDays = 1;
            dtStart = DateTime.Today;
            dtReturn = DateTime.Today;
            tCalcTime = dtReturn - dtStart;
        }

        // Calculate total days
        public void dayConvert()
        {
            tCalcTime = dtReturn - dtStart;
            iDays = (Convert.ToInt32(tCalcTime.TotalDays) + 1);
        }
    }
}
