using MetanitLessons.Maui.ListViews;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new HeaderFooterListViewPage();
    }
}
