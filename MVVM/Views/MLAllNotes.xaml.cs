namespace MVVM.Views;

public partial class MLAllNotes : ContentPage
{
	public MLAllNotes()
	{
		InitializeComponent();
	}
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}