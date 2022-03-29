using System;
using System.Data;
using Inventory.Models;
using MySql.Data.MySqlClient;

namespace Inventory.Services

{

    public class Database
    {
        //private string serverConfiguration = ;

        public static string GetVersion()
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            using var con = new MySqlConnection(constring);
            con.Open();

            return con.ServerVersion;
        }

        public static List<Breed> GetAllBreeds()
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string sql = "SELECT * from breed ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();

           
            var results= new List<Breed>();
            while (rdr.Read())
            {
                var breed = new Breed()
                {
                    Id = (int)rdr[0],
                    BreedName = (string)rdr[1],
                    Parent1BreedId = (int)rdr[2],
                    Parent2BreedId = (int)rdr[3],
                    ImgUrl = "/img/"+rdr[4]+".png",
                };

                results.Add(breed);
               // Console.WriteLine(results[0].BreedName);


            }
            return results;
        }
    }
}