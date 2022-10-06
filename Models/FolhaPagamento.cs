using System;
using System.ComponentModel.DataAnnotations;

namespace API_Folhas.Models
{
    public class FolhaPagamento
    {
        public int FolhaPagamentoId { get; set; }
        [Required(ErrorMessage = "Id do funcionário é obrigatório")]
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        [Required(ErrorMessage = "O valor das horas trabalhadas é obrigatório")]
        public double ValorHora { get; set; }
        [Required(ErrorMessage = "A quantidade de horas trabalhadas é obrigatório")]
        public double QuantidadeHoras { get; set; }
        public double SalarioBruto { get; set; }
        public double ImpostoRenda { get; set; }
        public double ImpostoInss { get; set; }
        public double ImpostoFgts { get; set; }
        public double SalarioLiquido { get; set; }
        public DateTime CriadoEm { get; set; }
        
        public FolhaPagamento() => CriadoEm = DateTime.Now;
    }
}