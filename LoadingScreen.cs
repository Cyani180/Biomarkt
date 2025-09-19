using System.Windows.Forms;

namespace Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingbarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingbarValue += 1;
            lblLoadingProgress.Text = loadingbarValue.ToString() + "%";
            loadingProgressbar.Value = loadingbarValue;

            if(loadingbarValue >= loadingProgressbar.Maximum)
            {
                loadingbarTimer.Stop();
            }

           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
