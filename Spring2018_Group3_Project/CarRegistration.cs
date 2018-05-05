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
        public int iDays { get; set; }
        public DateTime dtStart { get; set; }
        public DateTime dtReturn { get; set; }

        // Constructor, which requires parameters. Otherwise, initialize as null and pass a user-defined object.
        public CarRegistration(Car carTemp, int days, DateTime dtBegin, DateTime dtEnd)
        {
            car = carTemp;
            iDays = days;
            dtStart = dtBegin;
            dtReturn = dtEnd;
        }
    }
}
