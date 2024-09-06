namespace MetanitLessons;

/**
 * Ќадо иметь в виду, что дл€ iOS сверху надо отступать 20 единиц, 
 * чтобы не налазить на верхнюю панель.
 * Mожно задать этот отступ только дл€ iOS (смотри код ниже)
 */

public partial class ThicknessPage : ContentPage
{
	public ThicknessPage()
	{


		var stackLayout = new StackLayout
		{
			BackgroundColor = Colors.LightGray,

			// внутренние отступы
			// используетс€ структура Thickness (англ. “олщина)
			Padding = new Thickness(uniformSize:60),
            // внешние отступы
            Margin = new Thickness(horizontalSize:30, verticalSize:50),

			Children =
			{
				new BoxView
				{
					Color = Colors.Blue, 
					// внешние отступы
					Margin = new Thickness(50),
					// высота BoxView = 50
					HeightRequest = 100
				},

				new BoxView
				{
					Color = Colors.Red,
					Margin = new Thickness(left:10, top:20.5, right:30, bottom:50.5),
					HeightRequest = 100
				}
			}
		}; 

		Content = stackLayout;

		// применение отступа только дл€ iOS:
		if (DeviceInfo.Platform == DevicePlatform.iOS)
			Padding = new Thickness(0, 20, 0, 0);

        InitializeComponent();
	}
}