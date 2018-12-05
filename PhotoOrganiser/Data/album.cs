using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganiser.Data
{
    public class Album
    {
        public Guid id { get; set; }
        public string dir { get; set; }
        public string name { get; set; }
        public List<Photo> MyProperty { get; set; }

    }
}
