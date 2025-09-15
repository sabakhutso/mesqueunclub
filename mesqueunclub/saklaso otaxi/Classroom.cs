using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesqueunclub
{
    internal class ClassRoom
{
    private List<moswavle> students;

   
    public ClassRoom(params moswavle[] students)
    {
        this.students = new List<moswavle>(students);
    }

      
        public void yvelastudenti()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"\n\n    {student.Name}-is shefaseba ");
                student.swavla();
                student.kitxva();
                student.wera();
                student.dasveneba();
            }
        }

    }

}
