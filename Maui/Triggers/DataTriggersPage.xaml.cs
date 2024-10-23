using System.ComponentModel;

namespace MetanitLessons.Maui.Triggers;

public partial class DataTriggersPage : ContentPage
{
	public DataTriggersPage()
	{
		var entryCS = new Entry { Text = "", Margin = 10, TextColor = Colors.Green };

		var entryColorTrigger = new DataTrigger(typeof(Entry))
		{
			Binding = new Binding { Source = entryCS, Path = nameof(Entry.Text) },
			Value = "admin"
		};
		var entryColorSetter = new Setter
		{
			Property = Entry.TextColorProperty,
			Value = Colors.Red
		};
		entryColorTrigger.Setters.Add(entryColorSetter);
		entryCS.Triggers.Add(entryColorTrigger);


		var buttonCS = new Button 
		{ 
			Text = "Save", 
			Margin = 10, 
			TextColor = Color.FromArgb("#01579B"),
			BackgroundColor = Color.FromArgb("#FFF")
		};
		var buttonTrigger = new DataTrigger(typeof(Button))
		{
			Binding = new Binding { Source = entryCS, Path = "Text.Length" },
			Value = 0
		};
		buttonTrigger.Setters.Add(new Setter { Property = Button.IsEnabledProperty, Value = false });
		buttonTrigger.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Colors.Gray });
		buttonTrigger.Setters.Add(new Setter { Property = Button.BackgroundColorProperty, Value = Colors.LightGray });
		buttonCS.Triggers.Add(buttonTrigger);

		Content = new StackLayout
		{
			Padding = 10,
			Children = { entryCS, buttonCS }
		};



		InitializeComponent();
	}
}

public class Person : INotifyPropertyChanged
{
	string name = "";

	public event PropertyChangedEventHandler? PropertyChanged;

	public string Name
	{
		get => name;
		set
		{
			if (name != value)
			{
				name = value;
				OnPropertyChanged("Name");
			}
		}
	}

	public void OnPropertyChanged(string property = "")
	{
		if (PropertyChanged != null)
			PropertyChanged(this, new PropertyChangedEventArgs(property));
	}
}