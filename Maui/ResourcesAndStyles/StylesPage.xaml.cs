namespace MetanitLessons.Maui.ResourcesAndStyles;

public partial class StylesPage : ContentPage
{
	public StylesPage()
	{
		Style buttonStyle = new Style(typeof(Button))
		{
			Setters =
			{
				new Setter
				{
					// в названии свойств, как правило, есть слово Property
					Property = Button.TextColorProperty,
					Value = Color.FromArgb("#004D40")
				},
				new Setter
	{
					Property = Button.BackgroundColorProperty,
					Value = Color.FromArgb("#80CBC4")
	},
				new Setter
				{
					Property = Button.MarginProperty,
					Value = 12
				}
			}
		};

		// Можно наследовать стили
		Style childStyle = new Style(typeof(Button))
		{
			BasedOn = buttonStyle,
			Setters =
			{
				new Setter
				{
					Property = Button.WidthRequestProperty,
					Value = 150
				}
			}
		};

		Button buttonIOS = new Button { Text = "iOS", Style = buttonStyle };
		Button buttonAndroid = new Button { Text = "Android", Style = childStyle };

		Content = new StackLayout
		{
			Padding = 20,
			Children = { buttonIOS, buttonAndroid }
		};

		//InitializeComponent();
	}
}