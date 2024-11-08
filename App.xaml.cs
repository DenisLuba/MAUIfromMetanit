using MetanitLessons.Maui.ListViews;
using MetanitLessons.Maui.MVVM;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new CommandPage();
    }
}
