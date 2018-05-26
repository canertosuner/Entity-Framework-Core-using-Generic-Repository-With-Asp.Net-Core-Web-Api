using System;
using System.ComponentModel.DataAnnotations;

namespace EfCoreWithWebApiSample.Entity
{
    public class Product: IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        
    }
}
