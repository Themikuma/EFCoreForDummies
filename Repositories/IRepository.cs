using EFCoreForDummies.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreForDummies.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Gets all recipes currently known by the brewery.
        /// </summary>
        /// <returns></returns>
        IEnumerable<RecipeViewModel> GetAllRecipes();
        /// <summary>
        /// Gets all the recipes for a given type of beer.
        /// </summary>
        /// <param name="type">The type of beer</param>
        /// <returns></returns>
        IEnumerable<RecipeViewModel> GetRecipesByType(BeerType type);
        /// <summary>
        /// Choose a recipe to prepare for brewing
        /// </summary>
        /// <param name="id">the id of the recipe</param>
        /// <param name="brewers">ids of the brewers</param>
        /// <returns></returns>
        BrewingViewModel PrepareForBrewing(int id, List<int> brewers);
    }
}
