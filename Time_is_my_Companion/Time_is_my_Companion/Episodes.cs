using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Time_is_my_Companion
{
    [Table(Name = "EPISODES")]
    internal class Episodes
    {
        [Column] public string StoryID { get; set; }
        [Column] public string Season { get; set; }
        [Column] public string SeasonYear { get; set; }
        [Column] public string Title { get; set; }

    }
}
