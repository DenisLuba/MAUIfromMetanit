namespace MetanitLessons;

/**
 * Image
 * Свойства:

Aspect: представляет объект типа Aspect, который определяет режим масштабирования изображения.

	В качестве значения принимается одна из констант перечисления Aspect:

		AspectFit: изображение масштабируется с сохранением аспектного отношения между шириной и высотой, но ширина и высота не могут быть больше ширины и высоты Image

		AspectFill: изображение масштабируется с сохранением аспектного отношения между шириной и высотой, заполняя все пространство Image

		Fill: изображение масштабируется без сохранения аспектного отношения между шириной и высотой, заполняя все пространство Image

		Center: изображение центрируется по центру и масштабируется с сохранением аспектного отношения между шириной и высотой

IsAnimationPlaying: хранит значение типа bool, определяет будет ли выполняться анимация GIF. По умолчанию равно false, то есть анимация отключена.

IsLoading: хранит значение типа bool, указывает на статус загрузки изображения. По умолчанию равно false.

IsOpaque: хранит значение типа bool, указывает, будет ли изображение рассматриваться как прозрачное. По умолчанию значение false.

Source: хранит значение типа ImageSource, которое определяет источник изображения.


 * Для использования различных источников изображения в классе ImageSource определен ряд методов:

FromFile(): возвращает объект типа FileImageSource, который считывает данные из локального файла.

FromUri(): возвращает объект типа UriImageSource, который считывает данные по определенному адресу Uri.

	Для UriImageSource есть 2 свойства, позволяющие переопределить поведение кэширования изображений:

		CacheValidity: объект типа TimeSpan, который определяет продолжительность кэширования. Значение по умолчанию - 1 день.

		CachingEnabled: значение типа bool, которое определяет, будет ли применяться кэширование. Значение по умолчанию - true (то есть кэширование включено).

FromResource(): возвращает объект типа ResourceImageSource, который считывает данные из ресурса из текущей сборки.

FromStream(): возвращает объект типа StreamImageSource, который считывает данные изображения из потока.
 
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