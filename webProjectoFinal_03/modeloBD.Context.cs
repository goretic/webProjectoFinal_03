﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webProjectoFinal_03
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<DetalheConta> DetalheConta { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<IVA> IVA { get; set; }
        public DbSet<Linha> Linha { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Serie> Serie { get; set; }
    
        public virtual int sp_AdicionaCliente(string nome, string rua, string localidade, string pais, string codpostal, string nif, string telefone)
        {
            var nomeParameter = nome != null ?
                new ObjectParameter("nome", nome) :
                new ObjectParameter("nome", typeof(string));
    
            var ruaParameter = rua != null ?
                new ObjectParameter("rua", rua) :
                new ObjectParameter("rua", typeof(string));
    
            var localidadeParameter = localidade != null ?
                new ObjectParameter("localidade", localidade) :
                new ObjectParameter("localidade", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            var codpostalParameter = codpostal != null ?
                new ObjectParameter("codpostal", codpostal) :
                new ObjectParameter("codpostal", typeof(string));
    
            var nifParameter = nif != null ?
                new ObjectParameter("nif", nif) :
                new ObjectParameter("nif", typeof(string));
    
            var telefoneParameter = telefone != null ?
                new ObjectParameter("telefone", telefone) :
                new ObjectParameter("telefone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AdicionaCliente", nomeParameter, ruaParameter, localidadeParameter, paisParameter, codpostalParameter, nifParameter, telefoneParameter);
        }
    
        public virtual int sp_ApagaCliente(Nullable<int> clienteID)
        {
            var clienteIDParameter = clienteID.HasValue ?
                new ObjectParameter("ClienteID", clienteID) :
                new ObjectParameter("ClienteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ApagaCliente", clienteIDParameter);
        }
    
        public virtual int sp_EditaCliente(Nullable<int> clienteID, string nome, string rua, string localidade, string pais, string codpostal, string nif, string telefone)
        {
            var clienteIDParameter = clienteID.HasValue ?
                new ObjectParameter("ClienteID", clienteID) :
                new ObjectParameter("ClienteID", typeof(int));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("nome", nome) :
                new ObjectParameter("nome", typeof(string));
    
            var ruaParameter = rua != null ?
                new ObjectParameter("rua", rua) :
                new ObjectParameter("rua", typeof(string));
    
            var localidadeParameter = localidade != null ?
                new ObjectParameter("localidade", localidade) :
                new ObjectParameter("localidade", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            var codpostalParameter = codpostal != null ?
                new ObjectParameter("codpostal", codpostal) :
                new ObjectParameter("codpostal", typeof(string));
    
            var nifParameter = nif != null ?
                new ObjectParameter("nif", nif) :
                new ObjectParameter("nif", typeof(string));
    
            var telefoneParameter = telefone != null ?
                new ObjectParameter("telefone", telefone) :
                new ObjectParameter("telefone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EditaCliente", clienteIDParameter, nomeParameter, ruaParameter, localidadeParameter, paisParameter, codpostalParameter, nifParameter, telefoneParameter);
        }
    }
}
