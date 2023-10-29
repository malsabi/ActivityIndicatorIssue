using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ActivityIndicatorIssue;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isPullToRefresh = false;

    [RelayCommand]
    private void Toggle()
    {
        IsPullToRefresh = !IsPullToRefresh;
    }
}