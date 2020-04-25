using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRC
{
    class Program
    {
        private static int n;
        private static Student[] stud;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер массива");
                string read = Console.ReadLine();
                while (!Int32.TryParse(read, out n))
                {
                    Console.WriteLine("Введите целое число");
                    read = Console.ReadLine();
                }
                stud = new Student[n];
                FillStudent();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            SaveFale();

        }
        static private void FillStudent()
        {
            for (int i = 0; i <= n; i++)
            {
                stud[i] = new Student();
                Console.WriteLine($"Введите фамилию : ", i);
                stud[i].Familija = Console.ReadLine();
                Console.WriteLine($"Введите имя : ", i);
                stud[i].Name = Console.ReadLine();
                Console.WriteLine($"Введите группу : ", i);
                stud[i].Gruppa = Console.ReadLine();
            }

        }
        static public void SaveFale()
        {
            using (StreamWriter writer = new StreamWriter("File.txt"))
            {
                foreach (var s in stud)
                {
                    writer.WriteLine("Группа:" + s.Gruppa + " " + "Фамилия:" +  s.Familija + " " + "Имя:" + s.Name);
                }
            }
        }

    }
}