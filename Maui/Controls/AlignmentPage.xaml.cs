namespace HelloApp;

public partial class AlignmentPage : ContentPage
{
	public AlignmentPage()
	{
		Label label = new Label
		{
			Text = "Hello world"
		};
		// выравнивание по вертикали по центру
		label.VerticalOptions = LayoutOptions.Center;
		// выравнивание по горизонтали по центру
		label.HorizontalOptions = LayoutOptions.Center;

		Content = label;

		InitializeComponent();
    }
}