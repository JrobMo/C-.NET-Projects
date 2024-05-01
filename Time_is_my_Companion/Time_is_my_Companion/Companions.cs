using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Time_is_my_Companion
{
    [Table(Name = "COMPANIONS")]
    internal class Companions
    {
        [Column] public string Name { get; set; }
        [Column] public string Actor { get; set; }
        [Column] public int DoctorID { get; set; }
        [Column] public int StoryID { get; set; }

    }
}
