using System;
using System.Collections.Generic;

namespace Dilemma.DAL.Models
{
    public class Solution
    {
        public Guid Id { get; set; }

        public Guid DilemmaId { get; set; }

        public Dilemma Dilemma { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public string Text { get; set; }

        public string Image { get; set; }

        public double Rate { get; set; }
    }
}
