using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertemuanDua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmatika

            //Pada C# terdapat aritmatika sederhana yang dapat dilakukan seperti tambah, kurang,
            //kali, bagi dll

            //Contoh 
            Console.WriteLine(5 + 5);
            Console.WriteLine(10 - 5);
            Console.WriteLine(2 * 2);
            Console.WriteLine(2 / 2);
            Console.WriteLine(10 % 4);


            // Operator Perbandingan

            // Pada C# terdapat operator perbandingan yang digunakan untuk membandingkan dua nilai atau lebih.
            // operator perbandingan yang paling umu digunakan adalah == (sama dengan),
            // != (tidak sama dengan), > (lebih besar dari), < (lebih kecil dari), >= (lebih besar sama dengan),
            // dan <= (lebih kecil sama dengan)

            // Contoh 

            if (3 > 2)
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }

            // Operator Logika

            // Pada C# terdapat dua operator logika yang paling sering digunakan yaitu || (atau), dan && (dan).
            // Jika menggunakan || akan menghasilkan true jika salah satu kondisi terpenuhi, sebaliknya jika
            // menggunakan && hanya akan menghasilkan true jika semua kondisi terpenuhi

            // Contoh

            // Blok code ini akan mencetak benar, karena salah satu kondisinya ada yang bernilai benar
            if (5 > 4 || 2 > 3)
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }

            // Blok code ini akan mencetak Salah karena tidak semua kondisi terpenuhi
            if (5 > 4 && 2 > 3)
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }

            // Switch
            // Pada C# terdapat sebuah statment switch yang umum digunakan jika banyak kondisi yang ingin
            // diperika, namun ingin membuatnya lebih terlihat rapi atau mudah dibaca

            string pilihanUser = "1";

            switch (pilihanUser)
            {
                case "1":
                    Console.WriteLine("User pilih 1");
                    break;
                case "2":
                    Console.WriteLine("User pilih 2");
                    break;
                case "3":
                    Console.WriteLine("User pilih 3");
                    break;
                 
            };

            string pilihanUserAdalah = pilihanUser switch
            {
                "1" => "User Pilih 1",
                "2" => "User Pilih 2",
                "3" => "User Pilih 3",
                _ => "Pilihan tidak dikenal"
            };


            Console.WriteLine(pilihanUserAdalah);

            Console.ReadKey();
        }
    }
}
