using MetanitLessons.Maui.Controls;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new ActivityIndicatorPage();
    }
}
