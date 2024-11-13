using System.Collections.ObjectModel; // ObservableCollection
using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName

namespace MetanitLessons.Maui.CollectionViews;

public partial class SelectedItemViewModelCollectionViewPage : ContentPage
{
	public SelectedItemViewModelCollectionViewPage()
	{
		InitializeComponent();
		BindingContext = new ViewModel();
	}
}


public class ViewModel: INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	User? selectedUser;

	public User? SelectedUser
	{
		get => selectedUser;
		set
		{
			if (selectedUser != value)
			{
				selectedUser = value;
				OnPropertyChanged();
			}
		}
	}

	public ObservableCollection<User> Users { get; }  

	public ViewModel()
	{
		Users = new ObservableCollection<User>
		{
			new  User { Name="Tom", Age=38, Company ="Microsoft" },
			new  User { Name="Sam", Age=25,  Company ="Google" },
			new  User { Name="Bob", Age=42,  Company ="JetBrains" },
			new  User { Name="Alice", Age=33,  Company ="Microsoft" },
			new  User { Name="Kate", Age=29,  Company ="Google" },
			new  User { Name="Amelia", Age=35,  Company ="JetBrains" }
		};

		SelectedUser = Users[1];
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}