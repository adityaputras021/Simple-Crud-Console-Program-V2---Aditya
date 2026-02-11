using CLI_Project_V2_Aditya.CLI_Project.Models;
using CLI_Project_V2_Aditya.CLI_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Project_V2_Aditya.CLI_Project.Services
{
    internal class Service
    {
        public static void pilihan(string message)
        {
            switch (message)
            {
                case "/help" or "help":
                    Utility.InfoCommand("====================================");
                    Utility.InfoCommand("1. daftar tugas");
                    Utility.InfoCommand("2. tambah tugas");
                    Utility.InfoCommand("3. update tugas");
                    Utility.InfoCommand("4. hapus tugas");
                    Utility.InfoCommand("5. tugas yang sudah selesai");
                    Utility.InfoCommand("6. tugas yang belum selesai");
                    Utility.InfoCommand("7. tugas yang sedang berlangsung");
                    Utility.InfoCommand("8. keluar");
                    Utility.InfoCommand("====================================");
                    Utility.AlertCommand("jawab dengan angka");

                    Utility.MainCommand();
                    break;

                case "":
                    Utility.MainCommand();
                    break;

                case "1":
                    FileService.ReadData();
                    break;

                case "2":
                   

                    Utility.InputCommand("masukan nama tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string nama = Console.ReadLine().ToLower().Trim();

                    Utility.InputCommand("masukan deskripsi tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string deks = Console.ReadLine().ToLower().Trim();

                    Utility.InputCommand("masukan status tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string status = Console.ReadLine().ToLower().Trim();

                    data tambah = new data
                    {
                        Name = nama,
                        Description = deks,
                        Status = status,
                        CreateAt = DateTime.Now,
                        UpdateAt = DateTime.Now,
                    };
                    FileService.AddData(tambah);
                    break;

                case "3":
                    Utility.InputCommand("masukan id tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int id = Convert.ToInt32(Console.ReadLine().ToLower().Trim());

                    Utility.InputCommand("masukan nama tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string namaup = Console.ReadLine().ToLower().Trim();

                    Utility.InputCommand("masukan deskripsi tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string deksup = Console.ReadLine().ToLower().Trim();

                    Utility.InputCommand("masukan status tugas: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string statusup = Console.ReadLine().ToLower().Trim();

                    data update = new data
                    {
                        Name = namaup,
                        Description = deksup,
                        Status = statusup,
                        UpdateAt = DateTime.Now,
                    };
                    FileService.UpdateData(id, update);
                    break;

                case "4":
                    Utility.InputCommand("masukkan id tugas: ");
                    int idhapus = Convert.ToInt32(Console.ReadLine().ToLower().Trim());
                    FileService.DeleteData(idhapus);
                    break;

                case "5":
                    FileService.DoneData();
                    break;

                case "6":
                    FileService.NotDoneData();
                    break;

                case "7":
                    FileService.ProgressData();
                    break;

                case "8":
                    return;
                    break;
            }
        }
    }
}
