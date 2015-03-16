using System.Windows.Forms;
using FP.Spartakiade2015.UiManipulation.BL;

namespace FP.Spartakiade2015.UiManipulation.WinApp
{
    public partial class DocumentControl : UserControl
    {
        public DocumentController Controller { get; private set; }

        public DocumentControl()
        {
            InitializeComponent();
            Controller = new DocumentController();
            Controller.DataSourceInitialized += Controller_DataSourceInitialized;
        }

        private void Controller_DataSourceInitialized(object sender, System.EventArgs e)
        {
            labObjectId.Text = string.Format("zu Objekt {0} geladen", Controller.ObjectId);
        }


    }
}
