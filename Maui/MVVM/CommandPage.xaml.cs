using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MetanitLessons.Maui.MVVM;

public partial class CommandPage : ContentPage
{
	public CommandPage()
	{
		InitializeComponent();
		// привязка к ViewModel
		BindingContext = new MainViewModel();
	}
}

// MODEL - класс данных
public record User(string Name, int Age);

// VIEW MODEL
public class MainViewModel : INotifyPropertyChanged
{
	string name = "";
	int age;
	public event PropertyChangedEventHandler? PropertyChanged;
	// ICommand нужен для взаимодействия с пользователем
	public ICommand AddCommand { get; set; }
	// коллекция "прослушивающая" изменения
	public ObservableCollection<User> Users { get; } = new();

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

	public MainViewModel()
	{
		// устанавливаем команду добавления
		AddCommand = new Command(() =>
		{
			Users.Add(new User(Name, Age));
			Name = "";
			Age = 0;
		});
		// класс Command - реализация ICommand, которая включена в .NET MAUI
		/*
		public Command(Action execute)

		Делегат Action представляет выполняемое командой действие
		 */
	}

	// вызывается при изменении состояния (при изменении Name или Age)
	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}