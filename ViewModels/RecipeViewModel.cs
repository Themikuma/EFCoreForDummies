using EFCoreForDummies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreForDummies.ViewModels
{
    public class RecipeViewModel
    {
        public RecipeViewModel()
        {

        }
        public RecipeViewModel(Recipe recipe)
        {
            this.Name = recipe.Name;
            this.Type = recipe.Type;
            this.Malt = recipe.Malt;
            this.Hops = recipe.Hops;
            this.Yeast = recipe.Yeast;
            this.Water = recipe.Water;
            this.Yield = recipe.Yield;
        }
        public string Name { get; set; }
        public BeerType Type { get; set; }
        public int Malt { get; set; }
        public int Hops { get; set; }
        public int Yeast { get; set; }
        public int Water { get; set; }
        public int Yield { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n\tType: {Type}\n\tHops: {Hops}\n\tWater: {Water}";
        }
    }
}
