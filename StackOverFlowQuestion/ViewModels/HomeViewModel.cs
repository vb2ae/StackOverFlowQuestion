using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using StackOverFlowQuestion.Models;

namespace StackOverFlowQuestion.ViewModels
{
    public class HomeViewModel : Screen
    {
        private readonly INavigationService navigationService;
        private ILog log;
        public HomeViewModel(INavigationService nav)
        {
            log = LogManager.GetLog(this.GetType());
            log.Info("HomeViewModel constructor");
            navigationService = nav;
        }


        private BindableCollection<ProductModel> _products;

        public BindableCollection<ProductModel> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }


        protected override async void OnViewLoaded(object view)
        {
            var products = new List<ProductModel>();
            products.Add(new ProductModel()
            {
                 Id = 1,
                 ProductLotNumber = "1",
                 ProductNote = "Test Product",
                 ProductType = new ProductTypeModel
                 {
                     ProductName="Test Product"
                 }
            });
            Products = new BindableCollection<ProductModel>(products);
            base.OnViewLoaded(view);
        }
    }
}
