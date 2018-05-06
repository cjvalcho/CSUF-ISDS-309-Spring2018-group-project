using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Array;
using System.IO;

namespace Spring2018_Group3_Project
{
    public class CarDatabase
    {
        // CarDatabase Variables
        public List<Car> carList;

        // Constructor
        public CarDatabase()
        {
            carList = new List<Car>();
        }

        // Searches the list for a specific car and returns that car object
        public Car Find(string strSearch)
        {
            int i = 0;
            while (this.carList[i].strModel != strSearch)
            {
                i++;
            }
            return carList[i];
        }

        // Opens and reads from a provided file, populates a carList, and then closes the file
        public static CarDatabase FileReader(string strFilename)
        {
            // Method Variables
            const char DELIM = ';';
            string strRecordIn;
            string[] strFields;
            CarDatabase carTempData = new CarDatabase();
            FileStream inFile = null;
            StreamReader reader = null;

            try
            {
                // Opens the file and File Stream
                    inFile = new FileStream(strFilename, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);

                // Process
                strRecordIn = reader.ReadLine();

                // Loop
                while (strRecordIn != null)
                {
                    // Declares a new object and populates an array with information from the file
                    Car carTemp = new Car();
                    strFields = strRecordIn.Split(DELIM);

                    // Assigns the information stored in the temporary array into the temp object
                    carTemp.strCategory = strFields[0];
                    carTemp.strMake = strFields[1];
                    carTemp.strModel = strFields[2];
                    carTemp.dblRate = Convert.ToDouble(strFields[3]);

                    // Adds the temporary object to the carData's list
                    carTempData.carList.Add(carTemp);

                    // Reads a new line
                    strRecordIn = reader.ReadLine();
                }
            }
            finally
            {
                // Closes the File
                if (reader != null)
                {
                    reader.Close();
                }
                if (inFile != null)
                {
                    inFile.Close();
                }
            }
            return carTempData;
        }
    }

}
