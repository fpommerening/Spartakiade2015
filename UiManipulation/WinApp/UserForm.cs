using System.Windows.Forms;
using FP.Spartakiade2015.UiManipulation.BL;

namespace FP.Spartakiade2015.UiManipulation.WinApp
{
    public partial class UserForm : Form
    {
        private UserController controller;

        public UserForm()
        {
            InitializeComponent();
            controller = new UserController();
            controller.DataSourceInitialized += controller_DataSourceInitialized;
        }

        private void controller_DataSourceInitialized(object sender, System.EventArgs e)
        {
            // do something with the loaded user
        }

        private void TestForm_Load(object sender, System.EventArgs e)
        {
            controller.InitDataSource();
        }
    }
}
