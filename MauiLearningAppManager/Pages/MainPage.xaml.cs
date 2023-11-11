using System.Diagnostics.Metrics;

namespace MauiLearningAppManager.Pages;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterIncClicked(object sender, EventArgs e)
    {
        count++;
        UpdateCounterValue();
    }

    private void OnCounterDecClicked(object sender, EventArgs e)
    {
        count--;
        UpdateCounterValue();
    }

    private void UpdateCounterValue()
    {
        CounterValueLbl.Text = count.ToString();
        SemanticScreenReader.Announce(CounterValueLbl.Text);
    }
}