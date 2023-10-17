using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CozaStore.Models;

    [Table("ProdutoTag")]
    public class ProdutoTag
    {
        [Key, Column(Order = 1)]
        public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        [Key, Column(Order = 2)]
        public byte TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag Tag{ get; set; }
    }
