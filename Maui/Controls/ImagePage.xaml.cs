namespace MetanitLessons;

/**
 * Image
 * ��������:

Aspect: ������������ ������ ���� Aspect, ������� ���������� ����� ��������������� �����������.

	� �������� �������� ����������� ���� �� �������� ������������ Aspect:

		AspectFit: ����������� �������������� � ����������� ���������� ��������� ����� ������� � �������, �� ������ � ������ �� ����� ���� ������ ������ � ������ Image

		AspectFill: ����������� �������������� � ����������� ���������� ��������� ����� ������� � �������, �������� ��� ������������ Image

		Fill: ����������� �������������� ��� ���������� ���������� ��������� ����� ������� � �������, �������� ��� ������������ Image

		Center: ����������� ������������ �� ������ � �������������� � ����������� ���������� ��������� ����� ������� � �������

IsAnimationPlaying: ������ �������� ���� bool, ���������� ����� �� ����������� �������� GIF. �� ��������� ����� false, �� ���� �������� ���������.

IsLoading: ������ �������� ���� bool, ��������� �� ������ �������� �����������. �� ��������� ����� false.

IsOpaque: ������ �������� ���� bool, ���������, ����� �� ����������� ��������������� ��� ����������. �� ��������� �������� false.

Source: ������ �������� ���� ImageSource, ������� ���������� �������� �����������.


 * ��� ������������� ��������� ���������� ����������� � ������ ImageSource ��������� ��� �������:

FromFile(): ���������� ������ ���� FileImageSource, ������� ��������� ������ �� ���������� �����.

FromUri(): ���������� ������ ���� UriImageSource, ������� ��������� ������ �� ������������� ������ Uri.

	��� UriImageSource ���� 2 ��������, ����������� �������������� ��������� ����������� �����������:

		CacheValidity: ������ ���� TimeSpan, ������� ���������� ����������������� �����������. �������� �� ��������� - 1 ����.

		CachingEnabled: �������� ���� bool, ������� ����������, ����� �� ����������� �����������. �������� �� ��������� - true (�� ���� ����������� ��������).

FromResource(): ���������� ������ ���� ResourceImageSource, ������� ��������� ������ �� ������� �� ������� ������.

FromStream(): ���������� ������ ���� StreamImageSource, ������� ��������� ������ ����������� �� ������.
 
 */

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		Image imageFromFile = new Image
		{
			Source = ImageSource.FromFile("forest.jpg")
			// Source = "forest.jpg"
		};

		//Image imageFromUri = new Image
		//{
		//	Source = ImageSource.FromUri(new Uri("https://news.microsoft.com/wp-content/uploads/2014/12/452292672.jpg"))
		// Source = "https://news.microsoft.com/wp-content/uploads/2014/12/452292672.jpg"
		//};

		Image imageFromUri = new Image();
		imageFromUri.Source = new UriImageSource
		{
			Uri = new Uri("https://news.microsoft.com/wp-content/uploads/2014/12/452292672.jpg"),
			CacheValidity = new TimeSpan(2, 0, 0, 0)
		};

		Grid grid = new Grid();
		grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
		grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
		grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
		grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

		var fileName = "forest.jpg";
		grid.Add(new Image { Source = fileName, Aspect = Aspect.AspectFit }, 0, 0);
		grid.Add(new Image { Source = fileName, Aspect = Aspect.AspectFill }, 1, 0);
		grid.Add(new Image { Source = fileName, Aspect = Aspect.Fill }, 0, 1);
		grid.Add(new Image { Source = fileName, Aspect = Aspect.Center }, 1, 1);

		StackLayout stackLayout = new StackLayout { Padding = 40 };
		stackLayout.Children.Add(imageFromFile);
		stackLayout.Children.Add(imageFromUri);
		stackLayout.Children.Add(grid);

		Content = stackLayout;

		InitializeComponent();
	}
}