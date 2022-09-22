using ELearningMobieApp.ViewModels;

namespace ELearningMobieApp.Views;

public partial class OnBoarding : ContentPage
{
	private readonly OnBoardingViewModel vm;
	public OnBoarding()
	{
		InitializeComponent();

		vm = new OnBoardingViewModel();

		BindingContext = vm;

	}

    void CarouselView_CurrentItemChanged(System.Object sender, Microsoft.Maui.Controls.CurrentItemChangedEventArgs e)
    {
		if(((CarouselView)sender).Position == 2)
		{
			vm.CurrentButtonText = "Get Started";
		}
		else
		{
            vm.CurrentButtonText = "Next";
        }
    }
}
