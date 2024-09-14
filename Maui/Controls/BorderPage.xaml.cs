using Microsoft.Maui.Controls.Shapes;

namespace MetanitLessons;

/**
 * Border
 * ��������:

StrokeShape: ����� ������� � ���� ������� IShape.

Stroke: ���� ������� � ���� ������� ������ Brush.

StrokeThickness: ������ ������� � ���� �������� ���� double (�������� �� ��������� 1.0).

StrokeDashArray: ��������� �������� ���� double � ���� ������� DoubleCollection, 
	������� ���������� �������� � ��������, �� ������� ������� �������.

StrokeLineCap: ��������� ����� � ������ � ����� ����� � ���� ������� PenLineCap. 
	�������� �� ��������� - PenLineCap.Flat.

StrokeLineJoin: ������ ��� ���������� � ���� �������� ���� PenLineJoin, 
	������� ������������ �� �������� ������, ���������� ������. 
	�������� �� ��������� - PenLineJoin.Miter.

 * ������ ��������� ����� ������� ������ ���� �������. �� ����� ��������, ��������, StackLayout
 */

public partial class BorderPage : ContentPage
{
	public BorderPage()
	{
		Label header = new Label
		{
			Text = ".NET MAUI",
			HorizontalTextAlignment = TextAlignment.Center,
			FontSize = 24
		};

		BoxView underLine = new BoxView
		{
			HeightRequest = 2,
			Color = Colors.DarkGray,
			Margin = 10
		};

		Label text = new Label
		{
			Text = ".NET MAUI - ����������, ��������������� ��� �������� ������������������ ����������.",
			FontSize = 18,
		};

		StackLayout content = new StackLayout();
		content.Children.Add(header);
		content.Children.Add(underLine);
		content.Children.Add(text);

        Border border = new Border
		{
			Stroke = Colors.Gray,
			StrokeShape = new RoundRectangle { CornerRadius = 20 },
			BackgroundColor = Color.FromArgb("#e1e1e1"),
			Padding = 8,
			Content = content
		};

		Grid grid = new Grid
		{
			Padding = 20,
		};

		grid.Add(border);

		Content = grid;
	

		InitializeComponent();
	}
}