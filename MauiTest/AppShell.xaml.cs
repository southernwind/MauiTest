namespace MauiTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            this.InitializeComponent();
			this.GoToAsync("//MainPage");
		}
    }
}
