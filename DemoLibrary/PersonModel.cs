using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public string FullName
        {
            get
            {
                return $"{ UserId }";
            }
        }
    }
}
