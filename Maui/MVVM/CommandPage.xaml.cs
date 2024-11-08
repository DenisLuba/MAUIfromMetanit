using System.Collections.ObjectModel; // ObservableCollection
using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName
using System.Windows.Input; // ICommand

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
	/*
		
		public interface ICommand
		{
			void Execute(object? args); -	выполняет команду
			bool CanExecute(object? arg); - может ли команда быть выполнена
			event EventHandler? CanExecuteChanged; - генерируется при изменениях, которые могут повлиять на выполнение команды
		}

	 */
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

		Делегат Action представляет выполняемое командой действие - реализация метода Execute()
		 */
	}

	// вызывается при изменении состояния (при изменении Name или Age)
	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}