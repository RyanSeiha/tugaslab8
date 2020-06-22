using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karywantetap = new KaryawanTetap();
            karywantetap.Nik = "444-555-666";
            karywantetap.Nama = "Rene Descartes";
            karywantetap.GajiBulanan = 5000000;

            KaryawanHarian karywanharian = new KaryawanHarian();
            karywanharian.Nik = "111-222-333";
            karywanharian.Nama = "Immanuel Kant";
            karywanharian.JumJamKerja = 10;
            karywanharian.UpahPerJam = 15000;

            Sales sales = new Sales();
            sales.Nik = "111-333-555";
            sales.Nama = "Socrates";
            sales.JumlahPenjualan = 40;
            sales.Upah = 55000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karywantetap);
            listKaryawan.Add(karywanharian);
            listKaryawan.Add(sales);

            int Urutan = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                    Urutan, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                Urutan++;
            }
            Console.ReadKey();
        }
    }
}
