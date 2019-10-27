using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblotecaUI
{
    public partial class searchAuthorsForm : Form
    {


        private static string connectionString =
            "Server=localhost;Database=biblioteca;Uid=lector;";

        public searchAuthorsForm()
        {
            InitializeComponent();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var forms = Application.OpenForms;
            foreach (Form form in forms)
            {
                if (form.Name == "Form1")
                {
                    form.Show();
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            List<Autor> authors = new List<Autor>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT ID_AUT, NOM_AUT FROM AUTORS" +
                $" WHERE NOM_AUT LIKE '%{authorTextBox.Text}%' ORDER BY ID_AUT";
            authors = connection.Query<Autor>(sql).ToList();
            authorsListBox.DataSource = authors;
            authorsListBox.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void authorsListBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void searchAuthorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
