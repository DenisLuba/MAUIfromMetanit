using MetanitLessons.Maui.Bindings;
using MetanitLessons.Maui.Triggers;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MultiTriggerPage();
    }
}
