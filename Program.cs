using System;

namespace TestNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SV sv1 = new SV
            {
                MSSV = "102",
                NameSV = "TDD",
                Age = 21,
            };

            SV sv2 = new SV
            {
                MSSV = "103",
                NameSV = "BQK",
                Age = 22,
            };

            SV sv3 = new SV
            {
                MSSV = "104",
                NameSV = "NNQ",
                Age = 23,
            };

            QLSV db = new QLSV();
            db.Add(sv1);
            db.Add(sv2);

            db.Insert(sv3, 1);
            db.ToString();

            Console.WriteLine("Index of SV2: " + db.IndexOf(sv2));

            Console.WriteLine("Removing sv3");
            db.Remove(sv3);
            db.ToString();

            Console.WriteLine("Updating sv2");
            SV sv4 = new SV 
            {
                MSSV = "103",
                NameSV = "Khoi Bui",
                Age = 25,
            };
            db.Update(sv4);
            db.ToString();
        }
    }
}
