using System.Text;

public class Mahasiswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // =========================================================================
        // Pertemuan 6 — String Manipulation, Error Handling, Null Handling & LINQ
        // =========================================================================


        // =========================================================================
        // 1. STRING MANIPULATION
        // =========================================================================
        // String di C# adalah tipe data yang sangat sering digunakan. Terdapat banyak
        // method bawaan untuk memanipulasi string.

        // --- String Concatenation (Penggabungan) ---
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Concatenation: " + fullName);

        // --- String Interpolation ---
        // Lebih modern dan mudah dibaca menggunakan tanda $ di depan string
        string fullNameInterpolated = $"{firstName} {lastName}";
        Console.WriteLine("Interpolation: " + fullNameInterpolated);

        // --- Method umum pada String ---
        string kalimat = "  Hello, World!  ";

        Console.WriteLine("ToUpper       : " + kalimat.ToUpper());
        Console.WriteLine("ToLower       : " + kalimat.ToLower());
        Console.WriteLine("Trim          : " + kalimat.Trim());
        Console.WriteLine("Contains      : " + kalimat.Contains("World"));
        Console.WriteLine("Replace       : " + kalimat.Replace("World", "C#"));
        Console.WriteLine("Substring(2,5): " + kalimat.Trim().Substring(2, 5));
        Console.WriteLine("Length         : " + kalimat.Trim().Length);
        Console.WriteLine("StartsWith    : " + kalimat.Trim().StartsWith("Hello"));
        Console.WriteLine("EndsWith      : " + kalimat.Trim().EndsWith("!"));

        // --- Split dan Join ---
        string dataBuah = "Semangka,Durian,Rambutan,Mangga";
        string[] buahArray = dataBuah.Split(",");

        Console.WriteLine("\nHasil Split:");
        foreach (var buah in buahArray)
        {
            Console.WriteLine("  - " + buah.Trim());
        }

        // Join: menggabungkan array menjadi string
        string buahGabung = string.Join(" | ", buahArray);
        Console.WriteLine("Hasil Join: " + buahGabung);

        // --- StringBuilder ---
        // Untuk manipulasi string dalam jumlah besar, StringBuilder lebih efisien
        // karena string di C# bersifat immutable (tidak bisa diubah, selalu buat baru)
        StringBuilder sb = new StringBuilder();
        sb.Append("Halo");
        sb.Append(", ");
        sb.Append("dunia");
        sb.Append("!");
        Console.WriteLine("StringBuilder : " + sb.ToString());

        // --- Null atau Empty ---
        // Cara mengecek string kosong atau null
        string namaKosong = "";
        string namaNull = null;

        Console.WriteLine("IsNullOrEmpty kosong : " + string.IsNullOrEmpty(namaKosong));
        Console.WriteLine("IsNullOrEmpty null   : " + string.IsNullOrEmpty(namaNull));

        // =========================================================================
        // 2. ERROR HANDLING (try-catch-finally)
        // =========================================================================
        // Saat program berjalan, terkadang terjadi error yang tidak terduga.
        // Error handling digunakan untuk menangani error tersebut agar program
        // tidak crash secara tiba-tiba.

        // --- try-catch dasar ---
        try
        {
            Console.Write("\nMasukkan sebuah angka: ");
            string inputUser = Console.ReadLine();
            int angka = int.Parse(inputUser);
            Console.WriteLine("Angka yang dimasukkan: " + angka);
        }
        catch (FormatException)
        {
            // Error ini terjadi jika input bukan angka
            Console.WriteLine("Error: Input bukan angka yang valid!");
        }

        // --- try-catch dengan Exception umum ---
        try
        {
            int[] angkaArray = { 1, 2, 3 };
            Console.WriteLine(angkaArray[10]); // Index di luar batas
        }
        catch (IndexOutOfRangeException ex)
        {
            // ex berisi informasi tentang error yang terjadi
            Console.WriteLine("Error: " + ex.Message);
        }

        // --- Multiple catch ---
        // Kita bisa menangkap berbagai jenis error secara terpisah
        try
        {
            int pembilang = 10;
            int penyebut = 0;
            int hasil = pembilang / penyebut;
            Console.WriteLine("Hasil: " + hasil);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Tidak bisa membagi dengan nol!");
        }
        catch (Exception ex)
        {
            // Catch umum di paling akhir, menangkap semua jenis error
            Console.WriteLine("Error tidak terduga: " + ex.Message);
        }

        // --- finally ---
        // Blok finally akan SELALU dijalankan, baik ada error maupun tidak.
        // Biasa digunakan untuk cleanup seperti menutup koneksi database.
        try
        {
            Console.WriteLine("\nMencoba sesuatu...");
            int hasil = 10 / 2;
            Console.WriteLine("Hasil: " + hasil);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Blok finally dijalankan (selalu dieksekusi)");
        }


        // =========================================================================
        // 3. NULL HANDLING
        // =========================================================================
        // Null berarti "tidak ada nilai". Di C#, null handling sangat penting
        // karena mengakses null bisa menyebabkan NullReferenceException.

        // --- Nullable Types ---
        // Tipe data biasa (int, bool, dll) tidak bisa menyimpan null.
        // Untuk membuatnya bisa menyimpan null, tambahkan tanda ?
        int? umurNullable = null;
        bool? isActiveNullable = null;

        if (umurNullable == null)
        {
            Console.WriteLine("\numurNullable bernilai null");
        }

        // Nullable punya property .HasValue dan .Value
        umurNullable = 25;
        if (umurNullable.HasValue)
        {
            Console.WriteLine("Umur sekarang: " + umurNullable.Value);
        }

        // --- Null Coalescing Operator (??) ---
        // Memberikan nilai default jika null
        string namaLengkap = null;
        string namaTampil = namaLengkap ?? "Anonymous";
        Console.WriteLine("Nama tampil: " + namaTampil);

        int? nilaiInput = null;
        int nilaiFinal = nilaiInput ?? 0;
        Console.WriteLine("Nilai final: " + nilaiFinal);

        // --- Null Conditional Operator (?.) ---
        // Memanggil property/method hanya jika objek tidak null.
        // Jika null, hasilnya adalah null (bukan error).
        string teks = null;
        int? panjangTeks = teks?.Length; // Tidak error, hasilnya null
        Console.WriteLine("Panjang teks (null safe): " + (panjangTeks?.ToString() ?? "null"));

        teks = "Hello C#";
        panjangTeks = teks?.Length;
        Console.WriteLine("Panjang teks: " + panjangTeks);


        // =========================================================================
        // 4. LINQ DASAR (Language Integrated Query)
        // =========================================================================
        // LINQ adalah cara untuk query/manipulasi data dari collection.
        // Sangat powerful dan sering digunakan di project .NET.

        List<int> angkaList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // --- Where (Filter) ---
        // Mengambil elemen yang memenuhi kondisi
        var angkaGenap = angkaList.Where(x => x % 2 == 0);
        Console.WriteLine("\nAngka genap (Where):");
        foreach (var angka in angkaGenap)
        {
            Console.Write(angka + " ");
        }
        Console.WriteLine();

        // --- Select (Transformasi) ---
        // Mengubah setiap elemen menjadi bentuk lain
        var angkaKaliDua = angkaList.Select(x => x * 2);
        Console.WriteLine("Angka x2 (Select):");
        foreach (var angka in angkaKaliDua)
        {
            Console.Write(angka + " ");
        }
        Console.WriteLine();

        // --- Any (Cek apakah ada elemen yang cocok) ---
        bool adaLebihDariLima = angkaList.Any(x => x > 5);
        Console.WriteLine("Ada angka > 5? (Any): " + adaLebihDariLima);

        // --- All (Cek apakah semua elemen cocok) ---
        bool semuaPositif = angkaList.All(x => x > 0);
        Console.WriteLine("Semua positif? (All): " + semuaPositif);

        // --- First / FirstOrDefault ---
        // Mengambil elemen pertama yang cocok
        int pertamaGenap = angkaList.First(x => x % 2 == 0);
        Console.WriteLine("Genap pertama (First): " + pertamaGenap);

        // FirstOrDefault mengembalikan default value (0 untuk int) jika tidak ditemukan
        int lebihDariSeratus = angkaList.FirstOrDefault(x => x > 100);
        Console.WriteLine("Lebih dari 100 (FirstOrDefault): " + lebihDariSeratus);

        // --- Count ---
        int jumlahGenap = angkaList.Count(x => x % 2 == 0);
        Console.WriteLine("Jumlah genap (Count): " + jumlahGenap);

        // --- OrderBy / OrderByDescending ---
        var angkaUrut = angkaList.OrderByDescending(x => x);
        Console.WriteLine("Urut descending (OrderByDescending):");
        foreach (var angka in angkaUrut)
        {
            Console.Write(angka + " ");
        }
        Console.WriteLine();

        // --- Sum, Min, Max, Average ---
        Console.WriteLine("Sum     : " + angkaList.Sum());
        Console.WriteLine("Min     : " + angkaList.Min());
        Console.WriteLine("Max     : " + angkaList.Max());
        Console.WriteLine("Average : " + angkaList.Average());

        // --- LINQ dengan Collection of Object ---
        Console.WriteLine("\n--- LINQ dengan List of Object ---");

        List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Andi", Nilai = 85 },
            new Mahasiswa { Nama = "Budi", Nilai = 72 },
            new Mahasiswa { Nama = "Citra", Nilai = 91 },
            new Mahasiswa { Nama = "Dina", Nilai = 65 },
            new Mahasiswa { Nama = "Eka", Nilai = 78 },
        };

        // Filter mahasiswa dengan nilai > 75
        var lulus = mahasiswas.Where(m => m.Nilai > 75);
        Console.WriteLine("Mahasiswa lulus (nilai > 75):");
        foreach (var m in lulus)
        {
            Console.WriteLine($"  {m.Nama}: {m.Nilai}");
        }

        // Ambil hanya nama-nama saja
        var namaMahasiswa = mahasiswas.Select(m => m.Nama);
        Console.WriteLine("Semua nama: " + string.Join(", ", namaMahasiswa));

        // Rata-rata nilai
        double rataRata = mahasiswas.Average(m => m.Nilai);
        Console.WriteLine("Rata-rata nilai: " + rataRata);

        // Mahasiswa dengan nilai tertinggi
        var terbaik = mahasiswas.OrderByDescending(m => m.Nilai).First();
        Console.WriteLine($"Terbaik: {terbaik.Nama} ({terbaik.Nilai})");

        // Cek apakah ada yang nilai < 60
        bool adaRemidi = mahasiswas.Any(m => m.Nilai < 60);
        Console.WriteLine("Ada yang remidi? " + adaRemidi);


        Console.ReadKey();
    }
}
