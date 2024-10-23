namespace MetanitLessons.Maui.Triggers;

public partial class EventTriggerPage : ContentPage
{
	public EventTriggerPage()
	{

		var trigger = new EventTrigger { Event = "TextChanged" };
		trigger.Actions.Add(new EntryValidation());

		Entry entry = new Entry();
		entry.Triggers.Add(trigger);

		Content = new StackLayout
		{
			Children = { entry }
		};

		//InitializeComponent();
	}
}

// ��������, ������� ����� ���������� ���������, ������������ ����� TriggerAction<T>,
// <T> - �������, � �������� ����������� ��������
public class EntryValidation : TriggerAction<Entry>
{
	protected override void Invoke(Entry sender)
	{
		// TryParse(string?, out int) ���������� bool
		if (!int.TryParse(sender.Text, out var number))
			sender.TextColor = Colors.Red;
		else
			sender.TextColor = Colors.Green;
	}
}