using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CozaStore.Models;

    [Table("Tag")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(20, ErrorMessage = "O Nome deve possuir no máximo 20 caracteres")]
        public string Nome {get; set; }
        public ICollection<ProdutoTag> Produtos { get; set; }
    }