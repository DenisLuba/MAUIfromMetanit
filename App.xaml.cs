using MetanitLessons.Maui.ListViews;
using MetanitLessons.Maui.MVVM;
using MetanitLessons.Maui.CarouselViews;
using MetanitLessons.Maui.CollectionViews;
using MetanitLessons.Maui.Navigation.SimpleNavigation;
using MetanitLessons.Maui.Navigation.StackNavigation;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Maui.Navigation.NavigationForResult.MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#2980B9"),
            BarTextColor = Colors.White
        };
    }
}
