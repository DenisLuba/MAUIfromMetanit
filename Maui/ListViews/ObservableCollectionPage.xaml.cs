using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace MetanitLessons.Maui.ListViews;

public partial class ObservableCollectionPage : ContentPage
{
	public ObservableCollection<User> Users { get; set; }
	Entry nameEntry, ageEntry;

	public ObservableCollectionPage()
	{
		// ���������� ������
		Users = new ObservableCollection<User>
		{
			new User { Name = "Tom", Age = 28 },
			new User { Name = "Bob", Age = 42 }
		};

		ListView listViewCS = new ListView();
		// ���������� �������� ������
		listViewCS.ItemsSource = Users;
		// ���������� ������ ������
		listViewCS.ItemTemplate = new DataTemplate(() =>
		{
			// �������� � �������� Name
			Label nameLabel = new Label { FontSize = 16 };
			nameLabel.SetBinding(Label.TextProperty, nameof(User.Name));

			// �������� � �������� Age
			Label ageLabel = new Label { FontSize = 14 };
			ageLabel.SetBinding(Label.TextProperty, nameof(User.Age));

			// ������� ������ ViewCell
			return new ViewCell
			{
				View = new StackLayout
				{
					Padding = new Thickness(0, 5),
					Orientation = StackOrientation.Vertical,
					Children = { nameLabel, ageLabel }
				}
			};
		});

		// ���� ��� ���������� ������ ������� User
		nameEntry = new Entry { Placeholder = "Enter name", Margin = 5 };
		ageEntry = new Entry { Placeholder = "Enter age", Margin = 5 };
		Button saveButton = new Button { Text = "Save", WidthRequest = 100, Margin = 5, HorizontalOptions = LayoutOptions.Start };
		saveButton.Clicked += SaveButtonClicked;
		StackLayout form = new StackLayout
		{
			Orientation = StackOrientation.Vertical,
			Children = { nameEntry, ageEntry, saveButton }
		};

		Content = new StackLayout { Children = { form, listViewCS }, Padding = 7 };
	}

	private void SaveButtonClicked(object sender, EventArgs e)
	{
		int.TryParse(ageEntry.Text, out var age);
		Users.Add(new User { Name = nameEntry.Text, Age = age });
		nameEntry.Text = ageEntry.Text = "";
	}

	public class User
	{
		public string Name { get; set; } = "";
		public int Age { get; set; }
	}
}