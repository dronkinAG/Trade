using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TradeApplication;
using TradeApplication.Models;

namespace TradeApplication
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();

            using (var db = new dbContext())
            {
                var c = db.Users.Count();
                if (c == 0)
                {
                    
                    db.Users.Add(new User()
                    {
                        Login = "admin",
                        Password = Utils.MD5("admin")
                    });

                    db.SaveChanges();
                }

                foreach (var user in db.Users)
                    loginBox.Items.Add(user);

                loginBox.DisplayMember = "Login";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void AuthForm_Load(object sender, EventArgs e)
        {
            using (var db = new dbContext())
            {
                var list = db.Users.Where(o => o.Login.Equals(loginBox.Text.Trim()));
                if (list.Count() > 0)
                {
                    loginBox.Items.Clear();
                    foreach (var user in list)
                        loginBox.Items.Add(user);
                    loginBox.DisplayMember = "Login";

                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)      //Авторизация
        {
            using (var db = new dbContext())
            {
                var list = db.Users.Where(o => o.Login.Equals(loginBox.Text.Trim()));
                if (list.Count() > 0)
                {
                    if (Utils.MD5(passText.Text) == list.FirstOrDefault().Password)
                    {
                        Close();
                    }
                    else
                    {
                        passText.Clear();
                        MessageBox.Show("Неверный пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    loginBox.Focus();
                    MessageBox.Show("Пользователь с таким логином не найден", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
