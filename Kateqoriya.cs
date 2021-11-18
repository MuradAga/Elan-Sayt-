using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elanlar
{
    public partial class Kateqoriya : Form
    {
        public Kateqoriya()
        {
            InitializeComponent();
        }

        void KateqoriyaYukle()
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
            login.connection.Close();
            cmbKateqoriyaSil.DataSource = dt;
            cmbKateqoriyaSil.DisplayMember = "KateqoriyaAd";
            cmbKateqoriyaSil.ValueMember = "KateqoriyaId";
        }

        void KateqoriyaElaveEt()
        {
            string insertQuery = "insert into Kateqoriya values(@kateqoriyaad,'0')";
            SqlCommand command = new SqlCommand(insertQuery, login.connection);
            command.Parameters.AddWithValue("@kateqoriyaad", txtKateqoriya.Text.ToString());

            login.connection.Open();
            command.ExecuteNonQuery();
            login.connection.Close();
            MessageBox.Show("Kateqoriya əlavə edildi : " + txtKateqoriya.Text.ToString(), "Kateqoriya", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void KateqoriyaSil()
        {
            string deleteQuery = "update Kateqoriya set Silinib = 1 where KateqoriyaId = @kateqoriyaid";
            SqlCommand command = new SqlCommand(deleteQuery, login.connection);
            command.Parameters.AddWithValue("@kateqoriyaid", Convert.ToInt32(cmbKateqoriyaSil.SelectedValue));

            login.connection.Open();
            command.ExecuteNonQuery();
            login.connection.Close();
            MessageBox.Show("Kateqoriya silindi : " + cmbKateqoriyaSil.Text.ToString(), "Kateqoriya", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Kateqoriya_Load(object sender, EventArgs e)
        {
            KateqoriyaYukle();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            KateqoriyaElaveEt();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KateqoriyaSil();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            login.connection.Open();

            string selectQuery = "select * from Ketqoriya where Silinib = 0";
            SqlCommand command = new SqlCommand(selectQuery, login.connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("KateqoriyaId");
            dt.Columns.Add("KateqoriyaAd");

            while (reader.Read())
            {
                dt.Rows.Add(reader["KateqoriyaId"], reader["KateqoriyaAd"]);
            }

            cmbKateqoriyaSil.DataSource = dt;
            cmbKateqoriyaSil.DisplayMember = "KateqoriyaAd";
            cmbKateqoriyaSil.ValueMember = "KateqoriyaId";

            login.connection.Close();
        }
    }
}
