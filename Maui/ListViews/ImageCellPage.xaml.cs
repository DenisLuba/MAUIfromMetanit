namespace MetanitLessons.Maui.ListViews;

public partial class ImageCellPage : ContentPage
{
	public ImageCellPage()
	{
		ListView listViewCS = new ListView();
		// ���������� �������� ������
		listViewCS.ItemsSource = new List<Language>
		{
			new Language { Name = "C#", ImagePath = "c_sharp_icon.svg", Description = "��������� ������ C# 12"},
			new Language { Name = "Java", ImagePath = "java_icon.svg", Description = "��������� ������ Java 19"},
			new Language { Name = "Python", ImagePath = "python_icon.svg", Description = "��������� ������ Python 3.11"},
			new Language { Name = "C++", ImagePath = "c_plus_plus_icon.svg", Description = "��������� ������ C++ 23"}
		};
		// ���������� ������ ������
		listViewCS.ItemTemplate = new DataTemplate(ImageCellTemplate);

		Label header = new Label { FontSize = 18, Text = "����� ����������������" };
		Content = new StackLayout { Children = { header, listViewCS }, Padding = 8 };

		InitializeComponent();
	}

	private Func<ImageCell> ImageCellTemplate = () =>
	{
		ImageCell imageCell = new ImageCell
		{
			TextColor = Color.FromArgb("#455A64"),
			DetailColor = Color.FromArgb("#90A4AE")
		};

		imageCell.SetBinding(ImageCell.TextProperty, nameof(Language.Name));
		imageCell.SetBinding(ImageCell.DetailProperty, nameof(Language.Description));
		imageCell.SetBinding(ImageCell.ImageSourceProperty, nameof(Language.ImagePath));

		return imageCell;
	};
}

class Language
{
	public string Name { get; set; } = "";
	public string Description { get; set; } = "";
	public string ImagePath { get; set; } = "";
}