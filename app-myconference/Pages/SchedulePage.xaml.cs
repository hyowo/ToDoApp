using Microsoft.Maui.Controls;
using app_myconference.ViewModels;

namespace app_myconference.Pages;


public partial class ScheduleDay1Page : SchedulePage
{
    public ScheduleDay1Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Schedule - Day 1";
        BindingContext = vm;
    }
}

public partial class ScheduleDay2Page : SchedulePage
{
    public ScheduleDay2Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 2;
        Title = "Schedule - Day 2";
        BindingContext = vm;
    }
}
public partial class SchedulePage : ContentPage
{
    ScheduleViewModel vm;
    ScheduleViewModel VM => vm ??= BindingContext as ScheduleViewModel;


    public SchedulePage()
    {
        InitializeComponent();

        switch (Title)
        {
            case "Day 1":
                vm.Day = 1;
                break;
            case "Day 2":
                vm.Day = 2;
                break;
        }
        BindingContext = this.vm = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (VM.Schedule.Count == 0)
        {
            await VM.LoadDataCommand.ExecuteAsync(null);
        }
    }



    //protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //}
}