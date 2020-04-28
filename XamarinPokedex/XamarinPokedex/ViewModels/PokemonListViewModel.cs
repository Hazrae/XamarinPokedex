using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPokedex.Models;
using XamarinPokedex.Services;
using XamarinPokedex.Utils;
using XamarinPokedex.Views;

namespace XamarinPokedex.ViewModels
{
	class PokemonListViewModel : ViewModelBase
    {
	
		private bool _canNext;

		public bool CanNext
		{
			get { return _canNext; }
			set { SetValue(ref _canNext, value); }
		}

		private bool _canPrevious;

		public bool CanPrevious
		{
			get { return _canPrevious; }
			set { SetValue(ref _canPrevious, value); }
		}

		private PokemonBus _pokeBus;

		public PokemonBus PokeBus
		{
			get { return _pokeBus; }
			set { SetValue(ref _pokeBus, value); }
		}

		private ObservableCollection<Pokemon> _pokeList;

		public ObservableCollection<Pokemon> PokeList
		{
			get { return _pokeList = _pokeList ?? new ObservableCollection<Pokemon>(); }
			set { SetValue(ref _pokeList, value); }
		}

		private Pokemon _selectedPoke;

		public Pokemon SelectedPoke
		{
			get { return _selectedPoke; }
			set
			{
				if (_selectedPoke != value)
				{
					_selectedPoke = value;
					App.Current.MainPage.Navigation.PushModalAsync(new PokemonDetail(_selectedPoke.Url));
				}
			}
		}

		public PokemonListViewModel()
		{
			LoadItems();		
		}

		private async void LoadItems(string uri = "https://pokeapi.co/api/v2/pokemon/")
		{ 
			PokeBus = await DependencyService.Get<IPokemonService>().GetAllAsync(uri);
			CanButton();

			this.PokeList.Clear();
			foreach(Pokemon pk in PokeBus.Results)
			{
				PokeList.Add(pk);
			}
		}

		

		private Command _goNext;

		public Command GoNext
		{
			get { return _goNext = _goNext ?? new Command(OnNext); }//delegate à ajouter pour check le bouton

		}

		public void OnNext()
		{
			if(this.PokeBus.Next != null)
			{
				LoadItems(this.PokeBus.Next);				
			}
		}	
	
		private Command _goPrevious;

		public Command GoPrevious
		{
			get { return _goPrevious = _goPrevious ?? new Command(OnPrevious); }//delegate à ajouter pour check le bouton

		}

		public void OnPrevious()
		{
			if (this.PokeBus.Previous != null)
			{
				LoadItems(this.PokeBus.Previous);				
			}
		}		
		public void CanButton()
		{
			if (this.PokeBus.Previous != null)
			{
				CanPrevious = true;
			}
			else
			{
				CanPrevious = false;
			}
			if (this.PokeBus.Next != null)
			{
				CanNext = true;
			}
			else
			{
				CanNext = false;
			}
			
		}
	}
}
