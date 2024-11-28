using CommunityToolkit.Mvvm.ComponentModel;
using WeatherApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.Models;
using WeatherApp.Views;
using Microsoft.Maui.Layouts;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModels
{
    public partial class WeatherAppViewModel: ObservableObject
    {
        [ObservableProperty]
        Cidade cidade;

        [ObservableProperty]
        private bool isVisible = false;

        WeatherAppService weatherAppService;
        public ICommand getCidadeCommand { get; }

        public WeatherAppViewModel()
        {
            getCidadeCommand = new Command(getCidade);
            weatherAppService = new WeatherAppService();
        }

        public async void getCidade()
        {
            cidade = await weatherAppService.GetCidadeAsync("São paulo");
        }
    }
}
