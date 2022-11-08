using MVP.Data;
using MVP.Model;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class MainPresenter
    {
        private readonly CarContext _db;
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            _db=new CarContext();

            _view.AddButtonClicked += ViewAddButtonClicked;

            _view.LoadButtonClicked += ViewLoadButtonClicked;

            _view.SelectedIndexChanged += ViewSelectedChange;
        }

        private void ViewAddButtonClicked(object sender,EventArgs e)
        {
            Car car = new Car
            {
                Model = _view.ModelText,
                Vendor = _view.VendorText,
                Color = _view.ColorText,
                Year = int.Parse(_view.YearText)
            };

            _db.Cars.Add(car);
            _db.SaveChanges();  
        }

        private void ViewLoadButtonClicked(object sender,EventArgs e)
        {
            var list = _db.Cars.ToList();
            _view.Cars = list;
        }

        private void ViewSelectedChange(object sender,EventArgs e)
        {
            var car = (sender as ListBox).SelectedItem as Car;
            _view.VendorText = car.Vendor;
            _view.ModelText = car.Model;
            _view.ColorText = car.Color;
            _view.YearText=car.Year.ToString();

        }

    }
}
