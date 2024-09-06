using System.Runtime.CompilerServices;

namespace MetanitLessons;

public class ColorManagementPage : ContentPage
{
	Random random;
	public ColorManagementPage()
	{
		random = new Random();

		Grid grid = new Grid
		{
			BackgroundColor = Colors.LightBlue
		};

		Button button = new Button
		{
			Text = "Change Color",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };

		button.Clicked += async (sender, args) =>
		{
			var random = new Random();
			Color color = grid.BackgroundColor;
			// ��������� ������������
			color = color.WithAlpha(GetRandom());
			// ��������� ���� �����
			color = color.WithHue(GetRandom());
			// ��������� ������� �����
			color = color.WithLuminosity(GetRandom());
			// ��������� ������������ �����
			color.WithSaturation(GetRandom());

			grid.BackgroundColor = color;
		};

		grid.Add(button);
		Content = grid;
	}

	float GetRandom() => (float) random.NextDouble();
}