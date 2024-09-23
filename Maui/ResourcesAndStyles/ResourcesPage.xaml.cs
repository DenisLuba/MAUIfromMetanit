namespace MetanitLessons.Maui.ResourcesAndStyles;

public partial class ResourcesPage : ContentPage
{
	static string textColorKey = "textColor", backColorKey = "backColor", marginKey = "margin";
	static string hexColor1 = "#FEFAE0", hexColor2 = "#BC6C25";
	static string dynamicTextColorKey = "dynamicTextColor", dynamicBackColorKey = "dynamicBackColor";

	public ResourcesPage()
	{
		Color textColor = Color.FromArgb("#004D40");
		Color backColor = Color.FromArgb("#80CBC4");
		int margin = 10;

		// определяем словарь ресурсов
		ResourceDictionary resourceDictionary = new ResourceDictionary
		// добавляем ресурсы в словарь
		{
			{ textColorKey, textColor },
			{ backColorKey, backColor },
			{ marginKey, margin },
			{ dynamicTextColorKey, Color.FromArgb(hexColor1) },
			{ dynamicBackColorKey, Color.FromArgb(hexColor2) }
		};

		// или так
		//var resourceDictionary = new ResourceDictionary();
		//resourceDictionary.Add(textColorKey, textColor);
		//resourceDictionary.Add(backColorKey, backColor);
		//resourceDictionary.Add(marginKey, margin);

		// а удаление элемента:
		// resourceDictionary.Remove(textColorKey);

		// устанавливаем словарь ресурсов для текущей страницы
		Resources = resourceDictionary;

		Button iosButton = new Button { Text = "iOS" };
		// получаем ресурс из словаря
		iosButton.TextColor = Resources[textColorKey] as Color;
		iosButton.BackgroundColor = (Color) Resources[backColorKey];
		iosButton.Margin = (int) Resources[marginKey];

		Button androidButton = new Button
		{
			Text = "Android",
			TextColor = Resources[textColorKey] as Color,
			BackgroundColor = (Color)Resources[backColorKey],
			Margin = (int)Resources[marginKey]
		};

		// цвет этой кнопки будем изменять динамически
		Button winButton = new Button
		{
			Text = "Windows",
			WidthRequest = 120
		};
		// устанавливаем динамические ресурсы
		winButton.SetDynamicResource(Button.TextColorProperty, dynamicTextColorKey);
		winButton.SetDynamicResource(Button.BackgroundColorProperty, dynamicBackColorKey);
		winButton.Clicked += WinButtonColorChange;

		Content = new StackLayout
		{
			Padding = 10,
			Children = { iosButton, androidButton, winButton }
		};

		//InitializeComponent();
	}



	void WinButtonColorChange(object? sender, EventArgs e)
	{
		if (Resources[dynamicTextColorKey] is Color buttonTextColor
			&& Resources[dynamicBackColorKey] is Color buttonBackColor)
		{
			//Resources[dynamicTextColorKey] = buttonTextColor.ToHex() == hexColor1
			//	? Color.FromArgb(hexColor2)
			//	: Color.FromArgb(hexColor1);

			//Resources[dynamicBackColorKey] = buttonBackColor.ToHex() == hexColor2
			//	? Color.FromArgb(hexColor1)
			//	: Color.FromArgb(hexColor2);

			(Resources[dynamicTextColorKey], Resources[dynamicBackColorKey]) = (Resources[dynamicBackColorKey], Resources[dynamicTextColorKey]);
		}
	}

	void ColorChange(object? sender, EventArgs e)
	{
        if (Resources["button4BackColor"] is Color color)
        {
			Resources["button4BackColor"] = color.ToHex() == hexColor1
				? Color.FromArgb(hexColor2)
				: Color.FromArgb(hexColor1);
        }
	}
}