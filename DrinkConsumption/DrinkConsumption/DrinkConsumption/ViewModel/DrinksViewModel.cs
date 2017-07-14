﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkConsumption.ViewModel
{
    public class DrinksViewModel
    {
        private List<Drink> _drinks;

        public DrinksViewModel()
        {
            _drinks = new List<Drink>();
            this.testSample();
        }

        private void testSample()
        {
            _drinks.Add(new Drink("TEST 1", 100, 1.33333, 15.5));
            _drinks.Add(new Drink("TEST 2", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
            _drinks.Add(new Drink(null, 100, 1.33333, 15.5));
            _drinks.Add(new Drink("", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
            _drinks.Add(new Drink("TEST 1", 100, 1.33333, 15.5));
            _drinks.Add(new Drink("TEST 2", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
            _drinks.Add(new Drink("TEST 1", 100, 1.33333, 15.5));
            _drinks.Add(new Drink("TEST 2", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
            _drinks.Add(new Drink("TEST 1", 100, 1.33333, 15.5));
            _drinks.Add(new Drink("TEST 2", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
            _drinks.Add(new Drink("TEST 1", 100, 1.33333, 15.5));
            _drinks.Add(new Drink("TEST 2", 600, 3, 45.99));
            _drinks.Add(new Drink("TEST 3", 010, 0.2, 5));
        }

        public List<Drink> Drinks
        {
            get => _drinks;
            set
            {
                _drinks = value;
            }
        }

        public void add(Drink drink)
        {
            _drinks.Add(drink);
        }

    }
}