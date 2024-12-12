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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-830GMOJ; initial catalog=DbCustomer; integrated security=true;");
        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerBalance, CustomerStatus, CityName FROM \r\nTblCustomer Inner Join TblCity On TblCity.CityId =TblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            

            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCity.ValueMember= "CityId";
            cmbCity.DisplayMember= "CityName";
            cmbCity.DataSource = dt;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert Into TblCustomer (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) " +
                "values(@customerName, @customerSurname, @customerCity, @customerBalance, @customerStatus)" , sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity" , cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", textBalance.Text);

            if(rdmActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }

            if (rdmPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Eklendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete From TblCustomer Where CustomerId=@customerId", sqlConnection);
            cmd.Parameters.AddWithValue("customerId", txtCustomerId.Text);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer Set CustomerName= @customerName,CustomerSurname= @customerSurname, CustomerCity= @customerCity, CustomerBalance= @customerBalance,CustomerStatus= @customerStatus " +
                "where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", textBalance.Text);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

            if (rdmActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }

            if (rdmPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Güncellendi");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerBalance, CustomerStatus, CityName FROM \r\nTblCustomer" +
             " Inner Join TblCity On TblCity.CityId =TblCustomer.CustomerCity Where CustomerName=@customerName", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }
    }
}
