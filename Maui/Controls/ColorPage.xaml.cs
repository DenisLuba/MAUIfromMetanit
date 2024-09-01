namespace HelloApp;

public partial class ColorPage : ContentPage
{
	public ColorPage()
	{
        Content = new Label
		{
			Text = "Hello World!",
			// ������������ �� ����������� � ���������
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Center,
			// ������� ����
			BackgroundColor = new Color(178, 223, 219, 200),
            // ��� BackgroundColor = Color.FromRgba(178, 223, 219, 200)
            // ��� BackgroundColor = Color.FromArgb("#C8B2DFDB")
            // ���� ������
            TextColor = Colors.DarkBlue
		};

        InitializeComponent();
	}
}