using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace Employee
{
    public class Employee
    {
        class csv
        {
            string filename = ("c:\\test.csv");

            public bool ParseData(string filename)
            {
                  using (CsvReader csv = new CsvReader(new StreamReader(filename), true))
                  {
                    //int fieldCount = csv.FieldCount;

                    int employeeID = csv.GetFieldIndex("employeeID");
                    int managerID = csv.GetFieldIndex("managerID");
                    int employeeSalary = csv.GetFieldIndex("employeeSalary");

                    if (employeeID <= -1)
                    {
                        return false;
                    }

                    int currentIndex = 0;

                    while (csv.ReadNextRecord() && currentIndex > managerID)
                    {
                        return false;
                    }

                   


                }
                return true;
            }

            

        }
    }
}
