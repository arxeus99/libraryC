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
using Dapper;

namespace BiblotecaUI
{
    public partial class Form2 : Form
    {
        Book _selected;
        private static string connectionString =
            "Server=localhost;Database=biblioteca;Uid=lector;";
        public Form2(Book selectedBook)
        {
            InitializeComponent();
            List<Autor> autores = new List<Autor>();
            _selected = selectedBook;
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            string sql = "SELECT autors.NOM_AUT FROM biblioteca.autors INNER JOIN biblioteca.lli_aut ON autors.ID_AUT = lli_aut.FK_IDAUT WHERE FK_IDLLIB =" + _selected.ID_LLIB+";";
            autores = connection.Query<Autor>(sql).ToList();
            title.Text = _selected.TITOL;
            description.Text = _selected.DESCRIP_LLIB;
            department.Text = _selected.FK_DEPARTAMENT;
            autoresList.DataSource = autores;
            autoresList.DisplayMember = "NOM_AUT";

            connection.Close();


        }
    }
}
