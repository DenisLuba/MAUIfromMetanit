
namespace MetanitLessons;

/** Stepper
 * —войства:

Increment: шаг увеличени€ от одного значени€ к другому, по умолчанию равно 1.

Minimum: минимальное значение диапазона, по умолчанию равно 0.

Maximum: максимальное значение диапазона, по умолчанию равно 100.

Value: текущее значение элемента, может находитьс€ в диапазоне от Minimum до Maximum, 
	по умолчанию равно 0.

 * —обытие ValueChanged генерируетс€ каждый раз при изменении занчени€ свойства Value. 
 * ¬ качестве параметра оно принимает объект ValueChangedEventArgs, который имеет два свойства: 
 * OldValue (старое значение) и NewValue (новое значение). ѕри этом значение свойства NewValue 
 * эквивалентно значению свойства Value объекта Stepper.
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
        header.Text = $"¬ыбрано: {e.NewValue}";
    }

	void OnStepperValueChangedXml(object? sender, ValueChangedEventArgs e)
	{
		label.Text = $"¬ыбрано: {e.NewValue}";
	}
}