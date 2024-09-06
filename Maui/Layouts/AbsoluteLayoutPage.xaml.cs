namespace MetanitLessons;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		// InitializeComponent();

		
		AbsoluteLayout absoluteLayout = new AbsoluteLayout();

		// определяем элементы, которые добавим на страницу:
		// цветная прямоугольная область
		BoxView boxView = new BoxView { Color = Colors.LightBlue };
		// текстовая область, которая будет располагаться поверх boxView
		Label label = new Label { Text = ".NET MAUI", FontSize = 20 };

		// добавляем элементы в absoluteLayout
		absoluteLayout.Add(boxView);
		absoluteLayout.Add(label);

		// определяем для этих элементов расположение и размеры
		int x = 30; // позиция координаты X на странице
		int y = 70; // позиция координаты Y на странице
		int width = 320; // ширина блока элемента
		int height = 100; // высота блока элемента
		Rect rect = new Rect(x, y, width, height);

		absoluteLayout.SetLayoutBounds(boxView, rect);

		absoluteLayout.SetLayoutBounds(
			label,
			new Rect(50, 100, 300, 40)
			);

		// добавляем absoluteLayout в содержимое страницы
		Content = absoluteLayout;

		
	}
}