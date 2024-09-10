namespace PertemuanEnam
{


    public class Program
    {
        static void Main(string[] args)
        {
            // Object Oriented Programming (OOP)
            // OOP merupakan sebuah paradigma pemrograman yang berorientasi pada objek yang bertujuan agar
            // proses pengembagan dapat dilakukan dengan lebih mudah.

            // Pada OOP terdapat empat pilar yang sebaiknua dipahami dengan baik yaitu inheritance,
            // polymorphisme, encapsulasi, dan abstraksi.

            // Inhertence
            // Inheritance atau pewarisan adalah sebuah kondisi dimana sebuah class baru dapat mewarisi
            // properti dan juga method pada class yang diinheritnya. contoh sederhananya adalah guru, dan
            // dan guru bahasa Indonesia, guru memiliki properti NIP maka guru bahasa indonesia memiliki
            // properti yang sama tanpa menulisn ulang.

            Guru guru = new Guru();
            guru.NIP = "123456789";


            Console.WriteLine("NIP :" + guru.NIP);

            GuruBahasaIndonesia guruBahasaIndonesia = new GuruBahasaIndonesia();
            guruBahasaIndonesia.NIP = "987654321";
            guruBahasaIndonesia.Nama = "Johnd Doe";

            Console.WriteLine("NIP :" + guruBahasaIndonesia.NIP + " Nama :" + guruBahasaIndonesia.Nama);

            // Polymorfisme
            // Polymorfisme secara bahasa adalah banyak bentuk, dimana object yang diinstance dapat
            // berprilaku tidak sama dengan class yang diwarisinya.

            guru.Mengajar();
            guruBahasaIndonesia.Mengajar();

            // Encapsulasi 
            // Encapsulasi adalah sebuah proses pembungkusan suatu properti ataupun method untu keperluan
            // tertentu, misal kita memiliki method yang hanya ingin method tersebut diakses oleh class itu
            // sendiri atau class turunannya saja. Ada tiga majam encapsulasi yang paling sering digunakan
            // yaitu public, private, dan protected.

            //guru.Menyapa(); // Jika kita menggunakan method ini maka akan terjadi error, karena method
            // tersebut dipakai dibukan class nya

            // Abstraction
            // Abstraksi adalah sebuah proses penyederhanaan dari implementasi yang bertujuan untuk menyembunyikan
            // kreumitan. sebagai contoh pada HP kita ada tombol kamrea, kita hanya melihat tombol kamera tersebut
            // padahal saat kita klik kamera tersebut ada sekumpulan perintah yang dieksekusi agar fitur kamera
            // dapat digunakan dengan baik.

            Redmi redmi = new Redmi();

            redmi.Kamera();

            Console.ReadKey();
        }
    }
}