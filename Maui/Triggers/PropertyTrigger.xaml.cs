namespace MetanitLessons.Maui.Triggers;

public partial class PropertyTrigger : ContentPage
{
	public PropertyTrigger()
	{
		Entry entry = new Entry { Text = "Hello World", TextColor = Colors.LightGray };

		// ���������� ������� ��� �������� Entry
		var trigger = new Trigger(typeof(Entry))
		{
			Property = IsFocusedProperty,
			Value = true
		};
		// ��������� ������ ��� ��������� ������� �����
		trigger.Setters.Add(new Setter
		{
			Property = Entry.TextColorProperty,
			Value = Colors.Black
		});
		// ��������� ������� � ��������� ��������� Entry
		entry.Triggers.Add(trigger);

		Content = new StackLayout
		{
			Padding = 20,
			Children = { entry }
		};

		//InitializeComponent();
	}
}