using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MetanitLessons.Maui.MVVM;


public partial class MVVMbasePage : ContentPage
{
	public MVVMbasePage()
	{
		InitializeComponent();
		// привязка к ViewModel
		BindingContext = new PersonViewModel();
	}
}

// MODEL - класс данных
public class Person
{
	public string Name { get; set; } = "";
	public int Age { get; set; }
}

// VIEW MODEL
// как правило, одна страница (View) связана с одной ViewModel, 
// но одну и ту же VıewModel могут использовать несколько представлений (View)
public class PersonViewModel : INotifyPropertyChanged
{
	Person person = new Person { Name = "Tom", Age = 38 };
	public event PropertyChangedEventHandler? PropertyChanged;

	public string Name
	{
		get => person.Name;

		set
		{
			if (person.Name != value)
			{
				person.Name = value;
				OnPropertyChanged();
			}
		}
	}

	public int Age
	{
		get => person.Age;

		set
		{
			if (person.Age != value)
			{
				person.Age = value;
				OnPropertyChanged();
			}
		}
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}