using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-830GMOJ; initial catalog=DbCustomer; integrated security=true;");
        private void btnList_Click(object sender, EventArgs e)
        {
           
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblCity (CityName, CityCountry) values (@cityName, @cityCountry)", sqlConnection);

            cmd.Parameters.AddWithValue("@cityName", txtCityName.Text);
            cmd.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            cmd.ExecuteNonQuery();
            
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde eklendi!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete From TblCity Where CityId=@cityId", sqlConnection);
            cmd.Parameters.AddWithValue("cityId", txtCityId.Text);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Update TblCity Set CityName =@cityName, CityCountry=@cityCountry " +
                "where CityId=@cityId", sqlConnection);
            cmd.Parameters.AddWithValue("@cityName", txtCityName.Text);
            cmd.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            cmd.Parameters.AddWithValue("@cityId", txtCityId.Text);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblCity where CityName =@cityName", sqlConnection);
            cmd.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }
    }
}
