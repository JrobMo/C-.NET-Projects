using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Time_is_my_Companion
{
    [Table(Name = "Doctors")]
    internal class Doctor1
    {
        [Column] public int DoctorID { get; set; }
        [Column] public int Actor { get; set; }
        [Column] public int Series { get; set; }
        [Column] public int Age { get; set; }
        [Column] public int Debut { get; set; }
        [Column] public int Picture { get; set; }

    }
}
