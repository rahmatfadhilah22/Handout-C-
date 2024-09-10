public class Program
{
    public static void Main(string[] args)
    {
        // Function/Method
        // Function ataupun method memiliki fungsi yang sama yaitu melakukan eksekusi sekumpulan
        // perintah yang ada pada blok code tertentu, namun yang membedakannya adalah method adalah
        // sebuah function yang didefinisikan pada suatu class terntentu.

        // Method umumnya memiliki empat anatomi yaitu access modifier, tipe return, nama method,
        // dan parameter


        // Contoh method tanpa parameter

        void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        PrintHelloWorld();

        // Contoh method dengan parameter
        Console.WriteLine("Masukkan nama anda");
        string name = Console.ReadLine();

        void HelloWorld(string name) 
        {
            Console.WriteLine("Hallo " + name);
        }

        HelloWorld(name);

        // Contoh method dengan tipe return

        public int MenghitungLuasan(int panjang, int lebar)
        {
            int luas = panjang * lebar;
            return luas;
        }

        Console.Write("Masukkan panjang ");
        int panjang = int.Parse(Console.ReadLine());
        Console.Write("Masukkan lebar ");
        int lebar = int.Parse(Console.ReadLine());

        Console.WriteLine("Luas adalah = " +  MenghitungLuasan(panjang, lebar));

        Console.ReadKey();
    }
}