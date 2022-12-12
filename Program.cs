namespace TugasFundamental
{
    class Program
    {
        static string[] nim, nama;
        static double[] us1, us2, uas, totalNil;
        static char[] finalNil;
        static int n, pil;

        public static void Main(String[] args)
        {
            Console.WriteLine("Input dan Lihat Daftar Nilai Mahasiswa");
            Console.WriteLine("================================================================================================== ");
            do
            {
                Console.WriteLine("1. Input Data Daftar Nilai");
                Console.WriteLine("2. Lihat Data Daftar Nilai");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih Menu: ");
                pil = Convert.ToInt32(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                        IsiData();
                        Console.Clear();
                        break;
                    case 2:
                        LihatData();
                        break;
                    case 3:
                        Console.WriteLine("Terima Kasih!");
                        break;
                    default:
                        Console.WriteLine("Pilihan yang Anda Masukan Salah!");
                        break;
                }
            } while (pil != 3);
        }

        public static void IsiData()
        {
            Console.Clear();
            Console.Write("Masukan Banyak Data\t : ");
            n = Convert.ToInt32(Console.ReadLine());
            nim = new string[n];
            nama = new string[n];
            us1 = new double[n];
            us2 = new double[n];
            uas = new double[n];
            totalNil = new double[n];
            finalNil = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Masukan NIM\t\t\t : ");
                nim[i] = Console.ReadLine();
                
                if(n > 1)
                {
                    string[] input = { nim[i + 1] };
                    string already;
                    already = Array.Find(input, elemen => elemen == nim[i]);
                    if (already != null)
                    {
                        Console.WriteLine("NIM Sudah Ada. Mohon Input NIM yang Berbeda!");
                    }
                }                
                else
                {
                    Console.Write("Masukan Nama\t\t\t : ");
                    nama[i] = Console.ReadLine();
                    do
                    {
                        Console.Write("Masukan Nilai Ujian Sisipan 1\t : ");
                        us1[i] = Convert.ToDouble(Console.ReadLine());
                        if (us1[i] > 100)
                        {
                            Console.WriteLine("Mohon Input Nilai 0 - 100!");
                            Console.Clear();
                        }
                    } while (us1[i] > 100);

                    do
                    {
                        Console.Write("Masukan Nilai Ujian Sisipan 2\t : ");
                        us2[i] = Convert.ToDouble(Console.ReadLine());
                        if (us2[i] > 100)
                        {
                            Console.WriteLine("Mohon Input Nilai 0 - 100!");
                            Console.Clear();
                        }
                    } while (us2[i] > 100);

                    do
                    {
                        Console.Write("Masukan Nilai UAS\t\t : ");
                        uas[i] = Convert.ToDouble(Console.ReadLine());
                        if (us2[i] > 100)
                        {
                            Console.WriteLine("Mohon Input Nilai 0 - 100!");
                            Console.Clear();
                        }
                    } while (uas[i] > 100);

                    Console.WriteLine("========================================================");
                }
                
            }
        }

        public static void LihatData()
        {
            for (int i = 0; i < n; i++)
            {
                totalNil[i] = HitungTotalNil(us1[i], us2[i], uas[i]);
                finalNil[i] = (char)HitungFinalNil(totalNil[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Daftar Nilai Mahasiswa");
            Console.WriteLine("___________________________________________________________________________________");
            Console.WriteLine("No \t NIM \t\t Nama \t\t US 1 \t US 2 \t UAS \t Total \t Final");
            Console.WriteLine("___________________________________________________________________________________");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + " \t " + nim[i] + " \t " + nama[i] + " \t " + us1[i] + " \t " +
                    us2[i] + " \t " + uas[i] + " \t " + totalNil[i] + " \t " + finalNil[i] + " \t ");
            }
            Console.WriteLine("==================================================================================================");
        }

        public static double HitungTotalNil(double nil1, double nil2, double nil3)
        {
            double nilai_total;
            nilai_total = (0.3 * nil1) + (0.3 * nil2) + (0.4 * nil3);
            return nilai_total;
        }

        public static double HitungFinalNil(double nilai_total)
        {
            char nilai_final;
            if (nilai_total >= 80)
            {
                nilai_final = 'A';
            }
            else if (nilai_total >= 65)
            {
                nilai_final = 'B';
            }
            else if (nilai_total >= 55)
            {
                nilai_final = 'C';
            }
            else if (nilai_total >= 45)
            {
                nilai_final = 'D';
            }
            else
            {
                nilai_final = 'E';
            }
            return nilai_final;
        }
    }
}