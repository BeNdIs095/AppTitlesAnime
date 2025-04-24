using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;
        public FormListGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            //Скрытие столбцов
            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["TitlesGenres"].Visible = false;

            //Изменение названий заголовков столбцов
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанры аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");


            this.dataGridViewGenres.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void BtnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formAddGenre.textBoxGenreName.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewGenres.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void dataGridViewGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
