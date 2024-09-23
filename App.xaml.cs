using MetanitLessons.Maui.Controls;
using MetanitLessons.Maui.ResourcesAndStyles;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new ExternalResourcesPage();
    }
}
