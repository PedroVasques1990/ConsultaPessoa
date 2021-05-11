using System.Collections.Generic;
using main;
using Microsoft.EntityFrameworkCore;

namespace ConsultaPessoas.Application.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>
            (
                pessoa => 
                {
                    pessoa.ToTable("Pessoas");
                    pessoa.HasKey(p => p.Id);
                    pessoa.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
                    pessoa.Property(p => p.DataNascimento).HasColumnType("DATE").IsRequired();
                    pessoa.Property(p => p.Cpf).HasColumnType("VARCHAR(50)").IsRequired();
                }
            ); 

            
            modelBuilder.Entity<Pessoa>().HasData
            (
                PopularBase()
            );
        }

        private IEnumerable<Pessoa> PopularBase()
        {
            for(int i=0;i < 100;i++)
                yield return new Pessoa();
        }
    }
}