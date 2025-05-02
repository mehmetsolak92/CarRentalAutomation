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
    public partial class Rent : BaseForm
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
        }
    }
}
