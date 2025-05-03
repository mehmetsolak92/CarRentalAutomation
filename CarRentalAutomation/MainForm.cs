using CarRentalAutomation.Class;

namespace CarRentalAutomation
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            HomePage homePage = new HomePage();
            Methods.showFormInPanel(pnlScreens, homePage);
        }

       

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            Methods.showFormInPanel(pnlScreens, homePage);

        }



        private void btnMenuRent_Click(object sender, EventArgs e)
        {
            Rent rentPage = new Rent();
            rentPage.AnaForm = this;
            Methods.showFormInPanel(pnlScreens, rentPage);
        }



        private void btnMenuCars_Click(object sender, EventArgs e)
        {
            Cars carsPage = new Cars();
            Methods.showFormInPanel(pnlScreens, carsPage);
        }

        private void btnMenuCustomers_Click(object sender, EventArgs e)
        {
            Customers customersPage = new Customers();
            Methods.showFormInPanel(pnlScreens, customersPage);
        }

        private void btnMenuFinance_Click(object sender, EventArgs e)
        {
            Finance financePage = new Finance();
            Methods.showFormInPanel(pnlScreens, financePage);
        }

        private void btnMenuReports_Click(object sender, EventArgs e)
        {
            Reports reportsPage = new Reports();
            Methods.showFormInPanel(pnlScreens, reportsPage);
        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            Methods.showFormInPanel(pnlScreens, settingsPage);
        }

     
    }
}
