using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace KomisSamochodowy
{
    static class BazaDanych
    {
        public static List<Samochod> samochody = new List<Samochod>();
        //public static List<User> users = new List<User>();
        //public static User currentuser;
        public static List<Reservation> reservations = new List<Reservation>();
        public static List<int> ulubioneId = new List<int>() ;
        public static void LoadCars()
        {
            string filePath = Environment.CurrentDirectory + "/Samochody.json";
            if (!File.Exists(filePath)) return;
            String json = File.ReadAllText(filePath);
            samochody = JsonConvert.DeserializeObject<List<Samochod>>(json);

        }
        public static void SaveCars()
        {
            string filePath = Environment.CurrentDirectory + "/Samochody.json";
            String json = JsonConvert.SerializeObject(samochody);
            File.WriteAllText(filePath, json);
        }

       

        public static int Indeksy()
        {
            int id = 0;
            bool jest = true;
            while (jest)
            {
                id++;
                jest = false;
                foreach (Samochod samochod in samochody)
                    if (samochod.id == id)
                        jest = true;
            }
            return id;
        }
    }

    [Serializable]
    public class Samochod
    {
        public string marka ;
        public string model;
        public string kolor ;   
        public string silnik ;
        public int id;
        public Samochod()
        {
            id = BazaDanych.Indeksy();
        }
    }


    public class Reservation
    {
        public string day;
        public int carId;
        public string nazwisko;
    }
}
