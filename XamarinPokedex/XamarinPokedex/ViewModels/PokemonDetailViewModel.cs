using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPokedex.Models;
using XamarinPokedex.Services;
using XamarinPokedex.Utils;

namespace XamarinPokedex.ViewModels
{
    public class PokemonDetailViewModel : ViewModelBase
    {
		private PokemonFull _pokefull;

		public PokemonFull PokeFull
		{
			get { return _pokefull; }
			set { SetValue(ref _pokefull,value); }
		}


		public PokemonDetailViewModel(string url)
		{
			LoadOne(url);		
		}

		private Command _retour;

		public Command Retour
		{
			get { return _retour = _retour ?? new Command(RetourListe); }
		}

		private void RetourListe()
		{
			App.Current.MainPage.Navigation.PopModalAsync();
		}

		private async void LoadOne(string url)
		{
			PokeFull =  await DependencyService.Get<IPokemonService>().GetSinglePoke(url);
		}
	}
}
