namespace MVVM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.MLAllNotePage), typeof(Views.MLAllNotePage));
        }
    }
}
