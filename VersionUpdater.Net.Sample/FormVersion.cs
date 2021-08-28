using System.Windows.Forms;

namespace VersionUpdater.Net.Sample
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();

            labelVersion.Text = $"Version : {Application.ProductVersion}";
        }
    }
}
