using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Code { get; set; }
        public string TreeCode { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Info { get; set; }
        public string Date { get; set; }


    }
}
