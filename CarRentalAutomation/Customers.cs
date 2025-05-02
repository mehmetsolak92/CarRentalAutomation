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
    public partial class Customers : BaseForm
    {
        public Customers()
        {
            InitializeComponent();
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
        }
    }
}
