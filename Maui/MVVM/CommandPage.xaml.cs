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
		// �������� � ViewModel
		BindingContext = new MainViewModel();
	}
}

// MODEL - ����� ������
public record User(string Name, int Age);

// VIEW MODEL
public class MainViewModel : INotifyPropertyChanged
{
	string name = "";
	int age;
	public event PropertyChangedEventHandler? PropertyChanged;
	// ICommand ����� ��� �������������� � �������������
	/*
		
		public interface ICommand
		{
			void Execute(object? args); -	��������� �������
			bool CanExecute(object? arg); - ����� �� ������� ���� ���������
			event EventHandler? CanExecuteChanged; - ������������ ��� ����������, ������� ����� �������� �� ���������� �������
		}

	 */
	public ICommand AddCommand { get; set; }
	// ��������� "��������������" ���������
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
		// ������������� ������� ����������
		AddCommand = new Command(() =>
		{
			Users.Add(new User(Name, Age));
			Name = "";
			Age = 0;
		});
		// ����� Command - ���������� ICommand, ������� �������� � .NET MAUI
		/*
		public Command(Action execute)

		������� Action ������������ ����������� �������� �������� - ���������� ������ Execute()
		 */
	}

	// ���������� ��� ��������� ��������� (��� ��������� Name ��� Age)
	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}