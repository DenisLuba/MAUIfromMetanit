using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName

namespace MetanitLessons.Maui.Navigation.NavigationForResult;

public class Person : INotifyPropertyChanged
{
	string name = "";
	int age;

	public event PropertyChangedEventHandler? PropertyChanged;

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

	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}
