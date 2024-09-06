namespace MetanitLessons;

public partial class WidthAndHeight : ContentPage
{
	public WidthAndHeight()
	{
		InitializeComponent();

		Button button = new Button
		{
			WidthRequest = 100,
			HeightRequest = 100,
			Text = "Click"
		};

		Content = new Grid { Children = { button } };
    }
}