using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlCity : UserControl
    {
        public ctrlCity()
        {
            InitializeComponent();
        }
        public int id;
        private void btnAddNewCity_Click(object sender, EventArgs e)
        {

            if (CheckValidity())
            {
                String City = txtnewcity.Text;
                CityDAL Cdal = new CityDAL();
                Cdal.AddCity(City);
                List<Cities> C = Cdal.GetCities();
                dgvCities.DataSource = C;
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            CityDAL ctdal = new CityDAL();
            ctdal.DeleteCity(this.id);
            dgvCities.DataSource = ctdal.GetCities();
            RefreshCities();

        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            CityDAL Cdal = new CityDAL();
            Cdal.GetCities();
            RefreshCities();
        }

        private void dgvCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCities.SelectedRows.Count > 0)
            {
                this.id = Convert.ToInt32(dgvCities.SelectedRows[0].Cells[1].Value);
                txtnewcity.Text = dgvCities.SelectedRows[0].Cells[0].Value.ToString();

            }
            else
                MessageBox.Show("Please Select Row");
        }

        private void RefreshCities()
        {
            txtnewcity.Clear();
            txtnewcity.Focus();
        }
        public bool CheckValidity()
        {
            if (txtnewcity.Text == "")
            {
                MessageBox.Show("please enter city");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ctrlCity_Load(object sender, EventArgs e)
        {

        }
    }
}
