using EFCoreMarathon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreMarathon
{
    public partial class Form2 : Form
    {
        MyDBContext _db = new MyDBContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            var password2 = txtPassword2.Text.Trim();
            bool isAdmin = checkBox1.Checked;


            // SignUp Process
            if (CheckPasswordCriteria(password))
            {
                if (password2 == password)
                {
                    if (userName != null)
                    {
                        if (_db.Users.Any(a => a.UserName == userName))
                        {
                            MessageBox.Show("Username already exists!");
                        }
                        else
                        {
                            string passwordHash = Convert.ToString(sha256_hash(password));

                            User user = new User()
                            {
                                UserName = userName,
                                Password = password
                            };
                            _db.Users.Add(user);
                            _db.SaveChanges();

                            MessageBox.Show("User has created!");

                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                            this.Close();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Username can't be null!");

                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not same!");
                }
            }
            else
            {
                MessageBox.Show("Password is not valid!");
            }


        }

        private bool CheckPasswordCriteria(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            int uppercaseCount = password.Count(c => char.IsUpper(c));
            if (uppercaseCount < 2)
            {
                return false;
            }

            int lowercaseCount = password.Count(c => char.IsLower(c));
            if (lowercaseCount < 3)
            {
                return false;
            }

            int specialCharCount = password.Count(c => "!:+*".Contains(c));
            if (specialCharCount < 2)
            {
                return false;
            }

            return true;
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
        public bool Login(string username, string password)
        {
            // Kullanıcı adı ve şifrenin doğru olup olmadığını kontrol etme
            var admin = _db.Users.FirstOrDefault(a => a.UserName == username);
            if (admin == null || admin.Password != sha256_hash(password))
            {
                return false;
            }

            return true;
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
