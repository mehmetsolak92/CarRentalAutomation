using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalAutomation.Class;

namespace CarRentalAutomation
{
    public partial class CarsList : BaseForm
    {
        public CarsList()
        {
            InitializeComponent();
        }

        private void CarsList_Load(object sender, EventArgs e)
        {
            GetCarsData();
        }

        private void GetCarsData()
        {
            string query = "SELECT * FROM Cars";
            DataTable dataTable = SQL.Select(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                dgvCars.DataSource = dataTable;
               

            }

        }
    }
}
