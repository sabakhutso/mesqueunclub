using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesqueunclub
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Date { get; set; }

        private static Random random = new Random();


        public string randomsubjects()
        {
            string[] subjects = { "math", "science", "history", "biology", "chemistry", "spanish" };
            int index = random.Next(subjects.Length);
            return subjects[index];
        }


        public int graduationyear() 
        {
            int currentdate = DateTime.Now.Year;
            int yearsinuni = Date - currentdate;

            int yearsLeft = yearsinuni - Date;
            return yearsLeft > 0 ? yearsLeft : 0;
        }
    }
}
