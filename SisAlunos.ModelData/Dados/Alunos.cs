//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisAlunos.ModelData.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alunos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alunos()
        {
            this.Responsaveis = new HashSet<Responsaveis>();
        }
    
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public int CidadeID { get; set; }
        public string RG { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Matricula { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public System.DateTime DataUltimaAlteracao { get; set; }
        public string NomeUsuarioAlteracao { get; set; }
    
        public virtual Cidades Cidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Responsaveis> Responsaveis { get; set; }
    }
}
