using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreForDummies.Data
{
    public class Brewer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BeerType FavouriteBeerType { get; set; }
        /// <summary>
        /// The amount of beer in bottles a brewer drinks through for a day of brewing.
        /// </summary>
        public int Upkeep { get; set; }
    }
}
