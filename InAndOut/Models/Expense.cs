using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required(ErrorMessage = "این فیلد ضروری است!")]
        public string ExpenseName { get; set; }
        [Required(ErrorMessage = "این فیلد ضروری است!")]
        [Range(0.1, double.MaxValue, ErrorMessage = "!مقدار این فیلد باید بزرگتر از صفر باشد")]
        public double Amount { get; set; }
        [DisplayName("Expense Type")]
        public int ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
