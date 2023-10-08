using MauiTest.Services.OpenCv;

using Reactive.Bindings;

namespace MauiTest.ViewModels; 
public class MainViewModel :ViewModelBase{
	public ReactiveProperty<string> Name {
		get;
	} = new();

	public MainViewModel(OpenCvService openCvService) {
		this.Name.Value = openCvService.Get() ? "android" : "ios";
	}
}
