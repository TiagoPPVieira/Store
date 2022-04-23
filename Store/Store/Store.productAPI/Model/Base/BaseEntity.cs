using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.productAPI.Model.Base
{
    public class BaseEntity
    {
        [key]
        [Column("id")]
        public long Id { get; set; }
    }
}
