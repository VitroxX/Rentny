using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Activation
{ 
    public partial class Whitelist : Form
    {


        public Whitelist()
        {
            InitializeComponent();
        }
        public static string host = "remotemysql.com";//Database Host
        public static string database = "utv6WwnN7N";//Database name
        public static string user = "utv6WwnN7N";//Database user name
        public static string password = "5rUdiMAZLG";//Database password, if your database does not have one remove it from connection string
        public static string connectionString = "Data Source=" + host + ";Initial Catalog= " + database + ";User ID=utv6WwnN7N;password=" + password;//remove ,password= if your database does not have a password
                                                                                                                                               //----->                                                                               -------->

        public class HardDrive
        {
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM serials WHERE kay = '" + textfield.Text.ToString() + "'";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string key = reader.GetString("kay");
                int blacklisted = Convert.ToInt32(reader.GetString("black"));
                int used = Convert.ToInt32(reader.GetString("used"));
                string HWIDV = reader.GetString("HWID");
                string IP = reader.GetString("IP");
                string hostName = Dns.GetHostName();
                string IP1 = Dns.GetHostByName(hostName).AddressList[0].ToString();
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                string serial_number = "";

                foreach (ManagementObject wmi_HD in searcher.Get())
                {
                    serial_number = wmi_HD["SerialNumber"].ToString();
                }
                string HWID3 = MD5(serial_number);
                if (key.Contains(textfield.Text.ToString()))
                {

                    if (blacklisted == 0)
                    {
                        if (used != 1)
                        {
                            con.Close();
                            con.Open();
                            MessageBox.Show("Success");
                            MySqlCommand cmd1;
                            cmd1 = con.CreateCommand();
                            cmd1.CommandText = "UPDATE `serials` SET `HWID` = '" + HWID3 + "', `IP` = '" + IP1 + "', `used` = '1' WHERE `serials`.`kay` = '" + key + "';";
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            //load your form    
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                        else
                        {
                            if (HWIDV.Contains(HWID3) && IP.Contains(IP1))
                            {
                                MessageBox.Show("Success! Whitelisted!");
                                //load your form
                                this.Hide();
                                Form2 form2 = new Form2();
                                form2.Show();
                            }
                            else
                            {
                                con.Close();
                                con.Open();
                                MessageBox.Show("Dont try and share, Cause this key is now blacklisted");
                                MySqlCommand cmd2;
                                cmd2 = con.CreateCommand();
                                cmd2.CommandText = "UPDATE `serials` SET `black` = '1' WHERE `serials`.`kay` = '" + key + "';";
                                cmd2.ExecuteNonQuery();
                                con.Close();
                                Application.Exit();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! Key is blacklisted");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Error! Key is not in the database");
                }


            }
        }

        private static string MD5(string Metin)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteDizisi = Encoding.UTF8.GetBytes(Metin);
            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
