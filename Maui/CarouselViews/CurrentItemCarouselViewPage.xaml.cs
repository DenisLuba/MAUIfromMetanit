using MetanitLessons.Maui.ListViews;
using System.Windows.Input;

namespace MetanitLessons.Maui.CarouselViews;

public partial class CurrentItemCarouselViewPage : ContentPage
{
	public ICommand SelectCommand { get; set; }

	public CurrentItemCarouselViewPage()
	{
		Label currentLabel = new Label(); // для вывода текущего элемента

		CarouselView carouselView = new CarouselView
		{
			VerticalOptions = LayoutOptions.Start
		};

		carouselView.ItemsSource = new List<Product>
		{
			new Product("Huawei", "Цена 59000", "huawei.png"),
			new Product("iPhone", "Цена 65000", "iphone.png"),
			new Product("Samsung", "Цена 60000", "samsung.png"),
			new Product("Honor", "Цена 55000", "honor.png")
		};

		// определяем шаблон данных
		carouselView.ItemTemplate = new DataTemplate(() =>
		{
			Label header = new Label
			{
				FontAttributes = FontAttributes.Bold,
				HorizontalTextAlignment = TextAlignment.Center,
				FontSize = 18
			};
			header.SetBinding(Label.TextProperty, nameof(Product.Name));

			Image image = new Image
			{
				WidthRequest = 150,
				HeightRequest = 150,
			};
			image.SetBinding(Image.SourceProperty, nameof(Product.ImagePath));

			Label description = new Label { HorizontalTextAlignment = TextAlignment.Center };
			description.SetBinding(Label.TextProperty, nameof(Product.Description));

			StackLayout stackLayout = new StackLayout { header, image, description };
			Frame frame = new Frame();
			frame.Content = stackLayout;
			return frame;
		});

		// определяем команду и параметр
		carouselView.CurrentItemChangedCommand = new Command<Product?>(p =>
		{
			currentLabel.Text = $"You have selected: {p?.Name}";
		});

		carouselView.SetBinding(
			CarouselView.CurrentItemChangedCommandParameterProperty,
			new Binding(nameof(CarouselView.CurrentItem), source: RelativeBindingSource.Self));

		Content = new VerticalStackLayout { currentLabel, carouselView };

		//InitializeComponent();

		// определяем команду и параметр
		//SelectCommand = new Command<Product>(p =>
		//{
		//	label.Text = $"You have selected: {p?.Name}";
		//});
		//// для привязки к Command
		//BindingContext = this;
	}

	private void carouselViewCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
	{
		Product? current = e.CurrentItem as Product; // возвращает текущий элемент
		Product? previous = e.PreviousItem as Product; // возвращает предыдущий элемент
		footer.Text = $"Current: {current?.Name} Previous: {previous?.Name}";
	}
}