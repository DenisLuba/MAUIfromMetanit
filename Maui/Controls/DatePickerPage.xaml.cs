namespace MetanitLessons;

/**
 * DatePicker
 * —войства:

MaximumDate: максимальна€ возможна€ дата, по умолчанию равна 31 декабр€ 2100

MinimumDate: минимальна€ возможна€ дата, по умолчанию равна 1 €нвар€ 1900

Date: выбранна€ дата - значение структуры DateTime, по умолчанию равна значению DateTime.Today

Format: определ€ет формат даты, принимает стандартные дл€ .NET форматы .ѕо умолчанию равен "D" - 
	то есть дата отображаетс€ в расширенном формате

 * “акже определено событие DateSelected, которое срабатывает при выборе даты

public event EventHandler<DateChangedEventArgs> DateSelected;

¬ качестве второго параметра обработчик событи€ принимает объект DateChangedEventArgs, 
у которого можно выделить два свойства: NewDate (выбранна€ дата) и OldDate (стара€ дата)
 */

public partial class DatePickerPage : ContentPage
{
	Label label;
    public DatePickerPage()
	{
		label = new Label { Text = "¬ыберите дату" };
		DatePicker datePicker = new DatePicker
		{
			Format = "d",
			MaximumDate = DateTime.Now.AddDays(5),
			MinimumDate = DateTime.Now.AddDays(-5)
		};

		datePicker.DateSelected += DateSelected;
		StackLayout stackLayout = new StackLayout { Children = { label, datePicker }, Padding = 20 };
		Content = stackLayout;
		
		InitializeComponent();
	}

    void DateSelected(object? sender, DateChangedEventArgs e)
    {
		label.Text = $"¬ы выбрали {e.NewDate.ToString("d")}";
    }

	void DateSelectedXaml(object? sender, DateChangedEventArgs e)
	{
		if (labelXaml is { })
			labelXaml.Text = $"¬ы выбрали {e.NewDate.ToString("d")}";
    }
}