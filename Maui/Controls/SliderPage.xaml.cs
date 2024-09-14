
namespace MetanitLessons;

/** Slider
 * —войства:

Minimum: минимальное значение ползунка, представл€ет тип double, значение по умолчанию - 0

Maximum: максимальное значение ползунка, представл€ет тип double, значение по умолчанию - 1

Value: текущее значение ползунка, представл€ет тип double, значение по умолчанию - 0

ThumbColor: цвет указател€ текущего значени€, представл€ет тип Color

MinimumTrackColor: цвет ползунка до указател€ значени€, представл€ет тип Color

MaximumTrackColor: цвет ползунка после указател€ значени€, представл€ет тип Color

 * Slider дл€ отслеживани€ изменен€ значени€ определ€ет событие ValueChanged, 
 * которое генерируетс€ каждый раз при изменении значени€ свойства Value 
 * (в том числе при изменении программным образом). ¬ качестве параметра оно принимает 
 * объект ValueChangedEventArgs, который имеет два свойства: OldValue (старое значение) 
 * и NewValue (новое значение). ѕри этом значение свойства NewValue эквивалентно 
 * значению свойства Value объекта Stepper.
 * 
 * ¬ дополнение дл€ отслеживани€ перемщени€ позунка класс Slider определ€ет событи€
 * DragStarted (возникает, когда пользователь начинает перемещать ползунок) и 
 * DragCompleted (возникает, когда пользователь завершает перемещать ползунок).
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
		header.Text = $"¬ыбрано: {e.NewValue:F1}";
    }

    void OnSliderValueChangedXaml(object? sender, ValueChangedEventArgs e)
	{
		label.Text = $"¬ыбрано: {e.NewValue:F1}";
	}
}