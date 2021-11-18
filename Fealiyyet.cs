using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elanlar
{
    public partial class Fealiyyet : Form
    {
        public Fealiyyet()
        {
            InitializeComponent();
        }

        private void Fealiyyet_Load(object sender, EventArgs e)
        {
            string selectQuery = "select * from Kateqoriya where Silinib = 0";
            SqlCommand command = new SqlCommand(selectQuery, login.connection);
            login.connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("KateqoriyaId");
            dt.Columns.Add("KateqoriyaAd");

            while (reader.Read())
            {
                dt.Rows.Add(reader["KateqoriyaId"], reader["KateqoriyaAd"]);
            }

            cmbKateqoriyalar.DataSource = dt;
            cmbKateqoriyalar.DisplayMember = "KateqoriyaAd";
            cmbKateqoriyalar.ValueMember = "KateqoriyaId";
            login.connection.Close();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into Fealiyyet values(@kateqoriyaid,@fealiyyetad,'0')";
            SqlCommand command = new SqlCommand(insertQuery, login.connection);
            command.Parameters.AddWithValue("@kateqoriyaid", Convert.ToInt32(cmbKateqoriyalar.SelectedValue));
            command.Parameters.AddWithValue("@fealiyyetad", txtFealiyyet.Text.ToString());

            login.connection.Open();
            command.ExecuteNonQuery();
            login.connection.Close();
            MessageBox.Show("Fəaliyyət əlavə edildi : " + txtFealiyyet.Text.ToString(), "Fəaliyyət", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string deleteQuery = "update Fealiyyet set Silinib = 1 where FealiyyetId = @fealiyyetid";
            SqlCommand command = new SqlCommand(deleteQuery, login.connection);
            command.Parameters.AddWithValue("@fealiyyetid", Convert.ToInt32(cmbFealiyyetler.SelectedValue));

            login.connection.Open();
            command.ExecuteNonQuery();
            login.connection.Close();

            MessageBox.Show("Fəaliyyət silindi : " + cmbFealiyyetler.Text.ToString(), "Fəaliyyet", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            login.connection.Open();

            string selectQuery = "select FealiyyetId,FealiyyetAd from Fealiyyet where Silinib = 0 and KateqoriyaId = @kateqoriyaid";
            SqlCommand command = new SqlCommand(selectQuery, login.connection);
            command.Parameters.AddWithValue("@kateqoriyaid", Convert.ToInt32(cmbKateqoriyalar.SelectedValue));
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("FealiyyetId");
            dt.Columns.Add("FealiyyetAd");

            while (reader.Read())
            {
                dt.Rows.Add(reader["FealiyyetId"], reader["FealiyyetAd"]);
            }

            cmbFealiyyetler.DataSource = dt;
            cmbFealiyyetler.DisplayMember = "FealiyyetAd";
            cmbFealiyyetler.ValueMember = "FealiyyetId";

            login.connection.Close();
        }
    }
}
