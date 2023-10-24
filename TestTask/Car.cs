using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Car
    {
        [Key]       
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Date { get; set; }
        public string ModelCode { get; set; }

    }
}
