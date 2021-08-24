using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace lingApp

{

    class Program

    {

        static void Main(string[] args)

        {



            string nama, password, input, noIdentitas;
            string username = "linggom";
            int varInt = Convert.ToDecimal(int ? username)(+17);
            Console.WriteLine($"{varInt}");


            Console.WriteLine("=====SELAMAT DATANG DI TOKO ELEKTRONIK  ");
            Console.WriteLine("Masukkan nama atau no identitas? (pilih salah satu)");
            input = Console.ReadLine();
            if (input == "Nama")
            {
                Console.WriteLine("Masukkan nama anda :");
                nama = Console.ReadLine();
                while (nama != "linggom")
                {
                    Console.WriteLine("Nama yang anda masukkan salah, silahkan coba lagi");
                    nama = Console.ReadLine();
                }
                Console.WriteLine("Silahkan masukkan password anda:");
                password = Console.ReadLine();
                while (password != "coba123")
                {
                    Console.WriteLine("Password yang anda inputkan salah, silahkan coba lagi");
                    password = Console.ReadLine();
                }
            }

            else if (input == "noIdentitas")
            {
                Console.WriteLine("Masukkan No Identitas anda :");
                noIdentitas = Console.ReadLine();
                while (noIdentitas != "201631055")
                {
                    Console.WriteLine("Data yang anda masukkan salah, silahkan cob alagi");
                    noIdentitas = Console.ReadLine();
                }

                Console.WriteLine("Silahkan masukkan password anda:");
                password = Console.ReadLine();
                while (password != "coba123")
                {
                    Console.WriteLine("Password yang anda inputkan salah, silahkan coba lagi");
                    password = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Input yang anda masukkan tidak benar");

            }
            
            Console.WriteLine("=========================================================");
            Console.WriteLine("Login berhasil");
            Console.WriteLine("==========================================================");

            
            Pembelian();
            LanjutBelanja();
        }

        static void LanjutBelanja ()
        {

            string jawab;
            Console.Write("Apakah Anda Masih Mau melakukan Pemesanan? [Y/T] = ");

            jawab = (Console.ReadLine());



            if (jawab == "y")

            {

                Console.Clear();

                Pembelian();

            }

            else if (jawab == "t")

            {

                Environment.Exit(0);

            }
        }
        static int Pembelian()
        {
            int x;

        //menu:

            Console.WriteLine("==================MENU===================");
            Console.WriteLine("1. TV");

            Console.WriteLine("2. laptop");

            Console.WriteLine("3. HP");

            Console.Write("Pilih [1/2/3] = ");

            x = int.Parse(System.Console.ReadLine());

            Console.WriteLine();



            if (x > 3)

            {

                Console.WriteLine("Maaf Pilihanmu tidak ada");

            }



            switch (x)

            {

                case 1:



                    int pilih;

                    Console.WriteLine("1. Panasonic");

                    Console.WriteLine("2. Sony LED");

                    Console.WriteLine("3. Polytron");

                    Console.Write("Pilihan [1/2/3] = ");

                    pilih = int.Parse(System.Console.ReadLine());

                    Console.WriteLine();



                    if (pilih > 3)

                    {

                        Console.WriteLine("Maaf Pilihanmu tidak ada");

                    }



                    if (pilih == 1)

                    {

                        int harga = 3500000, jumlahBeli, hargaBayar, diskon = 175000, hargaDiskon;

                        Console.Write("jumlahBeli  = ");

                        jumlahBeli = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayar = (jumlahBeli * harga);

                        hargaDiskon = (hargaBayar - diskon);

                        if (jumlahBeli >= 3)

                        {

                            Console.WriteLine("harga Panasonic Per 1 = " + harga);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskon);

                        }

                        else

                        {

                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayar);

                            Console.WriteLine("Tidak Dapat diskon");

                        }


                    }

                    else if (pilih == 2)

                    {

                        int harga = 3000000, jumlahBeli, hargaBayar, diskon = 150000, hargaDiskon;

                        Console.Write("jumlahBeli  = ");

                        jumlahBeli = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayar = (jumlahBeli * harga);

                        hargaDiskon = (hargaBayar - diskon);

                        if (jumlahBeli >= 3)

                        {

                            Console.WriteLine("harga Sony LED Per 1 = " + harga);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskon);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayar);

                            Console.WriteLine("Tidak Dapat diskon");

                        }




                    }



                    else if (pilih == 3)

                    {

                        int harga = 2500000, jumlahBeli, hargaBayar, diskon = 125000, hargaDiskon;

                        Console.Write("jumlahBeli  = ");

                        jumlahBeli = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayar = (jumlahBeli * harga);

                        hargaDiskon = (hargaBayar - diskon);

                        if (jumlahBeli >= 3)

                        {

                            Console.WriteLine("harga Polytron Per 1 = " + harga);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskon);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayar);

                            Console.WriteLine("Tidak Dapat diskon");

                        }


                    };
                    break;




                case 2:



                    int pilihan;

                    Console.WriteLine("1. Lenovo");

                    Console.WriteLine("2. Asus");

                    Console.WriteLine("3. Vivo");

                    Console.Write("Pilihan [1/2/3] = ");

                    pilihan = int.Parse(System.Console.ReadLine());

                    Console.WriteLine();



                    if (pilihan > 3)

                    {

                        Console.WriteLine("Maaf Pilihanmu tidak ada");

                    }



                    if (pilihan == 1)

                    {

                        int hargaLp = 4000000, jumlahBeliLp, hargaBayarLp, diskonLp = 200000, hargaDiskonLp;

                        Console.Write("jumlah_beli  = ");

                        jumlahBeliLp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayarLp = (jumlahBeliLp * hargaLp);

                        hargaDiskonLp = (hargaBayarLp - diskonLp);

                        if (jumlahBeliLp >= 3)

                        {

                            Console.WriteLine("harga Lenovo Per 1 = " + hargaLp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskonLp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayarLp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }


                    }

                    else if (pilihan == 2)

                    {

                        int hargaLp = 3500000, jumlahBeliLp, hargaBayarLp, diskonLp = 175000, hargaDiskonLp;

                        Console.Write("jumlah_beli  = ");

                        jumlahBeliLp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayarLp = (jumlahBeliLp * hargaLp);

                        hargaDiskonLp = (hargaBayarLp - diskonLp);

                        if (jumlahBeliLp >= 3)

                        {

                            Console.WriteLine("harga Asus Per 1 = " + hargaLp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskonLp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayarLp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }


                    }



                    else if (pilihan == 3)

                    {

                        int hargaLp = 3500000, jumlahBeliLp, hargaBayarLp, diskonLp = 175000, hargaDiskonLp;

                        Console.Write("jumlah_beli  = ");

                        jumlahBeliLp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        hargaBayarLp = (jumlahBeliLp * hargaLp);

                        hargaDiskonLp = (hargaBayarLp - diskonLp);

                        if (jumlahBeliLp >= 3)

                        {

                            Console.WriteLine("harga Vivo Per 1 = " + hargaLp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargaDiskonLp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + hargaBayarLp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }

                    }



                    break;



                case 3:



                    int pili;

                    Console.WriteLine("1. Asus");

                    Console.WriteLine("2. xiaomi");

                    Console.WriteLine("3. iphone");

                    Console.Write("Pilihan [1/2/3] = ");

                    pili = int.Parse(System.Console.ReadLine());

                    Console.WriteLine();



                    if (pili > 3)

                    {

                        Console.WriteLine("Maaf Pilihanmu tidak ada");

                    }



                    if (pili == 1)

                    {

                        int hargahp = 3500000, jumlah_belihp, harga_bayarhp, diskonhp = 175000, hargadiskonhp;

                        Console.Write("jumlah_beli  = ");

                        jumlah_belihp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        harga_bayarhp = (jumlah_belihp * hargahp);

                        hargadiskonhp = (harga_bayarhp - diskonhp);

                        if (jumlah_belihp >= 3)

                        {

                            Console.WriteLine("harga Asus Per 1 = " + hargahp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargadiskonhp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + harga_bayarhp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }


                    }

                    else if (pili == 2)

                    {

                        int hargahp = 3500000, jumlah_belihp, harga_bayarhp, diskonhp = 175000, hargadiskonhp;

                        Console.Write("jumlah_beli  = ");

                        jumlah_belihp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        harga_bayarhp = (jumlah_belihp * hargahp);

                        hargadiskonhp = (harga_bayarhp - diskonhp);

                        if (jumlah_belihp >= 3)

                        {

                            Console.WriteLine("harga Xiaomi Per 1 = " + hargahp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargadiskonhp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + harga_bayarhp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }

                    }



                    else if (pili == 3)

                    {

                        int hargahp = 3500000, jumlah_belihp, harga_bayarhp, diskonhp = 175000, hargadiskonhp;

                        Console.Write("jumlah_beli  = ");

                        jumlah_belihp = int.Parse(System.Console.ReadLine());

                        Console.WriteLine();



                        harga_bayarhp = (jumlah_belihp * hargahp);

                        hargadiskonhp = (harga_bayarhp - diskonhp);

                        if (jumlah_belihp >= 3)

                        {

                            Console.WriteLine("harga Iphone Per 1 = " + hargahp);

                            Console.WriteLine("harga yang harus anda bayar adalah = " + hargadiskonhp);

                        }

                        else

                        {



                            Console.Write("harga yang harus anda bayar adalah = " + harga_bayarhp);

                            Console.WriteLine("Tidak Dapat diskon");

                        }

                        break;

                    }

                    break;


            }
            return 0;
        }

    }

}
