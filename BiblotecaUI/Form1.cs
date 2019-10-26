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

    public partial class Form1 : Form
    {

        Boolean authorsFormShown = false;
        searchAuthorsForm authorsForm = null;

        private static string connectionString =
            "Server=localhost;Database=biblioteca;Uid=lector;";
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "SELECT id_llib, titol, disponible, descrip_llib, fk_departament FROM llibres" + $" WHERE titol LIKE '%{ bookTextBox.Text }%' ORDER BY id_llib";
            /*if (disponibleButton.Checked)
            {
                sql = "SELECT id_llib, titol, disponible, descrip_llib, fk_departament FROM llibres" + $" WHERE titol LIKE '%{ bookTextBox.Text }%'AND DISPONIBLE = 'DISPONIBLE' ORDER BY id_llib";
            }

            else
            {
                sql = "SELECT id_llib, titol, disponible, descrip_llib, fk_departament FROM llibres" + $" WHERE titol LIKE '%{ bookTextBox.Text }%' ORDER BY id_llib";
            }*/
            books = connection.Query<Book>(sql).ToList();
            /**foreach(var book in books)
            {
                booksListBox.Items.Add(book.ID_LLIB +" - "+book.TITOL);
            }**/
            booksListBox.DataSource = books;
            booksListBox.DisplayMember = "FullInfo";

            //Console.WriteLine(books[5].TITOL);
            connection.Close();
        }
    
        private void booksListBox_DoubleClick(object sender, EventArgs e)
        {
            Book selectedBook = booksListBox.SelectedItem as Book;
            Form2 bookDetailsForm = new Form2(selectedBook);
            DialogResult result = bookDetailsForm.ShowDialog(this);

        }


        private void authrosButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (!authorsFormShown)
            {
                authorsForm = new searchAuthorsForm();
                authorsForm.Show();
                authorsForm.Location = new Point(this.Location.X + this.Size.Width + 10, this.Location.Y);
                authorsFormShown = true;
            }

            authorsForm.Show();
        }
    }

}
