using System.Globalization;

namespace MetanitLessons.Maui.Bindings;

public partial class ValueConverterPage : ContentPage
{
	public ValueConverterPage()
	{
		Label label = new Label();
		DatePicker datePicker = new DatePicker();

		// BindingContext возвращает или устанавливает объект (DatePicker),
		// содержащий свойства (DatePicker.Date),
		// на которые будут нацелены связанные свойства (Label.Text),
		// которые принадлежат объекту BindableObject (Label)
		label.BindingContext = datePicker;

		// SetBinding создает и устанавливает привязку к свойству
		// (Label.TextProperty привязывается к DatePicker.Date)
		label.SetBinding(
			targetProperty: Label.TextProperty, // свойство, которое нужно привязать
			path: nameof(DatePicker.Date), // свойство, к которому привязывамся
			converter: new DateTimeToLocalDateConveter()); // конвертер преобразования значений

		/* Или так:
		 
		Binding binding = new Binding 
		{ 
			Source = datePicker, 
			Path = nameof(DatePicker.Date),
			Converter = new DateTimeToLocalDateConverter()
		};

		label.SetBinding(Label.TextProperty, binding);
		 */


		Entry entry = new Entry();
		Binding binding = new Binding { Source = entry, Path = "Text", Converter = new StringToColorConverter() };
		label.SetBinding(Label.TextColorProperty, binding);

		StackLayout stackLayout = new StackLayout
		{
			Children = { label, datePicker, entry },
			Padding = 20
		};
		Content = stackLayout;

		InitializeComponent();
	}
}

// класс конвертера значений должен реализовать интерфейс IValueConverter
class DateTimeToLocalDateConveter : IValueConverter
{
	// Convert() преобразует пришедшее от привязки значение в тот тип, который понимается приемником привязки
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		return value is not null ? ((DateTime)value).ToString("dd.MM.yyyy") : "Try again later";
	}

	// ConvertBack() выполняет обратную операцию. Он вызывается,
	// когда передаются от цели привязки к источнику при режимах привязки TwoWay и OneWayToSource
	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		DateTime.TryParse(value?.ToString(), out DateTime result);
		return result;
	}
	/*
	 * object? value: значение, которое надо преобразовать

	 * Type targetType: тип, к которому надо преобразовать значение value

	 * object? parameter: вспомогательный параметр

	 * CultureInfo culture: текущая культура приложения
	 */
}

class StringToColorConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		string? colorString = value?.ToString()?.Trim().ToLower();

		return colorString switch
		{
			"red" => Colors.Red,
			"green" => Colors.Green,
			"blue" => Colors.Blue,
			_ => Colors.Gray
		};
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		var color = value as Color;
		var colorHex = color?.ToHex();

		return colorHex switch
		{
			"#FF0000" => "red",
			"#00FF00" => "green",
			"#0000FF" => "blue",
			_ => "gray"
		};
	}
}