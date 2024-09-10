using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertemuanSatu
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Komentar
            // Dalam C#, komentar digunakan untuk memberikan penjelasan atau catatan tentang kode. 
            // Komentar tidak akan diproses oleh compiler, jadi kode di dalam komentar tidak akan 
            // dieksekusi.
            // Ada dua jenis komentar dalam C#:
            // 1. Komentar satu baris:  Menggunakan dua garis miring (//).
            //    Semua teks setelah // pada baris yang sama akan dianggap sebagai komentar.
            // 2. Komentar multi-baris: Menggunakan (/**/).
            //   Semua teks yang berada di antara /*  */ akan dianggap sebagai komentar,
            //   termasuk jika teks tersebut melintasi beberapa baris.


            /* Variabel dan tipe data
             * variabel merupakan sebuah tempat penyimpanan di memori yang digunakan menyimpan suatu
             * nilai. Pada C# sendiri sangat banyak tipe data, diataranya ada string untuk menyimpan
             * karakter bebas, int menyimpan angka, decimal untuk menyimpan angka desimal, char
             * untuk menyimpan satu huruf tunggal, bool untuk menyimpan nilai true/false.
             */

            // Untuk membuat sebuah variabel terdapat dua buah cara yang umum yaitu membuat variabel
            // sekaligus memberinya nilai, atau hanya membuatnya dan memberikan nilainya ketika
            // diperlukan, dan untuk variabel menggunakan style camelCase
            // Contoh membuat variabel sekaligus memberinya nilai

            string namaSaya = "John Doe";
            Console.WriteLine(namaSaya);

            // Contoh mmebuat variabel dan memberinya nilai saat diperlukan

            string namaKamu;
            namaKamu = "Jane Doe";
            Console.WriteLine(namaKamu);

            // Nilai yang diberikan pada suatu variabel dapat dirubah
            namaKamu = "Dany Tan";
            Console.WriteLine(namaKamu);

            // Adakalanya suatu variabel tidak boleh berubah, maka kita perlu menambahkan const
            const decimal pi = 3.14M;
            // pi = 3;, jika kita membuka komentar ini maka akan muncul sebuah sintaks error, karena
            // nilai dari variabel pi bersifat konstan

            // Konversi, konversi adalah sebuah proses untuk merubah tipe data untuk keperluan tertentu
            // proses ini cukup sering digunakan, sintaks yang paling umum yang sering digunakan adalah
            // Parse, dan Convert

            string angkaSatu = "4";
            int angkaSatuParse = int.Parse(angkaSatu);
            Console.WriteLine(angkaSatuParse);

            int angkaDua = 2;
            decimal angkaDuaConvert = Convert.ToDecimal(angkaDua);
            Console.WriteLine(angkaDuaConvert);

            Console.WriteLine("Masukan panjang");
            int panjang = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Lebar");
            int lebar = int.Parse(Console.ReadLine());

            int luas = panjang * lebar;
            Console.WriteLine("Selamat anda berhasil hack NASA");



            Console.ReadKey();
        }
    }
}
