using Microsoft.Extensions.DependencyInjection;

namespace NP.TestWpf.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
