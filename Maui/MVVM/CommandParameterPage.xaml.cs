using System.Collections.ObjectModel; // ObservableCollection
using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName
using System.Windows.Input; // ICommand

namespace MetanitLessons.Maui.MVVM;

public partial class CommandParameterPage : ContentPage
{
	public CommandParameterPage()
	{
		InitializeComponent();
		// устанавливаем контекст привязки
		BindingContext = new CommandParameterViewModel();
	}
}

// MODEL - класс данных
public record Employee(string Name, int Age);

// MODEL VIEW
public class CommandParameterViewModel : INotifyPropertyChanged
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
	public ICommand AddCommand { get; set; } 
	public ICommand RemoveCommand { get; set; }
	public ObservableCollection<Employee> Employees { get; } = new();

	public CommandParameterViewModel()
	{
		// устанавливаем команду добавления
		AddCommand = new Command(() =>
		{
			Employees.Add(new Employee(Name, Age));
			Name = "";
			Age = 0;
		});
		// устанавливаем команду удаления
		//RemoveCommand = new Command((object? arg) =>
		//{
		//	if (arg is Employee employee) Employees.Remove(employee);
		//});
		RemoveCommand = new Command<Employee>((Employee employee) =>
		{
			Employees.Remove(employee);
		});
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}