﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TL52D_4Entities1 : DbContext
    {
        public TL52D_4Entities1()
            : base("name=TL52D_4Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Aluno_Curso> Aluno_Curso { get; set; }
        public virtual DbSet<Aluno_UC> Aluno_UC { get; set; }
        public virtual DbSet<Certificado> Certificado { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Seccao> Seccao { get; set; }
        public virtual DbSet<Semestre> Semestre { get; set; }
        public virtual DbSet<UC_Curso> UC_Curso { get; set; }
        public virtual DbSet<Unidade_Curricular> Unidade_Curricular { get; set; }
    
        public virtual int atribuirNota(Nullable<decimal> aluno, string uc_sigla, Nullable<System.DateTime> ano, Nullable<decimal> nota, string sigla_curso)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(decimal));
    
            var uc_siglaParameter = uc_sigla != null ?
                new ObjectParameter("uc_sigla", uc_sigla) :
                new ObjectParameter("uc_sigla", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(System.DateTime));
    
            var notaParameter = nota.HasValue ?
                new ObjectParameter("nota", nota) :
                new ObjectParameter("nota", typeof(decimal));
    
            var sigla_cursoParameter = sigla_curso != null ?
                new ObjectParameter("sigla_curso", sigla_curso) :
                new ObjectParameter("sigla_curso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("atribuirNota", alunoParameter, uc_siglaParameter, anoParameter, notaParameter, sigla_cursoParameter);
        }
    
        public virtual int deleteDepartamento(string sigla)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteDepartamento", siglaParameter);
        }
    
        public virtual int inscreverAluno_UC(Nullable<decimal> aluno, string sigla_curso, Nullable<System.DateTime> ano, string uc_sigla)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(decimal));
    
            var sigla_cursoParameter = sigla_curso != null ?
                new ObjectParameter("sigla_curso", sigla_curso) :
                new ObjectParameter("sigla_curso", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(System.DateTime));
    
            var uc_siglaParameter = uc_sigla != null ?
                new ObjectParameter("uc_sigla", uc_sigla) :
                new ObjectParameter("uc_sigla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("inscreverAluno_UC", alunoParameter, sigla_cursoParameter, anoParameter, uc_siglaParameter);
        }
    
        public virtual int insertDepartamento(string dpt_sigla, string desc)
        {
            var dpt_siglaParameter = dpt_sigla != null ?
                new ObjectParameter("dpt_sigla", dpt_sigla) :
                new ObjectParameter("dpt_sigla", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertDepartamento", dpt_siglaParameter, descParameter);
        }
    
        public virtual int insertDepartmento(string dpt_sigla, string desc)
        {
            var dpt_siglaParameter = dpt_sigla != null ?
                new ObjectParameter("dpt_sigla", dpt_sigla) :
                new ObjectParameter("dpt_sigla", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertDepartmento", dpt_siglaParameter, descParameter);
        }
    
        public virtual int insertUC_on_sem(string uc, Nullable<System.DateTime> ano, string sigla_curso, Nullable<int> semestre)
        {
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(System.DateTime));
    
            var sigla_cursoParameter = sigla_curso != null ?
                new ObjectParameter("sigla_curso", sigla_curso) :
                new ObjectParameter("sigla_curso", typeof(string));
    
            var semestreParameter = semestre.HasValue ?
                new ObjectParameter("semestre", semestre) :
                new ObjectParameter("semestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertUC_on_sem", ucParameter, anoParameter, sigla_cursoParameter, semestreParameter);
        }
    
        public virtual int matricularAluno(Nullable<decimal> aluno, string sigla_curso, Nullable<System.DateTime> ano)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(decimal));
    
            var sigla_cursoParameter = sigla_curso != null ?
                new ObjectParameter("sigla_curso", sigla_curso) :
                new ObjectParameter("sigla_curso", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("matricularAluno", alunoParameter, sigla_cursoParameter, anoParameter);
        }
    
        public virtual int removeUC_from_sem(string uc, string sigla_curso)
        {
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            var sigla_cursoParameter = sigla_curso != null ?
                new ObjectParameter("sigla_curso", sigla_curso) :
                new ObjectParameter("sigla_curso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("removeUC_from_sem", ucParameter, sigla_cursoParameter);
        }
    
        public virtual ObjectResult<showUC_NoInscricao_Result> showUC_NoInscricao(Nullable<System.DateTime> ano1, Nullable<System.DateTime> ano2)
        {
            var ano1Parameter = ano1.HasValue ?
                new ObjectParameter("ano1", ano1) :
                new ObjectParameter("ano1", typeof(System.DateTime));
    
            var ano2Parameter = ano2.HasValue ?
                new ObjectParameter("ano2", ano2) :
                new ObjectParameter("ano2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<showUC_NoInscricao_Result>("showUC_NoInscricao", ano1Parameter, ano2Parameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int updateDepartamento(string oldSigla, string newSigla, string newDesc)
        {
            var oldSiglaParameter = oldSigla != null ?
                new ObjectParameter("oldSigla", oldSigla) :
                new ObjectParameter("oldSigla", typeof(string));
    
            var newSiglaParameter = newSigla != null ?
                new ObjectParameter("newSigla", newSigla) :
                new ObjectParameter("newSigla", typeof(string));
    
            var newDescParameter = newDesc != null ?
                new ObjectParameter("newDesc", newDesc) :
                new ObjectParameter("newDesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateDepartamento", oldSiglaParameter, newSiglaParameter, newDescParameter);
        }
    }
}
