using System.Collections.ObjectModel; // ObservableCollection
using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName
using System.Windows.Input; // ICommand

namespace MetanitLessons.Maui.MVVM;

public partial class DisableCommandPage : ContentPage
{
	public DisableCommandPage()
	{
		InitializeComponent();
		// ������������� �������� ��������
		BindingContext = new DisableCommandViewModel();
	}
}

// MODEL - ����� ������
public record Human(string Name, int Age);

// VIEW MODEL 
public class DisableCommandViewModel : INotifyPropertyChanged
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
	public ObservableCollection<Human> Humans { get; } = new();

	public DisableCommandViewModel()
	{
		// ������������� ������� ����������
		AddCommand = new Command(
			() => // ������� Execute() - ���� �������
			{
				Humans.Add(new Human(Name, Age));
				Name = "";
				Age = 0;
			},
			() => // ������� CanExecute() - ����� �� ��������� �������
			{
				return Age > 0 && Age < 110 && Name.Length > 2;
			});
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		((Command)AddCommand).ChangeCanExecute();
		// �� ���� ����� �������� ����� ���������� �������� ������� Name � Age,
		// �������, ����� ������ � ���� ���������� ����������� ���������� �������,
		// �������� ������������ � Command ����� ChangeCanExecute()
	}
}