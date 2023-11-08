using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class QuestionsModel
    {
        public int Id { get; set; }
        public string Question { get; set; }


        public string Questionnaire
        {
            get
            {
                return $"{Question}";
            }
            
        }
        public string Ids
        {
            get
            {
                return $"{Id}";
            }

        }
    }
}
