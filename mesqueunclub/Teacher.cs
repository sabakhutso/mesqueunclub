using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesqueunclub
{
    internal class Teacher
    {
        public string Name { get; set; }
        public bool Certified { get; set; }

        private static Random random = new Random();

        public void CheckSubject(string subject)
        {
            if (subject == "math")
            {
                int a = random.Next(1, 10);
                int b = random.Next(1, 10);
                Console.WriteLine($"chosen subject is math → {a} + {b} = {a + b}");
            }
            else if (subject == "chemistry")
            {
                string[] formulas = { "H2O", "CO2", "NaCl", "CH4" };
                Console.WriteLine($"chosen subject is chemistry  → Formula: {formulas[random.Next(formulas.Length)]}");
            }
            else if (subject == "spanish")
            {
                string[] texts = { "hola, como estas?", "tu eres muy hermosa", "yo soy ronald araujo" };
                Console.WriteLine($"chosen subject is spanish your random phrase is  → {texts[random.Next(texts.Length)]}");
            }
            else
            {
                Console.WriteLine($"Teacher is not certified in this {subject}");
            }
        }
    }
}
