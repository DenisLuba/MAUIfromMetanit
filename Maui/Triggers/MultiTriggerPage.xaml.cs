namespace MetanitLessons.Maui.Triggers;

/* �� �������� ����� ��� , ������ ����� XAML */

public partial class MultiTriggerPage : ContentPage
{
	public MultiTriggerPage()
	{
		var emailCS = new Entry { Text = "", Margin = 10, Keyboard = Keyboard.Email };
		var phoneCS = new Entry { Text = "", Margin = 10, Keyboard = Keyboard.Telephone };

		var buttonCS = new Button
		{
			BackgroundColor = Color.FromArgb("#FFF"),
			TextColor = Color.FromArgb("#01579B"),
			Text = "Save",
			Margin = 10,
			Shadow = new Shadow
			{
				Brush = Brush.LightGray,
				Offset = new Point(20, 20),
				Opacity = 0.8f
			}
		}; 
		// ���������� ������������� ������
		MultiTrigger multiTrigger = new MultiTrigger(typeof(Button));
		// ��������� ������� ��������
		multiTrigger.Conditions.Add(new BindingCondition { Binding = new Binding { Source = emailCS, Path = "Text" }, Value = "a" });
		multiTrigger.Conditions.Add(new BindingCondition { Binding = new Binding { Source = phoneCS, Path = "Text.Length" }, Value = 0 });
		// ��������� ����� ��������
		multiTrigger.Setters.Add(new Setter { Property = Button.BackgroundColorProperty, Value = Colors.LightGray });
		multiTrigger.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Colors.Gray });
		multiTrigger.Setters.Add(new Setter { Property = Button.IsEnabledProperty, Value = false });
		// ��������� ������� � ������
		buttonCS.Triggers.Add(multiTrigger);

		Content = new StackLayout
		{
			Padding = 10,
			Children = { emailCS, phoneCS, buttonCS }
		};

		//InitializeComponent();
	}
}