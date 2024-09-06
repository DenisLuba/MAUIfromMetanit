namespace MetanitLessons;

/**
 * ���� ����� � ����, ��� ��� iOS ������ ���� ��������� 20 ������, 
 * ����� �� �������� �� ������� ������.
 * M���� ������ ���� ������ ������ ��� iOS (������ ��� ����)
 */

public partial class ThicknessPage : ContentPage
{
	public ThicknessPage()
	{


		var stackLayout = new StackLayout
		{
			BackgroundColor = Colors.LightGray,

			// ���������� �������
			// ������������ ��������� Thickness (����. �������)
			Padding = new Thickness(uniformSize:60),
            // ������� �������
            Margin = new Thickness(horizontalSize:30, verticalSize:50),

			Children =
			{
				new BoxView
				{
					Color = Colors.Blue, 
					// ������� �������
					Margin = new Thickness(50),
					// ������ BoxView = 50
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

		// ���������� ������� ������ ��� iOS:
		if (DeviceInfo.Platform == DevicePlatform.iOS)
			Padding = new Thickness(0, 20, 0, 0);

        InitializeComponent();
	}
}