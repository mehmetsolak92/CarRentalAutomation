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
    public partial class Cars : BaseForm
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            CarsList carsListPage = new CarsList();
            Methods.showFormInPanel(pnlScreens, carsListPage);

        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            CarsList carsListPage = new CarsList();
            Methods.showFormInPanel(pnlScreens, carsListPage);
        }
    }
}
