using System.ComponentModel;

namespace MetanitLessons;

/**
 * TimePicker
 * ��������:

Time: ��������� �����, ������������ ��������� TimeSpan � �� ��������� ����� 0

Format: ���������� ������ ����, ��������� ����������� ��� .NET ������� .
	�� ��������� ����� "t" - ����������� ������ �������

 * ��� ��������� ������ ����� ������������ ������� PropertyChanged.
 */

public partial class TimePickerPage : ContentPage
{
	Label label;
	TimePicker timePicker;

	public TimePickerPage()
	{
		label = new Label { Text = "�������� �����", FontSize = 20 };
		timePicker = new TimePicker { Time = new TimeSpan(17, 0, 0) };
		timePicker.PropertyChanged += TimePickerPropertyChanged;
		
		StackLayout stackLayout = new StackLayout { Children = { label, timePicker }, Padding = 20 };
		Content = stackLayout;

		InitializeComponent();
	}

    void TimePickerPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Time")
			label.Text = $"�� ������� {timePicker.Time}";
    }

    void TimePickerPropertyChangedXaml(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Time")
            labelXaml.Text = $"�� ������� {timePickerXaml.Time}";
    }
}