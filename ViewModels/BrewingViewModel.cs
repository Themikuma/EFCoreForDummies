using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreForDummies.ViewModels
{
    public class BrewingViewModel
    {
        public RecipeViewModel Recipe { get; set; }
        public int WeissRequired { get; set; }
        public int AmberRequired { get; set; }
        public int LagerRequired { get; set; }

        public override string ToString()
        {
            return $"Recipe requires:" +
                $"\n\tMalt: {Recipe.Malt} kg" +
                $"\n\tWater: {Recipe.Water} kg" +
                $"\n\tHops: {Recipe.Hops} g" +
                $"\n\tYeast: {Recipe.Yeast} g" +
                $"\nUpkeep requires:" +
                $"\n\tLager: {LagerRequired}" +
                $"\n\tWeiss: {WeissRequired}" +
                $"\n\tAmber: {AmberRequired}";
        }
    }
}
