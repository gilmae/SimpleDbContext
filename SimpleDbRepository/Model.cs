using System;
using Dapper.Contrib.Extensions;

namespace SimpleDbRepository
{
    public class Model
    {
        [Key]
        public int id { get; set; }
    }
}
