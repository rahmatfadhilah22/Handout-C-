public class Program
{
    internal static void Main(string[] args)
    {
        // Collection
        // Collection merupakan tipe data yang difungsikan untuk menampung sejumlah nilai atau
        // elemen didalamnya. Pada C# terdapat bermacam-macam jenis collection, namun kali ini
        // kita hanya akan berfokus pada Array, List, dan Dictionary.

        // Array
        // Array merupakan koleksi dari dari sekumpulan nilai/elemen yang bertipe yang sama
        // Saat array diinstance maka ukuran dari array tersbut tidak bisa dirubah lagi.

        int[] arrrayNumbers = new int[] { 1, 2, 3, 4, 5 };

        foreach (int number in arrrayNumbers)
        {
            Console.WriteLine(number);
        }

        // List<T>
        // List memiliki karakteristik yang mirip dengan Array, namun keunggulan dari list adalah
        // elemennya dapat ditambah

        List<int> listInstanceOne = new List<int>();
        listInstanceOne.Add(1);
        listInstanceOne.Add(2);

        List<int> listInstanceTwo = new List<int> { 3, 4, 5, 2, 1};
        listInstanceTwo.Add(3);



        // Dictionary<TKey, TValue>
        // Dictionary merupakan tipe data yang menampung sekumpulan elemen dalam bentuk Key, Value.

        Dictionary<int, string> dictionaryInstanceOne = new Dictionary<int, string>();
        dictionaryInstanceOne.Add(1, "Satu");

        Console.WriteLine(dictionaryInstanceOne[1]);
        Dictionary<int, string> dictionaryInstanceTwo = new Dictionary<int, string>()
        {
            { 1, "Satu"},
            { 2, "Dua"},
            { 3, "Tiga"},
            { 4, "Empat"},
        };

        foreach (var item in dictionaryInstanceTwo)
        {
            Console.WriteLine(item.Value);
        }

        Console.ReadKey();
    }
}