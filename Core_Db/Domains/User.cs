using System;
using System.Collections.Generic;

#nullable disable

namespace Core_Db.Domains
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public string Club { get; set; }
        public string Face { get; set; }
        public string Country { get; set; }
        public int? Rating { get; set; }
        public int? Status { get; set; }
    }
}
