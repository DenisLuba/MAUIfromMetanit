namespace MetanitLessons;

/**
 * BoxView
 * ��������:
 
Color: ������������ ���� �������� � ���� ��������� Color.

BackgroundColor: ������������ ���� ���� ��� ���������.

CornerRadius: ������������ ������ ������� BoxView � ���� �������� ���� float.

WidthRequest: ������������ ������ �������� (�� ��������� ����� 40 ��������).

HeightRequest: ������������ ������ �������� (�� ��������� ����� 40 ��������).

 */

public partial class BoxViewPage : ContentPage
{
	public BoxViewPage()
	{
		Label labelMetanit = new Label
		{
			Text = "METANIT.COM",
			FontSize = 22,
			HorizontalOptions = LayoutOptions.Center
		};

		BoxView topLineBoxView = new BoxView
		{
			Color = Colors.Gray,
			HeightRequest = 2,
			Margin = new Thickness(1),
			HorizontalOptions = LayoutOptions.Fill
		};

		BoxView bottomLineBoxView = new BoxView
		{
			Color = Colors.Gray,
			HeightRequest = 2,
			Margin = new Thickness(1),
			HorizontalOptions = LayoutOptions.Fill
		};

		Label metanitGuideLabel = new Label
		{
			Text = "����������� �� .NET MAUI",
			FontSize = 18,
			HorizontalOptions = LayoutOptions.Center
		};

		BoxView boxView = new BoxView
		{
			Color = Colors.LightBlue,
			CornerRadius = 28,
			BackgroundColor = Colors.Transparent,
			WidthRequest = 150,
			HeightRequest = 150,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};

		StackLayout stackLayout = new StackLayout
		{
			Children =
			{
				labelMetanit,
				topLineBoxView,
				bottomLineBoxView,
				metanitGuideLabel,
				boxView
			},
			Margin = new Thickness(20)
		};

		Content = stackLayout;

		//InitializeComponent();
	}
}