namespace MetanitLessons;

/**
 * Color:
 
Color.FromArgb(string hex): возвращает объект Color, созданный по переданному в качестве параметра шестнадцатеричному значению. 
	В качестве значения в метод передается строка в формате "#AARRGGBB", "#RRGGBB", "#ARGB" или "RGB", где A - показатель прозрачности, 
	R - значение для красного цвета, G - значение для зеленого компонента и B - представляет синий цвет

Color.FromRgb(double r, double g, double b): возвращает объект Color, для которого также устанавливаются компоненты красного, зеленого и синего

Color.FromRgb(int r, int g, int b): аналогичен предыдущей версии метода, только теперь компоненты красного, зеленого и синего имеют целочисленные значения от 0 до 255

Color.FromRgba(double r, double g, double b, double a): добавляет параметр прозрачности со значением от 0.0 (полностью прозрачный) до 1.0 (не прозрачный)

Color.FromRgba(int r, int g, int b, int a): добавляет параметр прозрачности со значением от 0 (полностью прозрачный) до 255 (не прозрачный)

Color.FromHsla(double h, double s, double l, double a): устанавливает последовательно параметры h (hue - тон цвета), s (saturation - насыщенность), 
	l (luminosity - яркость) и прозрачность

* Управление цветом:

ToHex: возвращает шестнадцатеричное значение текущего цвета в виде строки.

ToArgbHex: возвращает шестнадцатеричное значение текущего цвета в виде строки в формате ARGB

ToRgbaHex: возвращает шестнадцатеричное значение текущего цвета в виде строки в формате RGBA

ToInt: возвращает числовое ARGB-представление текущего цвета в виде значения int

ToUint: возвращает числовое ARGB-представление текущего цвета в виде значения uint

ToRgb: преобразует текущей цвет в отдельные компоненты RGB типа byte

ToRgba: преобразует текущей цвет в отдельные компоненты RGBA типа byte

ToHsl: преобразует текущей цвет в отдельные компоненты HSL типа float

* 

AddLuminosity: добавляет цвету яркость

MultiplyAlpha: умножает альфа-компоненту (прозрачность) цвета на переданное значение типа float

WithAlpha: заменяет альфа-компоненту цвета

WithHue: заменяет тон цвета

WithLuminosity: заменяет яркость цвета

WithSaturation: заменяет насыщенность цвета

 */

public partial class ColorPage : ContentPage
{
	public ColorPage()
	{
        Content = new Label
		{
			Text = "Hello World!",
			// выравнивание по горизонтали и вертикали
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Center,
			// фоновый цвет
			BackgroundColor = new Color(178, 223, 219, 200),
            // или BackgroundColor = Color.FromRgba(178, 223, 219, 200)
            // или BackgroundColor = Color.FromArgb("#C8B2DFDB")
            // цвет текста
            TextColor = Colors.DarkBlue
		};

        InitializeComponent();
	}
}