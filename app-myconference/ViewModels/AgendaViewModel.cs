
using app_myconference.Models;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;

namespace app_myconference.ViewModels;

public partial class AgendaViewModel : ObservableObject
{
    public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new();

    public AgendaViewModel() {
    }

    [RelayCommand]
    Task LoadDataAsync()
    {
        var offset = 0;
        var items = new[] { 1, 2, 3, 4, 4, 4, 4, 4 };
        return Task.CompletedTask;
        void AddItems(int count)
        {

        }

    }
}
