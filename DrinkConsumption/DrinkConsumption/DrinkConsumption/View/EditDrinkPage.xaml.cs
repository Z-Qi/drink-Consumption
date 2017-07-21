﻿using DrinkConsumption.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkConsumption.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditDrinkPage : ContentPage
	{
		public EditDrinkPage (EditDrinkViewModel viewModel)
		{
			InitializeComponent ();
            BindingContext = viewModel;
		}
	}
}