using System.Windows.Input;
using DevExpress.Mvvm;
using IPFinder.Models;
using IPFinder.Services;

namespace IPFinder.ViewModels

{
    public class MainViewModel : BaseVM 
    {
        public string SearchIP { get; set; }

        public IPConfig IPConfig { get; set; }

        public ICommand LoadIPData
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    IPConfig = IPApiService.GetIPConfig(SearchIP);
                });
            }
        }
    }
}
