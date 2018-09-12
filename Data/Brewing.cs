using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreForDummies.Data
{
    public class Brewing
    {
        [Key]
        public int Id { get; set; }
        public Recipe Recipe{ get; set; }
        public IEnumerable<Brewer> Brewers { get; set; }
    }
}
