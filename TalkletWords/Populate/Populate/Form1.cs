using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Populate
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection connectAndOpen()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=TalkletWords;Trusted_Connection=True;MultipleActiveResultSets=true";
                conn.Open();
                return conn;
            }
            catch ( Exception ex) {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM WordType", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        // write the data on to the screen
                        Console.WriteLine(String.Format("{0}\t{1}", reader[0], reader[1]));
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVocabulary_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            List<String> text = File.ReadAllLines(@"S:\Talklet\talk-utilities\TalkletWords\Vocab.txt").ToList();
            try
            {
                foreach(string line in text)
                {
                    string[] f = line.Split('\t');
                    if (f.Length == 2)
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert Into VocabSize(Age, Vocabulary) VALUES(@Age, @VocabularySize)";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@age", f[0]);
                        command.Parameters.AddWithValue("@VocabularySize", f[1]);
                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnMLU_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            List<String> text = File.ReadAllLines(@"S:\Talklet\talk-utilities\TalkletWords\MLU.txt").ToList();
            try
            {
                foreach (string line in text)
                {
                    string[] f = line.Split('\t');
                    if (f.Length == 3)
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert Into MLU(Age, MLUFrom, MLUTo) VALUES(@Age, @MLUFrom, @MLUTo)";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@Age", f[0]);
                        command.Parameters.AddWithValue("@MLUFrom", f[1]);
                        command.Parameters.AddWithValue("@MLUTo", f[2]);
                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            List<String> text = File.ReadAllLines(@"S:\Talklet\talk-utilities\TalkletWords\Category.txt").ToList();
            try
            {
                foreach (string line in text)
                {
                    string[] f = line.Split('\t');
                    if (f.Length == 1)
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert Into Category(Name) VALUES(@Name)";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@Name", f[0]);
                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnData_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            List<String> text = File.ReadAllLines(@"S:\Talklet\talk-utilities\TalkletWords\Words.txt").ToList();
            try
            {
                foreach (string line in text)
                {
                    string[] f = line.Split('\t');
                    if (f.Length == 4)
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert Into Word(Definition, CategoryId, WordTypeId, Average) VALUES(@Definition, @CategoryId, @WordTypeId, @Average)";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@Definition", f[0]);
                        command.Parameters.AddWithValue("@CategoryId", f[1]);
                        command.Parameters.AddWithValue("@WordTypeId", f[2]);
                        command.Parameters.AddWithValue("@Average", f[3]);
                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnWordData_Click(object sender, EventArgs e)
        {
            conn = connectAndOpen();
            if (conn == null)
                return;
            List<String> text = File.ReadAllLines(@"S:\Talklet\talk-utilities\TalkletWords\WordData2.txt").ToList();
            string word;
            try
            {
                foreach (string line in text)
                {
                    string[] f = line.Split('\t');
                    if (f.Length == 24)
                    {
                        if (!f[23].Equals("0"))
                        {
                            for (int i = 1; i < 24; i++)
                            {
                                SqlCommand command = new SqlCommand();
                                command.CommandText = "INSERT INTO WordData(Months, Percentile, WordId) Values(@Month, @Percentile, (Select WordId FROM Word WHERE Definition = @word))";
                                command.Connection = conn;
                                command.Parameters.AddWithValue("@Month", i + 7);
                                command.Parameters.AddWithValue("@Percentile", f[i]);
                                command.Parameters.AddWithValue("@word", f[0]);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
