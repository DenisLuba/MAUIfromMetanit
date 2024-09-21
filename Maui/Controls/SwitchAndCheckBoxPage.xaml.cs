
namespace MetanitLessons;

/** Switch
 * Свойства:

IsToggled: указывает, находится ли Switch во включенном состоянии (значение true) 
	или выключенном (значение false)

ThumbColor: цвет кнопки переключателя

OnColor: цвет переключателя во включенном состоянии

 * Для отслеживания изменения состояния элемента Switch класс определяет событие Toggled. 
 * Его параметр ToggledEventArgs с помощью свойства Value позволяет получить новое состояние - 
 * новое значения свойства IsToggled.
 
 * 
 * CheckBox
 * Свойства:

IsChecked: указывает, находится ли флажок в отмеченном состоянии (значение true) 
	или неотмеченном (значение false)

Color: цвет флажка

 * Для отслеживания изменения состояния флажка класс Checkbox определяет событие CheckedChanged. 
 * Его параметр CheckedChangedEventArgs с помощью свойства Value позволяет получить новое состояние 
 * - новое значение свойства IsChecked.
 */

public partial class SwitchAndCheckBoxPage : ContentPage
{
	Label labelCS;
	Label statusLabelCS;

	public SwitchAndCheckBoxPage()
	{
		Switch switcher = new Switch
		{
			IsToggled = true,
			HorizontalOptions = LayoutOptions.Start
		};

		switcher.Toggled += Switcher_Toggled;
		labelCS = new Label
		{
			FontSize = 16,
			Text = $"Значение = {switcher.IsToggled}"
		};

		/****************************************/

		CheckBox statusCheckBox = new CheckBox { IsChecked = false };
		statusCheckBox.CheckedChanged += StatusCheckBox_CheckedChanged;
		Label statusHeaderLabel = new Label { FontSize = 16, Text = "женат/замужем", Margin = 4 };
		HorizontalStackLayout checkBoxStack = new HorizontalStackLayout
		{
			statusCheckBox, statusHeaderLabel
		};
		statusLabelCS = new Label
		{
			FontSize = 18,
			Text = "Статус: холост/не замужем"
		};

		Content = new StackLayout { Children = { switcher, labelCS, new BoxView { HeightRequest = 30, BackgroundColor = Colors.Transparent }, statusLabelCS, checkBoxStack }, Padding = 8 };

		InitializeComponent();
	}

	private void Switcher_Toggled(object? sender, ToggledEventArgs e)
	{
		labelCS.Text = $"Значение = {e.Value}";
	}

	void Switcher_Toggled_xaml(object? sender, ToggledEventArgs e)
	{
		labelXaml.Text = $"Значение = {e.Value}";
	}

	void StatusCheckBox_CheckedChanged(object? sender, CheckedChangedEventArgs e)
	{
		statusLabelCS.Text = $"Статус: {(e.Value ? "женат/замужем" : "холост/не замужем")}";
	}

	void StatusCheckBox_CheckedChanged_xaml(object? sender, CheckedChangedEventArgs e)
	{
		statusLabelXaml.Text = $"Статус: {(e.Value ? "женат/замужем" : "холост/не замужем")}";
	}
}