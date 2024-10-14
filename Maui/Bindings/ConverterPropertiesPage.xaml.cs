namespace MetanitLessons.Maui.Bindings;
using System.Globalization;

public partial class ConverterPropertiesPage : ContentPage
{
	public ConverterPropertiesPage()
	{
		Label label = new Label();
		Entry entry = new Entry();
		Binding binding = new Binding
		{
			Source = entry,
			Path = nameof(entry.Text),
			Converter = new StringToStatusConverter
			{
				ApprovedStatus = "Доступ одобрен",
				DeniedStatus = "Доступ отклонен"
			}
		};
		label.SetBinding(Label.TextProperty, binding);

//*****************************************************************

		Label label2 = new Label();
		Entry entry2 = new Entry();
		Binding binding2 = new Binding
		{
			Source = entry2,
			Path = nameof(entry2.Text),
			Converter = new StringToStyleConverter
			{
				ApprovedStatus = new Style(typeof(Label))
				{
					Setters = {
						new Setter
						{
							Property = Label.TextProperty,
							Value = "Доступ разрешен"
						},
						new Setter
						{
							Property = Label.TextColorProperty,
							Value = Colors.Green
						}
					}
				},

				DeniedStatus = new Style(typeof(Label))
				{
					Setters =
					{
						new Setter
						{
							Property = Label.TextProperty,
							Value = "Доступ отклонен"
						},

						new Setter
						{
							Property = Label.TextColorProperty,
							Value = Colors.Red
						},

						new Setter
						{
							Property = Label.TextDecorationsProperty,
							Value = TextDecorations.Underline
						}
					}
				}
			}
		};
		label2.SetBinding(Label.StyleProperty, binding2);

//*****************************************************************

		Entry entry3 = new Entry();
		Label euroLabel = new Label();
		Label dollarLabel = new Label();
		Binding euroBinding = new Binding
		{
			Source = entry3,
			Path = nameof(Entry.Text),
			Converter = new StringToCurrencyConverter(),
			ConverterParameter = "euro"
		};
		euroLabel.SetBinding(Label.TextProperty, euroBinding);

		Binding dollarBinding = new Binding
		{
			Source = entry3,
			Path = nameof(Entry.Text),
			Converter = new StringToCurrencyConverter(),
			ConverterParameter = "dollar"
		};
		dollarLabel.SetBinding(Label.TextProperty, dollarBinding);

//*****************************************************************

		Content = new StackLayout
		{
			Children = { entry, label, entry2, label2, entry3, euroLabel, dollarLabel },
			Padding = 20
		};

		InitializeComponent();
	}
}

public class StringToStatusConverter : IValueConverter
{
	// свойства конвертера:
	public string ApprovedStatus { get; set; } = "Approved";
	public string DeniedStatus { get; set; } = "Denied";

	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as string) == "admin" ? ApprovedStatus : DeniedStatus;
	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as string) == ApprovedStatus ? "admin" : "user";
}

public class StringToStyleConverter : IValueConverter
{
	public Style? ApprovedStatus { get; set; }
	public Style? DeniedStatus { get; set; }
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as string) == "admin" ? ApprovedStatus : DeniedStatus;

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as Style) == ApprovedStatus ? "admin" : "user";
}

public class StringToCurrencyConverter : IValueConverter
{
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> parameter?.ToString() == "euro" ? $"{value} €" : $"{value} $";

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> value?.ToString()?.Replace(" €", "").Replace(" $", "");
}