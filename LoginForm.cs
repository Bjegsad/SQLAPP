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

namespace SQLAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.pass_field.AutoSize = false;
            this.pass_field.Size = new Size(this.pass_field.Size.Width, 65);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = login_field.Text;
            String passUser = pass_field.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0) //Если такие есть в таблице user, то да
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }
    }
}
