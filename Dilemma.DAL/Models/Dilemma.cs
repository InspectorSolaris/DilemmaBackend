using System;
using System.Collections.Generic;

namespace Dilemma.DAL.Models
{
    public class Dilemma
    {
        public Guid Id { get; set; }

        public ICollection<Solution> Solutions { get; set; }

        public string Text { get; set; }
    }
}
