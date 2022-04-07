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
            con.Close();
            return results;
        }

        public static List<Dog> GetAllDogs()
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string sql = "SELECT * from dogs ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();


            var results = new List<Dog>();
            while (rdr.Read())
            {
                var dog = new Dog()
                {
                    ID = (int)rdr[0],
                    Name = (string)rdr[1],
                    BreedID = (int)rdr[2],
                    MotherID = (int)rdr[3],
                    FatherID = (int)rdr[4],
                    KennelID = (int)rdr[5],
                    Pedigree=(string)rdr[6],
                    Sex = (string)rdr[7]
                };

                results.Add(dog);
                // Console.WriteLine(results[0].BreedName);


            }
            con.Close();
            return results;
        }

        public static List<Dog> GetDogsKennel(int kennelid)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            Console.WriteLine(kennelid);

            string sql = "SELECT * from dogs WHERE `kennel_id`="+kennelid+"";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();


            var results = new List<Dog>();
            while (rdr.Read())
            {
                var dog = new Dog()
                {
                    ID = (int)rdr[0],
                    Name = (string)rdr[1],
                    BreedID = (int)rdr[2],
                    MotherID = (int)rdr[3],
                    FatherID = (int)rdr[4],
                    KennelID = (int)rdr[5],
                    Pedigree = (string)rdr[6],
                    Sex=(string)rdr[7]
                };

                results.Add(dog);
                // Console.WriteLine(results[0].BreedName);


            }
            con.Close();
            return results;
        }


        public static void DeleteDog(int dogid)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";

            try
            {
                using var con = new MySqlConnection(constring);

                Console.WriteLine("delete " + dogid);
                string sql = "DELETE FROM dogs WHERE id =" + dogid + "";
                using var cmd = new MySqlCommand(sql, con);
                con.Open();
                using MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {

                }
                con.Close();
            }
            catch
            {

            }


        }

        public static void AddDog(string name, int breedid, int motherid, int fatherid, int kennelid, string pedigree, string sex)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            try
            {
                using var con = new MySqlConnection(constring);
                con.Open();
                

                string sql = "INSERT INTO `dogs`(`name`, `breed_id`, `mother_id`, `father_id`, `kennel_id`, `pedigree`,`sex`) VALUES ('"+name+"','"+breedid+"','"+motherid+"','"+fatherid+"','"+kennelid+"','"+pedigree+"','"+sex+"')";
                using var cmd = new MySqlCommand(sql, con);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch { }

        }

        public static void EditDog(int dogid, string dogname, int kennel)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            try
            {
                using var con = new MySqlConnection(constring);
                con.Open();
                Console.WriteLine("hello " + dogname+" kennel "+ kennel + " " + dogid);

                string sql = "UPDATE `dogs` SET `name`= '"+dogname+"',`kennel_id`='"+1+"' WHERE id="+dogid+"";
                using var cmd = new MySqlCommand(sql, con);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                using MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {

                }
                con.Close();
            }
            catch { }

        }

        public static Dog SelectDog(int id)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string sql = "SELECT * from dogs WHERE id="+id+"";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            var dog= new Dog();
            while (rdr.Read())
            {
                dog = new Dog()
                {
                    ID = (int)rdr[0],
                    Name = (string)rdr[1],
                    BreedID = (int)rdr[2],
                    MotherID = (int)rdr[3],
                    FatherID = (int)rdr[4],
                    KennelID = (int)rdr[5],
                    Pedigree = (string)rdr[6],
                };

                // Console.WriteLine(results[0].BreedName);


            }
            con.Close();
            return dog;
        }

        public static Boolean VerifyUser(int licensenum, string name, string surname)
        {
            string constring = "server=localhost;userid=root;password=;database=inventory;port=3306;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string sql = "SELECT * from breeders WHERE license_num='" + licensenum + "' AND breeder_name='"+name+"' AND breeder_surname='"+surname+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                return true;
            }

            else
            {
                return false;
            }

            
            
        }

        //your database functions here

    }
}
