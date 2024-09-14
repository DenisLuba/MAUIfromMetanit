
namespace MetanitLessons;

/** Stepper
 * ��������:

Increment: ��� ���������� �� ������ �������� � �������, �� ��������� ����� 1.

Minimum: ����������� �������� ���������, �� ��������� ����� 0.

Maximum: ������������ �������� ���������, �� ��������� ����� 100.

Value: ������� �������� ��������, ����� ���������� � ��������� �� Minimum �� Maximum, 
	�� ��������� ����� 0.

 * ������� ValueChanged ������������ ������ ��� ��� ��������� �������� �������� Value. 
 * � �������� ��������� ��� ��������� ������ ValueChangedEventArgs, ������� ����� ��� ��������: 
 * OldValue (������ ��������) � NewValue (����� ��������). ��� ���� �������� �������� NewValue 
 * ������������ �������� �������� Value ������� Stepper.
 */

public partial class StepperPage : ContentPage
{
	Label header;

	public StepperPage()
	{
		header = new Label { FontSize = 18, Margin = 5 };

		Stepper stepper = new Stepper
		{
			Minimum = 0,
			Maximum = 10,
			Increment = 0.1,
			VerticalOptions = LayoutOptions.Start
		};
        stepper.ValueChanged += OnStepperValueChanged;
		Content = new StackLayout { Children = { stepper, header }, Orientation = StackOrientation.Horizontal };

		InitializeComponent();
	}

    void OnStepperValueChanged(object? sender, ValueChangedEventArgs e)
    {
        header.Text = $"�������: {e.NewValue}";
    }

	void OnStepperValueChangedXml(object? sender, ValueChangedEventArgs e)
	{
		label.Text = $"�������: {e.NewValue}";
	}
}