namespace MetanitLessons.Maui.CarouselViews;

public partial class CreateCarouselViewPage : ContentPage
{
	public CreateCarouselViewPage()
	{
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

			Image image = new Image { WidthRequest = 150, HeightRequest = 150 };
			image.SetBinding(Image.SourceProperty, nameof(Product.ImagePath));

			Label description = new Label { HorizontalTextAlignment = TextAlignment.Center };
			description.SetBinding(Label.TextProperty, nameof(Product.Description));

			StackLayout stackLayout = new StackLayout { header, image, description };

			Frame frame = new Frame
			{
				Content = stackLayout,
				CornerRadius = 20,
				HasShadow = true,
				Shadow = new Shadow
				{
					Brush = Brush.Black,
					Offset = new Point(15f, 15f),
					Opacity = 0.3f
				}
			};

			StackLayout layout = new StackLayout { Children = { frame }, Padding = 10 };

			return layout;
		});

		// По умолчанию ориентация - горизонтальная
		carouselView.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal);

		// индикатор прокрутки
		IndicatorView indicatorViewCS = new IndicatorView
		{
			Margin = new Thickness(0, 10, 0, 0),
			IndicatorColor = Colors.DarkGray,
			HorizontalOptions = LayoutOptions.Center
		};

		carouselView.IndicatorView = indicatorViewCS;

		Content = new StackLayout { carouselView, indicatorViewCS };

		//InitializeComponent();
	}
}