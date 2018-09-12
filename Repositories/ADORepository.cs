using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using EFCoreForDummies.ViewModels;

namespace EFCoreForDummies.Repositories
{
    public class ADORepository : IRepository
    {
        string connectionString = "server=.; database=Brewery; Trusted_Connection=true";
        public IEnumerable<RecipeViewModel> GetAllRecipes()
        {
            string commandText = "Select [Type],[Hops],[Malt],[Name] ,[Water],[Yeast],[Yield] from Recipes";
            List<RecipeViewModel> recipes = new List<RecipeViewModel>();
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText);
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipes.Add(new RecipeViewModel()
                        {
                            Hops=int.Parse(reader["Hops"].ToString()),
                            Malt=int.Parse(reader["Malt"].ToString())
                        });
                    }
                }
            }
            return recipes;
        }

        public IEnumerable<RecipeViewModel> GetRecipesByType(BeerType type)
        {
            throw new NotImplementedException();
        }

        public BrewingViewModel PrepareForBrewing(int id, List<int> brewers)
        {
            throw new NotImplementedException();
        }
    }
}
