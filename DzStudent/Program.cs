using System;
using System.IO;
namespace ConsoleApplication9
{

    public struct Spisok
    {
        
        public int ball;
        public string name;
        public int doxod;
        public int gruppa;

   
        public override string ToString()
        {
            return (string.Format("Имя студента {0}; ball{1}; Группа № {2};Размер дохода на одного члена семьи: {3}", name, ball, gruppa, doxod));
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество нуждающихся в общежитии:");
            int n = Convert.ToInt32(Console.ReadLine());
            Spisok[] nz = new Spisok[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0} Нуждаюшиийся:", i + 1);
                Console.WriteLine("Имя:");
                nz[i].name = Console.ReadLine();
                Console.WriteLine("Номер группы:");
                nz[i].gruppa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Доход:");
                Console.WriteLine("Средний балл:");
                nz[i].ball = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Доход:");
                nz[i].doxod = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("");
            Console.WriteLine("Введите количество мест в общежитии:");
            int m = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int mrot = 8660;

            for (int i = 0; i < n; i++)
            {
                if (nz[i].doxod <= mrot)
                    Console.WriteLine("{0} - Выдана комната!", nz[i]);

                if (nz[i].doxod > mrot) ;




                        }
        }
    } 
}