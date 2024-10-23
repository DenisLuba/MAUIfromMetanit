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

// Действие, которое будет вызываться триггером, представляет класс TriggerAction<T>,
// <T> - элемент, к которому применяется действие
public class EntryValidation : TriggerAction<Entry>
{
	protected override void Invoke(Entry sender)
	{
		// TryParse(string?, out int) возвращает bool
		if (!int.TryParse(sender.Text, out var number))
			sender.TextColor = Colors.Red;
		else
			sender.TextColor = Colors.Green;
	}
}