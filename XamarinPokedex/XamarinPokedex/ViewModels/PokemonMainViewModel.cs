using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinPokedex.Views;

namespace XamarinPokedex.ViewModels
{
    class PokemonMainViewModel
    {

		private Command _openList;

		public Command OpenList
		{
			get { return _openList = _openList ?? new Command(OnClick); }

		}

		public void OnClick()
		{
			App.Current.MainPage.Navigation.PushAsync(new PokeList());
		}
	}
}
