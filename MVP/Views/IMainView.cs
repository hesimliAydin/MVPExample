﻿using MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        EventHandler<EventArgs> SelectedIndexChanged { get; set; }
        List<Car> Cars { set; }
        string ModelText { get; set; }
        string VendorText { get; set; }
        string ColorText { get; set; }
        string YearText { get; set; }   
    }
}
