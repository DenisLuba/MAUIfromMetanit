using System.Globalization;

namespace MetanitLessons.Maui.Bindings;

public partial class ValueConverterPage : ContentPage
{
	public ValueConverterPage()
	{
		Label label = new Label();
		DatePicker datePicker = new DatePicker();

		// BindingContext ���������� ��� ������������� ������ (DatePicker),
		// ���������� �������� (DatePicker.Date),
		// �� ������� ����� �������� ��������� �������� (Label.Text),
		// ������� ����������� ������� BindableObject (Label)
		label.BindingContext = datePicker;

		// SetBinding ������� � ������������� �������� � ��������
		// (Label.TextProperty ������������� � DatePicker.Date)
		label.SetBinding(
			targetProperty: Label.TextProperty, // ��������, ������� ����� ���������
			path: nameof(DatePicker.Date), // ��������, � �������� ������������
			converter: new DateTimeToLocalDateConveter()); // ��������� �������������� ��������

		/* ��� ���:
		 
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

// ����� ���������� �������� ������ ����������� ��������� IValueConverter
class DateTimeToLocalDateConveter : IValueConverter
{
	// Convert() ����������� ��������� �� �������� �������� � ��� ���, ������� ���������� ���������� ��������
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		return value is not null ? ((DateTime)value).ToString("dd.MM.yyyy") : "Try again later";
	}

	// ConvertBack() ��������� �������� ��������. �� ����������,
	// ����� ���������� �� ���� �������� � ��������� ��� ������� �������� TwoWay � OneWayToSource
	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		DateTime.TryParse(value?.ToString(), out DateTime result);
		return result;
	}
	/*
	 * object? value: ��������, ������� ���� �������������

	 * Type targetType: ���, � �������� ���� ������������� �������� value

	 * object? parameter: ��������������� ��������

	 * CultureInfo culture: ������� �������� ����������
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