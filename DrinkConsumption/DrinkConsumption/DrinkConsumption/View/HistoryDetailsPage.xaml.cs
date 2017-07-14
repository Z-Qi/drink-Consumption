﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrinkConsumption.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkConsumption.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoryDetailsPage : ContentPage
	{
        DateTime date;

		public HistoryDetailsPage (DrinksHistoryViewModel viewModel, DateTime date)
		{
			InitializeComponent ();
            BindingContext = viewModel;
            this.date = date;
        }
	}
}