using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = String.Empty;
        [Required]
        [MaxLength(50, ErrorMessage = "Company Name cannot be over 50 characters")]
        public string CompanyName { get; set; } = String.Empty;
        [Required]
        [Range(1, 1_000_000_000_000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Industry cannot be over 50 characters")]
        public string Industry { get; set; } = String.Empty;
        [Required]
        [Range(1, 5_000_000_000_000)]
        public long MarketCap { get; set; }
    }
}