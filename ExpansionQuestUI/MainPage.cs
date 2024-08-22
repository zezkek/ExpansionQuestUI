namespace ExpansionQuestUI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            idTextBox.Mask = "\\d";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
