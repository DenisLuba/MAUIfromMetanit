using MetanitLessons.Maui.Controls;
using MetanitLessons.Maui.ResourcesAndStyles;
using MetanitLessons.Maui.Bindings;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new BindingModePage();
    }
}
