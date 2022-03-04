using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nilai_UN
{
    class input
    {
        public double mtk, bi, fisika, bio, kimia;
        public string nama;

        /// <summary>
        /// public class masukan nilai di buat public karna biar bisa di akses kelas lain, disini dibuat untuk memasukan nilai
        /// kelas ini digunakan untuk input data user
        /// </summary>
        public void masukannilai()
        {
            Console.Write("Masukan Nama Siswa= ");
            nama = (Console.ReadLine());
            Console.Write("Masukan nilai Matematika= ");
            mtk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan nilai Bahasa Indonesia= ");
            bi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan nilai Fisika= ");
            fisika = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan nilai Biologi= ");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan nilai Kimia= ");
            kimia = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// untuk menghitung nilai rata-rata
        /// </summary>
        /// <param name="mtk">digunakan untuk menyimpan nilai matematika</param>
        /// <param name="bi">digunakan untuk menyimpan nilai bahasa indonesia</param>
        /// <param name="fisika">digunakan untuk menyimpan nilai fisika</param>
        /// <param name="bio">digunakan untuk menyimpan nilai biologi</param>
        /// <param name="kimia"> digunakan untuk menyimpan nilai kimia</param>
        /// <returns></returns>
        public double rata(double mtk, double bi, double fisika, double bio, double kimia)
        {
            return (mtk + bi + fisika + bio + kimia) / 5;
        }

        /// <summary>
        /// method ini digunakan untuk menghitung rata2 nilai syarat kelulusan 
        /// </summary>
        /// <returns></returns>
        public string syarat()
        {
            string status;
            if (rata(mtk, bi, fisika, bio, kimia) >= 70 && mtk >=70 && bi >= 80 && fisika >=65 && bio >=70 && kimia >=65)
            {
                status = "LULUS";
            }
            else
            {
                status = "TIDAK LULUS";
            }
            return status;
        }

        /// <summary>
        /// untuk menampilkan data predikat nilai nantinya
        /// </summary>
        /// <returns></returns>
        public string predikat()
        {
            string status2;
            if (rata(mtk, bi, fisika, bio, kimia) >= 90)
            {
                status2 = "A";
            }
            else if(rata(mtk, bi, fisika, bio, kimia) >= 85 && rata(mtk, bi, fisika, bio, kimia) < 90)
            {
                status2 = "AB";
            }
            else if (rata(mtk, bi, fisika, bio, kimia) >= 80 && rata(mtk, bi, fisika, bio, kimia) < 85)
            {
                status2 = "B";
            }
            else if (rata(mtk, bi, fisika, bio, kimia) >= 75 && rata(mtk, bi, fisika, bio, kimia) < 80)
            {
                status2 = "BC";
            }
            else if (rata(mtk, bi, fisika, bio, kimia) >= 70 && rata(mtk, bi, fisika, bio, kimia) < 75)
            {
                status2 = "C";
            }
            else if (rata(mtk, bi, fisika, bio, kimia) >= 65 && rata(mtk, bi, fisika, bio, kimia) < 70)
            {
                status2 = "D";
            }
            else if (rata(mtk, bi, fisika, bio, kimia) >= 60 && rata(mtk, bi, fisika, bio, kimia) < 65)
            {
                status2 = "E";
            }
            else 
            {
                status2 = "F";
            }
            return status2;
        }

        /// <summary>
        /// digunakan untuk memanggil method yang sudah dibuat sebelumnya
        /// </summary>
        public void tampil()
        {
            Console.WriteLine("\n\nNama : {0} \n Nilai Matematika : {1} \n NIlai Bahasa Indonesia : {2} \n Nilai Fisika : {3} \n Nilai Biologi {4} \n Nilai Kimia : {5} \n Nilai Rata-rata : {6} \n Anda dinyatakan : {7} \n Predikat Anda : {8}", nama, mtk, bi, fisika, bio, kimia, rata(mtk,bi,fisika,bio,kimia),syarat(),predikat());
            Console.ReadKey();
        }
    }

    /// <summary>
    /// bagian ini berguna untuk menampilkan hasil dari nilai dan predikat yang sudah di hitung 
    /// </summary>
    class Hasil
    {
        static void Main(string[] args)
        {
            input inp = new input();
            inp.masukannilai();
            inp.syarat();
            inp.predikat();
            inp.tampil();

        }
    }
}
