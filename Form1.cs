using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginSederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-PGKJND9B\SQLEXPRESS01;Initial Catalog=dbLogin;Integrated Security=True;TrustServerCertificate=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from tbUser where username = '" + txtusername + "' and password = '" + txtpassword + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Usenname atau Password Salah!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}