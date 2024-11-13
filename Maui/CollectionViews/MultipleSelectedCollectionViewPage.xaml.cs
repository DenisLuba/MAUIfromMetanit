using System.Windows.Input;

namespace MetanitLessons.Maui.CollectionViews;

public partial class MultipleSelectedCollectionViewPage : ContentPage
{
	public ICommand SelectCommand { get; set; }

	public MultipleSelectedCollectionViewPage()
	{
		InitializeComponent();

		SelectCommand = new Command<IList<object>>(UsersCommand);

		BindingContext = this;
	}

	void UsersCommand(IList<object> users)
	{
		string text = "Selected: ";

		foreach (var u in users)
		{
			if (u is User user)
				text = $"{text} {user.Name},";
		}

		multipleSelectedLabel.Text = text;
	}
}