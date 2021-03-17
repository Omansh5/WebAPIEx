using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIModelEx.Model
{
    [Table("Movies")]
    public class Movies
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
        public string StarCast { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }

        internal static void Add(Movies obj)
        {
            throw new NotImplementedException();
        }

        internal static object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal static int IndexOf(object n)
        {
            throw new NotImplementedException();
        }
    }
}
