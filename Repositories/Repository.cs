using System.Collections.Generic;
using System.Linq;
using EFCoreForDummies.Data;
using EFCoreForDummies.ViewModels;

namespace EFCoreForDummies.Repositories
{
    public class Repository : IRepository
    {
        private BreweryContext context;
        public Repository()
        {
            this.context = new BreweryContext();
        }
        public IEnumerable<RecipeViewModel> GetAllRecipes()
        {
            return context.Recipes.Select(t => new RecipeViewModel(t));
        }

        public IEnumerable<RecipeViewModel> GetRecipesByType(BeerType type)
        {
            return context.Recipes.Where(t => t.Type == type).Select(t => new RecipeViewModel(t));
        }

        public BrewingViewModel PrepareForBrewing(int id, List<int> brewers)
        {
            var recipe = context.Recipes.Single(t => t.Id == id);
            var drinkers = context.Brewers.Where(t => brewers.Contains(t.Id));
            var model = new BrewingViewModel();
            model.Recipe = new RecipeViewModel(recipe);
            model.AmberRequired = drinkers.Where(t => t.FavouriteBeerType == BeerType.Amber).Sum(t => t.Upkeep);
            model.LagerRequired = drinkers.Where(t => t.FavouriteBeerType == BeerType.Lager).Sum(t => t.Upkeep);
            model.WeissRequired = drinkers.Where(t => t.FavouriteBeerType == BeerType.Wiess).Sum(t => t.Upkeep);
            return model;
        }
    }
}