using System;

public class DayNameResolver
{
    // Ini adalah "tabel" kita.
    // Index 0 tidak digunakan untuk menyelaraskan dengan nomor hari (1-7).
    private static readonly string[] dayNames = new string[]
    {
        "",         // Index 0: Placeholder
        "Minggu",   // Index 1
        "Senin",    // Index 2
        "Selasa",   // Index 3
        "Rabu",     // Index 4
        "Kamis",    // Index 5
        "Jumat",    // Index 6
        "Sabtu"     // Index 7
    };

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Pencari Nama Hari Berdasarkan Nomor (Table-Driven) ---");

        // Contoh penggunaan langsung
        Console.WriteLine($"Hari ke-3 adalah: {GetDayName(3)}");
        Console.WriteLine($"Hari ke-7 adalah: {GetDayName(7)}");
        Console.WriteLine($"Hari ke-1 adalah: {GetDayName(1)}");

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Masukkan nomor hari (1-7):");
        string? input = Console.ReadLine(); // Membaca input dari user

        if (int.TryParse(input, out int dayNumber)) // Mencoba mengkonversi input ke integer
        {
            string name = GetDayName(dayNumber);
            if (!string.IsNullOrEmpty(name)) // Memeriksa apakah nama hari ditemukan
            {
                Console.WriteLine($"Hari ke-{dayNumber} adalah: {name}");
            }
            else
            {
                Console.WriteLine("Nomor hari tidak valid. Harap masukkan angka antara 1 dan 7.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka.");
        }
    }

    /// <summary>
    /// Mengambil nama hari berdasarkan nomor hari menggunakan table-driven method.
    /// </summary>
    /// <param name="dayNumber">Nomor hari (1-7).</param>
    /// <returns>Nama hari atau string kosong jika nomor tidak valid.</returns>
    public static string GetDayName(int dayNumber)
    {
        // Memeriksa apakah nomor hari berada dalam batas valid tabel.
        if (dayNumber >= 1 && dayNumber < dayNames.Length)
        {
            // Mengakses elemen array secara langsung berdasarkan nomor hari.
            // Ini adalah inti dari table-driven method.
            return dayNames[dayNumber];
        }
        else
        {
            return ""; // Mengembalikan string kosong untuk nomor yang tidak valid
        }
    }
}