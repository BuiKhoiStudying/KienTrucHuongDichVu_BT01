using System;

namespace TestNo1
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public int Age { get; set; }

        //Object o;
        public override string ToString()
        {
            return ("MSSV = " + MSSV + ", NameSV = " + NameSV + ", Age = " + Age);
        }
    }
}