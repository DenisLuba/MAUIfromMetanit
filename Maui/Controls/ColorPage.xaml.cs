namespace HelloApp;

public partial class ColorPage : ContentPage
{
	public ColorPage()
	{
        Content = new Label
		{
			Text = "Hello World!",
			// выравнивание по горизонтали и вертикали
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Center,
			// фоновый цвет
			BackgroundColor = new Color(178, 223, 219, 200),
            // или BackgroundColor = Color.FromRgba(178, 223, 219, 200)
            // или BackgroundColor = Color.FromArgb("#C8B2DFDB")
            // цвет текста
            TextColor = Colors.DarkBlue
		};

        InitializeComponent();
	}
}