using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName
using System.Windows.Input; // ICommand

namespace MetanitLessons.Maui.MVVM;

public partial class MultipleViewModelsPage : ContentPage
{
	public MultipleViewModelsPage()
	{
		InitializeComponent();
		// определяем контекст привязки
		BindingContext = new MainMultipleViewModel();
	}
}

// MODEL - класс данных
public class Fellow(string name, int age)
{
	public string Name { get; set; } = name;
	public int Age { get; set; } = age;
}

// VIEW MODEL for changes in Fellow
public class DisplayMultipleViewModel : INotifyPropertyChanged
{
	Fellow fellow;
	public event PropertyChangedEventHandler? PropertyChanged;

	public DisplayMultipleViewModel(Fellow fellow) => this.fellow = fellow;

	public string Name
	{
		get => fellow.Name;

		set
		{
			if (fellow.Name != value)
			{
				fellow.Name = value;
				OnPropertyChanged();
			}
		}
	}

	public int Age
	{
		get => fellow.Age;

		set
		{
			if (fellow.Age != value)
			{
				fellow.Age = value;
				OnPropertyChanged();
			}
		}
	}

	private void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}

// VIEW MODEL FOR changes in fields Name and Age
public class EditMultipleViewModel : INotifyPropertyChanged
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
			if(age != value)
			{
				age = value;
				OnPropertyChanged();
			}
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}

// VIEW MODEL общий
public class MainMultipleViewModel 
{
	public ICommand SaveCommand { get; set; }
	public ICommand EditCommand { get; set; }

	public DisplayMultipleViewModel MyFellow { get; set; }
	public EditMultipleViewModel EditData { get; set; }

	public MainMultipleViewModel()
	{
		MyFellow = new DisplayMultipleViewModel(new Fellow("Tom", 38));
		EditData = new EditMultipleViewModel();

		SaveCommand = new Command(() =>
		{
			MyFellow.Name = EditData.Name;
			MyFellow.Age = EditData.Age;
			EditData.Name = "";
			EditData.Age = 0;
		});

		EditCommand = new Command(() =>
		{
			EditData.Name = MyFellow.Name;
			EditData.Age = MyFellow.Age;
		});
	}
}