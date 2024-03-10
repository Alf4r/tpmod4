// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosDictionary;

    public KodePos()
    {
        kodePosDictionary = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"A. Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (kodePosDictionary.ContainsKey(kelurahan))
        {
            return kodePosDictionary[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        // Output dalam bentuk tabel
        Console.WriteLine("{0,-15} {1,-10}", "Kelurahan", "Kode Pos");
        Console.WriteLine("----------------------------------");

        Console.WriteLine("{0,-15} {1,-10}", "Batununggal", kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("{0,-15} {1,-10}", "A. Kujangsari", kodePos.GetKodePos("A. Kujangsari"));
        Console.WriteLine("{0,-15} {1,-10}", "Mengger", kodePos.GetKodePos("Mengger"));
        Console.WriteLine("{0,-15} {1,-10}", "Wates", kodePos.GetKodePos("Wates"));
        Console.WriteLine("{0,-15} {1,-10}", "Cijaura", kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("{0,-15} {1,-10}", "Jatisari", kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("{0,-15} {1,-10}", "Margasari", kodePos.GetKodePos("Margasari"));
        Console.WriteLine("{0,-15} {1,-10}", "Sekejati", kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("{0,-15} {1,-10}", "Kebonwaru", kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("{0,-15} {1,-10}", "Maleer", kodePos.GetKodePos("Maleer"));
        Console.WriteLine("{0,-15} {1,-10}", "Samoja", kodePos.GetKodePos("Samoja"));
    }
}

