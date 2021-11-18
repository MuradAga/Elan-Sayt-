using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elanlar
{
    public partial class login : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JR9L0BQ\\SQLEXPRESS; Initial Catalog=IsElanlari; Integrated Security=TRUE");
        public login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
            User user = new User();
            user.ShowDialog();
        }

		private void login_Load(object sender, EventArgs e)
		{

		}
	}
}
