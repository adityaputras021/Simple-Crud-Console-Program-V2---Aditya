using CLI_Project_V2_Aditya.CLI_Project.Models;
using CLI_Project_V2_Aditya.CLI_Project.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CLI_Project_V2_Aditya.CLI_Project.Services
{
    internal class FileService
    {
        private static string FilePath = "ListData.json";
        public static int GetID()
        {
            List<data> listdata = GetData();
            if (listdata == null || listdata.Count == 0)
                return 1;

            return (int)listdata.Max(l => l.ID) + 1;
        }
        public static List<data> GetData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string jsonData = File.ReadAllText(FilePath);

                    if(string.IsNullOrEmpty(jsonData))
                    {
                        return new List<data>();
                    }

                    return JsonSerializer.Deserialize<List<data>>(jsonData) ?? new List<data>();
                }
                return new List<data>();

            }catch
            {
                File.WriteAllText(FilePath, "[]");
                return new List<data>();
            }
        }


        public static bool AddData(data tambah)
        {
            try
            {
                List<data> data = GetData();
                tambah.ID = GetID();

                data.Add(tambah);

                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions 
                {
                    WriteIndented = true,
                });

                File.WriteAllText(FilePath, jsonString);

                Utility.InfoCommand("Berhasil tambah data");
                Utility.MainCommand();
                return true;
            }
            catch (Exception ex) 
            {
                Utility.ErrorCommand($"Gagal tambah data: {ex.Message}");
                Utility.MainCommand();
                return false;
            }
        }

        public static void ReadData()
        {
            List<data> data = GetData();

            if (data.Count == 0)
            {
                Utility.ErrorCommand("Tidak ada data");
                Utility.MainCommand();
            }
            else
            {
                Utility.InfoCommand("\n=== Daftar Task ===");

                foreach (var datas in data)
                {
                    Utility.InfoCommand($"\n ID          : {datas.ID}");
                    Utility.InfoCommand($" Name        : {datas.Name}");
                    Utility.InfoCommand($" Description : {datas.Description}");
                    Utility.InfoCommand($" Status      : {datas.Status}");
                    Utility.InfoCommand($" Create at   : {datas.CreateAt}");
                    Utility.InfoCommand($" Update at   : {datas.UpdateAt}");
                    Utility.InfoCommand("\n");
                }
                Utility.MainCommand();
            }
        }

        public static bool UpdateData(int id, data update)
        {
            try
            {
                List<data> data = GetData();
                
                data? existingData = data.FirstOrDefault(i => i.ID == id);

                if( existingData == null )
                {
                    Utility.ErrorCommand("Data tidak ditemukan");
                }

                existingData.Name = update.Name;
                existingData.Description = update.Description;
                existingData.Status = update.Status;
                existingData.UpdateAt = DateTime.Now;

                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true,
                });

                File.WriteAllText(FilePath, jsonString);
                Utility.InfoCommand("Tugas berhasil di update");
                Utility.MainCommand();

                return false;
            }
            catch (Exception ex)
            {
                Utility.ErrorCommand("Tugas gagal di update");
                Utility.MainCommand();

                return false;
            }
        }

        public static bool DeleteData(int id)
        {
            try
            {
                List<data> datas = GetData();
                data? deleteData = datas.FirstOrDefault(i => i.ID == id);

                if (deleteData == null)
                {
                    Utility.ErrorCommand("Id tugas tidak ditemukan");
                }

                datas.Remove(deleteData);

                string jsonString = JsonSerializer.Serialize(datas, new JsonSerializerOptions
                {
                    WriteIndented = true,
                });

                File.WriteAllText(FilePath, jsonString);
                Utility.InfoCommand("Tugas berhasil di hapus");
                Utility.MainCommand();
                return false;
            }
            catch
            {
                Utility.ErrorCommand("Tugas gagal di hapus");
                Utility.MainCommand();
                return false;
            }
        }

        public static void DoneData()
        {
            List<data> datas = GetData();

            if(datas.Count == 0)
            {
                Utility.ErrorCommand("tidak ada data");
                Utility.MainCommand();
            }
            else
            {
                {
                   
                        Utility.InfoCommand("\n=== Daftar Task ===");

                        foreach (var datass in datas)
                        {
                            if (datass.Status == "selesai")
                            {
                                Utility.InfoCommand($"\n ID          : {datass.ID}");
                                Utility.InfoCommand($" Name        : {datass.Name}");
                                Utility.InfoCommand($" Description : {datass.Description}");
                                Utility.InfoCommand($" Status      : {datass.Status}");
                                Utility.InfoCommand($" Create at   : {datass.CreateAt}");
                                Utility.InfoCommand($" Update at   : {datass.UpdateAt}");
                                Utility.InfoCommand("\n");
                            }
                        }
                        Utility.MainCommand();
                    
                }
            }


        }

        public static void ProgressData()
        {
            List<data> datas = GetData();

            if (datas.Count == 0)
            {
                Utility.ErrorCommand("tidak ada data");
                Utility.MainCommand();
            }
            else
            {
                {

                    Utility.InfoCommand("\n=== Daftar Task ===");

                    foreach (var datass in datas)
                    {
                        if (datass.Status == "progress")
                        {
                            Utility.InfoCommand($"\n ID          : {datass.ID}");
                            Utility.InfoCommand($" Name        : {datass.Name}");
                            Utility.InfoCommand($" Description : {datass.Description}");
                            Utility.InfoCommand($" Status      : {datass.Status}");
                            Utility.InfoCommand($" Create at   : {datass.CreateAt}");
                            Utility.InfoCommand($" Update at   : {datass.UpdateAt}");
                            Utility.InfoCommand("\n");
                        }
                    }
                    Utility.MainCommand();

                }
            }
        }

        public static void NotDoneData()
        {
            List<data> datas = GetData();

            if (datas.Count == 0)
            {
                Utility.ErrorCommand("tidak ada data");
                Utility.MainCommand();
            }
            else
            {
                {

                    Utility.InfoCommand("\n=== Daftar Task ===");

                    foreach (var datass in datas)
                    {
                        if (datass.Status == "tidak selesai")
                        {
                            Utility.InfoCommand($"\n ID          : {datass.ID}");
                            Utility.InfoCommand($" Name        : {datass.Name}");
                            Utility.InfoCommand($" Description : {datass.Description}");
                            Utility.InfoCommand($" Status      : {datass.Status}");
                            Utility.InfoCommand($" Create at   : {datass.CreateAt}");
                            Utility.InfoCommand($" Update at   : {datass.UpdateAt}");
                            Utility.InfoCommand("\n");
                        }
                    }
                    Utility.MainCommand();

                }
            }
        }
    }
}
