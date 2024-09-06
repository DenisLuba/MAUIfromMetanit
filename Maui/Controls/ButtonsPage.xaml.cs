
namespace MetanitLessons;

/**
 * Button (кнопка)
 * 
 * Свойства:

ontFamily: шрифт, который используется для текста на кнопке

FontSize: размер текста на кнопке

FontAttributes: выделение жирным или курсивом текста на кнопке

FontAutoScalingEnabled: указывает, будет ли текст кнопки масштабироваться в соответствии с настройками системы

LineBreakMode: объект типа LineBreakMode, который указывает, как будет переноситься текст кнопки

TextColor: цвет шрифта

BorderColor: цвет границы

BorderWidth: ширина границы

ImageSource: позволяет задать изображение на кнопке


* События:

Clicked: событие нажатия пальцем или указателем мыши на кнопку. Событие срабатывает, когда пользователь убирает палец или мышь с кнопки

Pressed: событие нажатия пальцем или указателем мыши на кнопку. Событие срабатывает, когда палец пользователя или мышь находятся на кнопке

Released: событие нажатия пальцем или указателем мыши на кнопку. Событие срабатывает, когда пользователь убрал палец или мышь с кнопки
 */

public partial class ButtonsPage : ContentPage
{
	public ButtonsPage()
	{
		Button button = new Button
		{
			Text = "Нажми",
			// размер шрифта
			FontSize = 22,
			// толщина границы
			BorderWidth = 1,
			// цвет кнопки
			BackgroundColor = Colors.LightPink,
			// цвет текста
			TextColor = Colors.DarkRed,
			// расположение кнопки
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};

		button.Clicked += OnButtonClicked;

        Grid grid = new Grid();
		grid.Children.Add(button);

		Content = grid;

        InitializeComponent();
	}

    void OnButtonClicked(object? sender, EventArgs e)
    {
		(sender as Button)!.Text = "Нажато";
    }
}