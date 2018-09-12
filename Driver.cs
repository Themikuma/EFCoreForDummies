using EFCoreForDummies.Repositories;
using EFCoreForDummies.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreForDummies
{
    public class Driver
    {
        private IRepository repository = new ADORepository();
        public void Run()
        {
            Console.WriteLine("Welcome");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter command:");
                string line = Console.ReadLine();
                switch (line)
                {
                    case "brewing":
                        PrepareForBrew();
                        break;
                    case "recipe -t":
                        PrintRecipes(ResolveType());
                        break;
                    case "recipes":
                        PrintRecipes(BeerType.All);
                        break;
                    case "exit":
                        exit = true; break;
                    default:
                        break;
                }
            }
        }

        private void PrepareForBrew()
        {

            try
            {
                Console.WriteLine("Enter recipe id:");
                int recipeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a comma seperated list of brewer ids");
                string[] stringIds = Console.ReadLine().Split(',');
                List<int> brewers = new List<int>();
                foreach (var item in stringIds)
                {
                    brewers.Add(int.Parse(item));
                }
                var brew = repository.PrepareForBrewing(recipeId, brewers);
                Console.WriteLine(brew);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void PrintRecipes(BeerType type)
        {
            IEnumerable<RecipeViewModel> recipes = new List<RecipeViewModel>();
            if (type == BeerType.All)
            {
                recipes = repository.GetAllRecipes();
            }
            else
            {
                recipes = repository.GetRecipesByType(type);
            }
            foreach (var item in recipes)
            {
                Console.WriteLine(item);
            }
        }

        private BeerType ResolveType()
        {
            Console.WriteLine("Input type:");
            var type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "lager":
                    return BeerType.Lager;
                case "amber":
                    return BeerType.Amber;
                case "weiss":
                    return BeerType.Wiess;
                default: return BeerType.Wiess;
            }
        }
    }
}
