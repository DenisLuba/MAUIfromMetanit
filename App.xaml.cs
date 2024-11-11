using MetanitLessons.Maui.ListViews;
using MetanitLessons.Maui.MVVM;
using MetanitLessons.Maui.CarouselViews;
using MetanitLessons.Maui.CollectionViews;

namespace MetanitLessons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new CollectionViewPage();
    }
}
