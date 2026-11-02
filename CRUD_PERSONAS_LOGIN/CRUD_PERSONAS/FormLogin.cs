using CRUD_PERSONAS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_PERSONAS
{
    public partial class FormLogin : Form
    {
        private readonly string _connectionString = "Server=localhost;Database=CRUD_PERSONAS;Integrated Security=True;TrustServerCertificate=True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            using var db = new AppDbContext(optionsBuilder.Options);

            var user = db.Users.FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Bienvenido {txtUsername.Text}!");


                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseñas incorrectas..");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}