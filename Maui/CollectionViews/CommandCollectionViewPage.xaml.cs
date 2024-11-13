using System.Windows.Input;

namespace MetanitLessons.Maui.CollectionViews;

public partial class CommandCollectionViewPage : ContentPage
{
	public ICommand SelectCommand { get; set; }

	public CommandCollectionViewPage()
	{
		InitializeComponent();

		SelectCommand = new Command<User?>(UserCommand);
		/*
		 * установка команды в коде C#:
		 
		collectionView.SetBinding(CollectionView.SelectionChangedCommandParameterProperty, new Binding("SelectedItem", source: RelativeBindingSource.Self));
		*/
		BindingContext = this;
	}

	void UserCommand(User? p)
	{
		selectedLabel.Text = $"Selected: {p?.Name}";
	}
}