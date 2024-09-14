using System.ComponentModel;

namespace MetanitLessons;

/**
 * TimePicker
 * —войства:

Time: выбранное врем€, представл€ет структуру TimeSpan и по умолчанию равно 0

Format: определ€ет формат даты, принимает стандартные дл€ .NET форматы .
	ѕо умолчанию равен "t" - сокращенна€ запись времени

 * ƒл€ обработки выбора можно использовать событие PropertyChanged.
 */

public partial class TimePickerPage : ContentPage
{
	Label label;
	TimePicker timePicker;

	public TimePickerPage()
	{
		label = new Label { Text = "¬ыберите врем€", FontSize = 20 };
		timePicker = new TimePicker { Time = new TimeSpan(17, 0, 0) };
		timePicker.PropertyChanged += TimePickerPropertyChanged;
		
		StackLayout stackLayout = new StackLayout { Children = { label, timePicker }, Padding = 20 };
		Content = stackLayout;

		InitializeComponent();
	}

    void TimePickerPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Time")
			label.Text = $"¬ы выбрали {timePicker.Time}";
    }

    void TimePickerPropertyChangedXaml(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Time")
            labelXaml.Text = $"¬ы выбрали {timePickerXaml.Time}";
    }
}