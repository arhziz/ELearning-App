
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using ELearningMobieApp.Models;

namespace ELearningMobieApp.ViewModels;

public partial class OnBoardingViewModel : ViewModelBase
{

    public ObservableCollection<OnBoardingItem> OnBoardingItems { get; set; } = new ObservableCollection<OnBoardingItem>
    {
        new OnBoardingItem
        {
            Title = "First See Learning",
            SubTitle = "Forget about a for of paper all Knowledge in one learning",
            Image = "onboarding1"
        },
        new OnBoardingItem
        {
            Title = "Connect With Everyone",
            SubTitle = "Always keep in touch with your tutor and friends, Lets get connected",
            Image = "onboarding2"
        },
        new OnBoardingItem
        {
            Title = "Always Fascinated Learning",
            SubTitle = "Anywhere, anytime, the time is at your discretion so study whenever you want",
            Image = "onboarding1"
        }

    };

    [ObservableProperty]
    string currentButtonText;

    public ICommand CarouselItemChangeCommand => new Command<OnBoardingItem>(ProccessItemChanged);

    private void ProccessItemChanged(OnBoardingItem theItem)
    {
        if (OnBoardingItems[2] == theItem)
        {
            CurrentButtonText = "Get Started";
        }
        else
        {
            CurrentButtonText = "Next";
        }
    }

    [RelayCommand]
    void GotoMainPage()
    {
        App.Current.MainPage = new MainPage();
    }

    public OnBoardingViewModel()
    {
        CurrentButtonText = "Next";
    }


}

