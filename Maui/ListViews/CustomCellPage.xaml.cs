namespace MetanitLessons.Maui.ListViews;

public partial class CustomCellPage : ContentPage
{
	public CustomCellPage()
	{
		// HasUnevenRows = true - высота строк будет разной 
		// RowHeight = 100 - высота строк будет 100
		ListView listViewCS = new ListView { HasUnevenRows = true };
		// определ€ем источник данных
		listViewCS.ItemsSource = new List<ProgrammingLanguage>
		{
			new ProgrammingLanguage { Name = "C#", ImagePath = "c_sharp_icon.svg", Description = "ѕоследн€€ верси€ C# 12"},
			new ProgrammingLanguage { Name = "Java", ImagePath = "java_icon.svg", Description = "ѕоследн€€ верси€ Java 19"},
			new ProgrammingLanguage { Name = "Python", ImagePath = "python_icon.svg", Description = "ѕоследн€€ верси€ Python 3.11"},
			new ProgrammingLanguage { Name = "C++", ImagePath = "c_plus_plus_icon.svg", Description = "ѕоследн€€ верси€ C++ 23"}
		};
		// определ€ем шаблон данных
		listViewCS.ItemTemplate = new DataTemplate(() =>
		{
			CustomCell customCell = new CustomCell { ImageHeight = 40, ImageWidth = 40 };
			customCell.SetBinding(CustomCell.TitleProperty, nameof(ProgrammingLanguage.Name));
			customCell.SetBinding(CustomCell.DetailProperty, nameof(ProgrammingLanguage.Description));
			customCell.SetBinding(CustomCell.ImagePathProperty, nameof(ProgrammingLanguage.ImagePath));
			return customCell;
		});

		Label headerCS = new Label { FontSize = 18, Text = "языки программировани€" };
		Content = new StackLayout { Children = { headerCS, listViewCS }, Padding = 8 };
		
		InitializeComponent();
	}
}

class ProgrammingLanguage
{
	public string Name { get; set; } = "";
	public string Description { get; set; } = "";
	public string ImagePath { get; set; } = "";
}

class CustomCell : ViewCell
{
	Label titleLabelCS, detailLabelCS;
	Image image;

	public CustomCell()
	{
		titleLabelCS = new Label { FontSize = 18 };
		detailLabelCS = new Label();
		image = new Image();

		StackLayout cell = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			Margin = new Thickness(5, 8)
		};

		StackLayout titleDetailLayout = new StackLayout { Margin = new Thickness(5) };
		titleDetailLayout.Children.Add(titleLabelCS);
		titleDetailLayout.Children.Add(detailLabelCS);

		cell.Children.Add(image);
		cell.Children.Add(titleDetailLayout);
		View = cell;
	}

	public static readonly BindableProperty TitleProperty =
		BindableProperty.Create("Title", typeof(string), typeof(CustomCell), "");

	public static readonly BindableProperty ImagePathProperty =
		BindableProperty.Create("ImagePath", typeof(ImageSource), typeof(CustomCell), null);

	public static readonly BindableProperty ImageWidthProperty =
		BindableProperty.Create("ImageWidth", typeof(int), typeof(CustomCell), 100);

	public static readonly BindableProperty ImageHeightProperty =
		BindableProperty.Create("ImageHeight", typeof(int), typeof(CustomCell), 100);

	public static readonly BindableProperty DetailProperty =
		BindableProperty.Create("Detail", typeof(string), typeof(CustomCell), "");



	public string Title
	{
		get { return (string)GetValue(TitleProperty); }
		set { SetValue(TitleProperty, value); }
	}

	public ImageSource ImagePath
	{
		get => (ImageSource)GetValue(ImagePathProperty);
		set => SetValue(ImagePathProperty, value);
	}

	public int ImageWidth
	{
		get => (int)GetValue(ImageWidthProperty);
		set => SetValue(ImageWidthProperty, value);
	}

	public int ImageHeight
	{
		get => (int)GetValue(ImageHeightProperty);
		set => SetValue(ImageHeightProperty, value);
	}

	public string Detail
	{
		get => (string)GetValue(DetailProperty);
		set => SetValue(DetailProperty, value);
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();

		if (BindingContext != null)
		{
			titleLabelCS.Text = Title;
			detailLabelCS.Text = Detail;
			image.Source = ImagePath;
			image.WidthRequest = ImageWidth;
			image.HeightRequest = ImageHeight;
		}
	}
}