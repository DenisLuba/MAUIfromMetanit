using System.Collections.ObjectModel;

namespace MetanitLessons.Maui.ListViews;

public partial class ObservableCollectionXamlPage : ContentPage
{
	public ObservableCollection<User> Users { get; set; }

	public ObservableCollectionXamlPage()
	{
		InitializeComponent();

		Users = new ObservableCollection<User>
		{
			new User { Name = "Tom", Age = 38 },
			new User { Name = "Bob", Age = 42 }
		};
		// привязка к текущему объекту
		BindingContext = this;
	}

	private void SaveButtonClickedXaml(object sender, EventArgs e)
	{
		int.TryParse(ageEntryXaml.Text, out int age);
		Users.Add(new User { Name = nameEntryXaml.Text, Age = age });
		nameEntryXaml.Text = ageEntryXaml.Text = "";
	}

	public class User
	{
		public string Name { get; set; } = "";
		public int Age { get; set; }
	}
}