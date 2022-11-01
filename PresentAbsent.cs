using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesPblm
{
    internal class PresentAbsent
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Atttendece();
        }
    }
    class Emp
    {
        public void Atttendece()
        {
            Random r = new Random();
            int value = r.Next(0, 2);
            // 0 is for present;
            // 1 is for absent;
            if (value == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
   
