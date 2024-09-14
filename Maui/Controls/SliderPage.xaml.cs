
namespace MetanitLessons;

/** Slider
 * ��������:

Minimum: ����������� �������� ��������, ������������ ��� double, �������� �� ��������� - 0

Maximum: ������������ �������� ��������, ������������ ��� double, �������� �� ��������� - 1

Value: ������� �������� ��������, ������������ ��� double, �������� �� ��������� - 0

ThumbColor: ���� ��������� �������� ��������, ������������ ��� Color

MinimumTrackColor: ���� �������� �� ��������� ��������, ������������ ��� Color

MaximumTrackColor: ���� �������� ����� ��������� ��������, ������������ ��� Color

 * Slider ��� ������������ �������� �������� ���������� ������� ValueChanged, 
 * ������� ������������ ������ ��� ��� ��������� �������� �������� Value 
 * (� ��� ����� ��� ��������� ����������� �������). � �������� ��������� ��� ��������� 
 * ������ ValueChangedEventArgs, ������� ����� ��� ��������: OldValue (������ ��������) 
 * � NewValue (����� ��������). ��� ���� �������� �������� NewValue ������������ 
 * �������� �������� Value ������� Stepper.
 * 
 * � ���������� ��� ������������ ���������� ������� ����� Slider ���������� �������
 * DragStarted (���������, ����� ������������ �������� ���������� ��������) � 
 * DragCompleted (���������, ����� ������������ ��������� ���������� ��������).
*/

public partial class SliderPage : ContentPage
{
	Label header;

	public SliderPage()
	{
		header = new Label { FontSize = 18, Margin = 8 };

		Slider slider = new Slider
		{
			Maximum = 50,
			Minimum = 0,
			Value = 30,
			ThumbColor = Colors.DeepPink,
			MinimumTrackColor = Colors.DeepPink,
			MaximumTrackColor = Colors.LightPink
		};
		slider.ValueChanged += OnSliderValueChanged;
		Content = new StackLayout { Children = { header, slider }, Padding = 20 };

		InitializeComponent();
	}

    void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
		header.Text = $"�������: {e.NewValue:F1}";
    }

    void OnSliderValueChangedXaml(object? sender, ValueChangedEventArgs e)
	{
		label.Text = $"�������: {e.NewValue:F1}";
	}
}