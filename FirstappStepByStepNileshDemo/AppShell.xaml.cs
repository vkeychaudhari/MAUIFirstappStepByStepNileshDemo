using FirstappStepByStepNileshDemo.Views;
using System.Windows.Input;

namespace FirstappStepByStepNileshDemo;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }
    void RegisterRoutes()
    {
        Routes.Add("monkeydetails", typeof(CatsPage));
        Routes.Add("beardetails", typeof(CatsPage));
        Routes.Add("catdetails", typeof(CatsPage));
        Routes.Add("dogdetails", typeof(CatsPage));
        Routes.Add("elephantdetails", typeof(CatsPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }

}
