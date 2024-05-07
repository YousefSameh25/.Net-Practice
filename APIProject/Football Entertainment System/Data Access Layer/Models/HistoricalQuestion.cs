using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class HistoricalQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string RightAnswer { get; set; }
    }
}
