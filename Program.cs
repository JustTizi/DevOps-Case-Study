using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Gang
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLiteConnection conn = CreateConnection();
            CreateTable(conn);
            conn.Close();
            Application.Run(new DifficultySelection());
        }

        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source = mathquizzer.db; Version = 3; New = True; Compress = True;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }

        public static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand cmd;
            string createTable = "CREATE TABLE IF NOT EXISTS HighScores (name VARCHAR(20), score INT, difficulty VARCHAR(6))";
            cmd = conn.CreateCommand();
            
            cmd.CommandText = createTable;
            
            cmd.ExecuteNonQuery();
        }

        public static void InsertData(SQLiteConnection conn, string name, int score, Difficulty diff)
        {
            SQLiteCommand cmd;
            string insertData = "INSERT INTO HighScores (name, score, difficulty) VALUES (@name, @score, @difficulty)";
            cmd = conn.CreateCommand();
           
            cmd.CommandText = insertData;
            
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@score", score); 
            cmd.Parameters.AddWithValue("@difficulty", diff.Level);
            
            cmd.ExecuteNonQuery();
        }

        public static String[] SelectData(SQLiteConnection conn, Difficulty diff)
        {
            SQLiteCommand cmd;
            string selectData = "SELECT name, score FROM HighScores WHERE difficulty = '" + diff.Level + "' ORDER BY score DESC LIMIT 1";
            cmd = conn.CreateCommand();
            
            cmd.CommandText = selectData;
            SQLiteDataReader reader = cmd.ExecuteReader();

            String[] highscore = new String[2];
            
            reader.Read();
            try 
            {
                highscore[0] = reader.GetString(0);
                highscore[1] = reader.GetInt32(1).ToString();
            }
            catch
            {
                highscore[0] = "No highscore";
                highscore[1] = "No highscore";
            }

            reader.Close();

            return highscore;
        }
    }
}
