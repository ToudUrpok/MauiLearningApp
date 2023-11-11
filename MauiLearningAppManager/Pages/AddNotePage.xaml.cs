namespace MauiLearningAppManager.Pages;

public partial class AddNotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public AddNotePage()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
        {
            editor.Text += $"{_fileName}\n";
            editor.Text += File.ReadAllText(_fileName);
        }
    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}