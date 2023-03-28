using EFCoreMarathon.Models;
using System.Security.Cryptography;
using System.Text;

namespace EFCoreMarathon
{
    public partial class Form1 : Form
    {
        MyDBContext _db = new MyDBContext();


        public Form1()
        {

            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.BringToFront();
            form2.ShowDialog();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (Login(userName, password))
            {
                StaticEge.LoggedUser = _db.Users.Where(u => u.UserName == userName) as User;
                MessageBox.Show("Login is successful. Redirecting to Records!");
                this.Hide();
                Record record = new Record();
                record.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }


        }

        public bool Login(string username, string password)
        {
            // Kullanýcý adý ve þifrenin doðru olup olmadýðýný kontrol etme
            var admin = _db.Users.FirstOrDefault(a => a.UserName == username);
            if (admin == null || admin.Password != sha256_hash(password))
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}