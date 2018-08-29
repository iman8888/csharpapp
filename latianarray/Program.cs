using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latianarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] siswa = new string[5][];


            for (int i = 0; i < 5; i++)
            {
                siswa[i] = new string[3];
                Console.WriteLine("input data siswa ke " + (i + i));
                Console.Write("Nim    : ");
                siswa[i][0] = Console.ReadLine();
                Console.Write("nama  : ");
                siswa[i][1] = Console.ReadLine();
                Console.Write("Kelas : ");
                siswa[i][2] = Console.ReadLine();

           }

            List<string[]> siswa = new List<string>[3];

            string jawaban;
            do
            {
                string[] dt = new string[3];
                Console.WriteLine("input Data Siswa ke " + (siswa.Count + 1) );
                Console.Write("Nim   : ");
                dt[0] = Console.ReadLine();
                Console.Write("Nama  : ");
                dt[1] = Console.ReadLine();
                Console.Write("kelas : ");
                dt[2] =Console.ReadLine();
                siswa.Add(dt);


                Console.Write("Apakah mau input lagi  ? [Y/N]  ");
                jawaban =Console.ReadLine();
            }while (jawaban.ToUpper() == "Y");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hasil Input Data Siswa ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| {0.-3} | {1,-15} | {2,-5} |","NIM","NAMA","KELAS");
            Console.WriteLine("---------------------------------------------");
            for (int i =0; i < siswa.Count ;i++)
            {
                string teks = string.Format("| {0.-3} | {1,-15} | {2,-5} |", siswa[i][0], siswa[i][1], siswa[i][2]);
                Console.WriteLine(teks);

            }
            Console.WriteLine("-------------------------------------------");


            Console.ReadKey();
                 
            
           }



        }
    }
}
