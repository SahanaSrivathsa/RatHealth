using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RatHealth
{
    public static class CsvFile
    {
        public static StreamWriter CsvWriter;
        
        public static void openCsvWriter(string rat_no)
        {
            CsvWriter = new StreamWriter(($"C:\\Users\\sahanasrivathsa\\Documents\\Barnes Lab\\Rat Health\\CurrentRats\\{rat_no}\\{rat_no}_HealthLog.csv"), true);
        }
        public static void closeWriter()
        {
            CsvWriter.Close();
        }

    }

    
}
