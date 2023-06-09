﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int hasil;

            // membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            // panggil method Penjumlah
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil penjumlah: " + hasil);

            // panggil method Penjumlah dg 3 parameter (overload method)
            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil penjumlah overload: " + hasil);

            // panggil method Pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            // panggil static method, langsung dari nama classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil perkalian: " + hasil);

            static void CetakHasil(string hasil)
            {
                Console.WriteLine(hasil);
            }

            Console.ReadKey();
            

        }
    }
}
