using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MeusAfazeres.Models
{
    public class Fazer
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage ="Campo Obrigatório, favor preencher.")]
        public string Titulo { get; set; }

        [DisplayName("Concluído")]
        public bool Concluido { get; set; }

        [DisplayName("Criado em")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        [DisplayName("Data da última atualização")]
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public string Usuario { get; set; }
    }
}
