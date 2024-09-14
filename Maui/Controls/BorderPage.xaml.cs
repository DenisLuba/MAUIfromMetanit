using Microsoft.Maui.Controls.Shapes;

namespace MetanitLessons;

/**
 * Border
 * Свойства:

StrokeShape: форма границы в виде объекта IShape.

Stroke: цвет границы в виде объекта класса Brush.

StrokeThickness: ширина границы в виде значения типа double (значение по умолчанию 1.0).

StrokeDashArray: коллекция значений типа double в виде объекта DoubleCollection, 
	которые определяют черточки и пропуски, из которых состоит граница.

StrokeLineCap: описывает форму в начале и конце линии в виде объекта PenLineCap. 
	Значение по умолчанию - PenLineCap.Flat.

StrokeLineJoin: задает тип соединения в виде значения типа PenLineJoin, 
	которое используется на вершинах фигуры, образуемой линией. 
	Значение по умолчанию - PenLineJoin.Miter.

 * Данный контейнер может вмещать только один элемент. Но можно вставить, например, StackLayout
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
			Text = ".NET MAUI - технология, предназначенная для создания кроссплатформенных приложений.",
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