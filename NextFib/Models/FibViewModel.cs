using System.ComponentModel.DataAnnotations;

namespace NextFib.Models
{
    public class FibViewModel
    {
        [Display(Name = "Enter sequence number")]
        [Range(1, 42)]
        public int SequenceNumber { get; set; }

        [Display(Name = "Fibanacci number")]
        [ScaffoldColumn(false)]
        public int FibNumber { get; set; }
    }
}