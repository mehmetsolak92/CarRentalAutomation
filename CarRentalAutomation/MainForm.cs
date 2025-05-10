using CarRentalAutomation.Class;

namespace CarRentalAutomation
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            lblActiveUser.Text = Constants.ActiveUser.AdSoyad;
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

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            Methods.showFormInPanel(pnlScreens, settingsPage);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }

        private void pbUserImg_Click(object sender, EventArgs e)
        {
            if (Constants.ActiveUser != null)
            {
                Constants.ActiveUser = null;
                lblActiveUser.Text = "-";
            }
            else
            {
                UserLogin loginPage = new UserLogin();
                loginPage.ShowDialog();
                if (Constants.ActiveUser != null)
                {
                    lblActiveUser.Text = Constants.ActiveUser.AdSoyad;
                }
            }
        }
    }
}
