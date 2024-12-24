using Project.V15.Lib;
namespace Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        private void buttonHelp_ANR_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void buttonInfo_ANR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_ANR_Click(object sender, EventArgs e)
        {

        }
        private void buttonCreateTable_ANR_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateChart_ANR_Click(object sender, EventArgs e)
        {

        }
        private void textBoxMinLen_ANR_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
