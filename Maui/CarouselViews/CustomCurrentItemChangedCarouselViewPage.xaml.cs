using System.Windows.Input;

namespace MetanitLessons.Maui.CarouselViews;

public partial class CustomCurrentItemChangedCarouselViewPage : ContentPage
{
	public ICommand SelectCommand { get; set; }

	public CustomCurrentItemChangedCarouselViewPage()
	{
		InitializeComponent();

		SelectCommand = new Command<Product>(async p =>
		{
			await DisplayAlert("Notification", $"You have selected: {p.Name}", "OK");
		});

		BindingContext = this;
	}
}