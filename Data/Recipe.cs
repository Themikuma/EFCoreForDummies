using System.ComponentModel.DataAnnotations;

namespace EFCoreForDummies.Data
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public BeerType Type { get; set; }
        /// <summary>
        /// Amount of malt required in kg.
        /// </summary>
        public int Malt { get; set; }
        /// <summary>
        /// Amount of hops required in grams.
        /// </summary>
        public int Hops { get; set; }
        /// <summary>
        /// Amount of yeast required in grams.
        /// </summary>
        public int Yeast{ get; set; }
        /// <summary>
        /// Water required in liters.
        /// </summary>
        public int Water { get; set; }
        /// <summary>
        /// The amount of beer expected to be produced in liters.
        /// </summary>
        public int Yield { get; set; }
    }
}