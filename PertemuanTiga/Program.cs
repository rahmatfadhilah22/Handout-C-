public class Program
{ 
    static void Main(string[] args)
    {
        // Loop atau perulangan

        // Pada C# terdapat cara untuk melakukan iterasi atau perulangan, namun terdapat tiga cara
        // yang paling sering digunakan yaitu, While, For, dan Foreach. pada perulangan terdapat indeks
        // dimana indeks tersebut dimulai dari 0.

        // While
        int nilaiAwal = 0;

        while (nilaiAwal < 5)
        {
            Console.WriteLine("Ini perulangan while ke "+nilaiAwal);
            nilaiAwal++;
        }

        // For
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ini perulangan for ke " + i);
        }

        // Foreach

        string[] buahBuahan = { "Semangka", "Durian", "Rambutan" };

        foreach (var buah in buahBuahan)
        {
            Console.WriteLine("Buah" + buah);
        }

        Console.ReadKey();
    }
}