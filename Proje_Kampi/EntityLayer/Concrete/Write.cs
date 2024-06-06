using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Write
    {
        [Key]
        public int WriteID { get; set; }
        public string WriteName { get; set; }
        public string WriteAbout { get; set; }
        public string WriteImage { get; set; }
        public string WriteiMail { get; set; }
        public string WriteiPassword { get; set; }
        public bool WriteStatus { get; set; }
    }
}
