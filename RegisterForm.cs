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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            sureNameField.Text = "Введите фамилию";
            sureNameField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void sureNameField_Enter(object sender, EventArgs e)
        {
            if (sureNameField.Text == "Введите фамилию")
            {
                sureNameField.Text = "";
                sureNameField.ForeColor = Color.Gray;
            }
        }

        private void sureNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                sureNameField.Text = "Введите фамилию";
                sureNameField.ForeColor = Color.Black;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (sureNameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (login_field.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (pass_field.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`) VALUES(NULL, @login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_field.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass_field.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = sureNameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        public Boolean isUserExist()
        {

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_field.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //Если такие есть в таблице user, то да
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
