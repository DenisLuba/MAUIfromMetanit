namespace MetanitLessons.Maui.Bindings;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public partial class INotifyPropertyChangedPage : ContentPage
{
	public INotifyPropertyChangedPage()
	{
		Person tom = new Person { Name = "Tom", Age = 38 };
		Label nameHeaderLabel = new Label { Text = "Name" };
		Label ageHeaderLabel = new Label { Text = "Age" };
		Label nameValueLabel = new Label { FontAttributes = FontAttributes.Bold };
		Label ageValueLabel = new Label { FontAttributes = FontAttributes.Bold };

		Binding nameBinding = new Binding { Source = tom, Path = nameof(tom.Name) };
		Binding ageBinding = new Binding { Source = tom, Path = nameof(tom.Age) };

		nameValueLabel.SetBinding(Label.TextProperty, nameBinding);
		ageValueLabel.SetBinding(Label.TextProperty, ageBinding);

		Button button = new Button { Text = "+", WidthRequest = 60, HorizontalOptions = LayoutOptions.Start };
		Label testLabel = new Label();
		// по нажатию увеличиваем возраст на 1
		button.Clicked += (o, e) =>
		{
			tom.Age++;
			testLabel.Text = tom.Age.ToString();
		};

		Content = new StackLayout
		{
			Children = 
			{ 
				nameHeaderLabel, 
				nameValueLabel, 
				ageHeaderLabel, 
				ageValueLabel, 
				button, 
				testLabel 
			},
			
			Padding = 20
		};

		InitializeComponent();
	}

	private void UpdateAge(object sender, EventArgs e)
	{
		var person = Resources["person"] as Person;
		if (person is not null) person.Age++;
	}
}

// В качестве цели привязки должен выступать объект-наследник от класса BindableObject.
// Если источник привязки не является объектом класса-наследника от BindableObject,
// то он должен наследоваться от INotityPropertyChanged
public class Person : INotifyPropertyChanged
{
	string name = "";
	int age;

	public string Name
	{
		get => name;
		set
		{
			if (name != value)
			{
				name = value;
				OnPropertyChanged();
			}
		}
	}

	public int Age
	{
		get => age;
		set
		{
			if (age != value)
			{
				age = value;
				OnPropertyChanged();
			}
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	//	delegate void System.ComponentModel.PropertyChangedEventHandler(
	//				object sender, 
	//				System.ComponentModel.PropertyChangedEventArgs e)

	public void OnPropertyChanged([CallerMemberName] string property = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
	//	PropertyChangedEventArgs(strng? propertyName)
	}

}