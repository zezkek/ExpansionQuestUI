namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class Target : Form
    {
        MainPage MainPage;
        public Target()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
        }
    }
}
