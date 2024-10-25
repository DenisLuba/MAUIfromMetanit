using MetanitLessons.Maui.Bindings;
using MetanitLessons.Maui.Triggers;
using MetanitLessons.Maui.ListViews;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new BindingToSelectedItemPage();
    }
}
