using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.EntityConfigs;

public class AppDbContext:DbContext{
    //override (sobrescrever)
    //DbContext representa o banco de dados
    //DbSet representa a tabela
    
    //Essa linha seta (atribui) a classe Curso como a entidade no banco de dados (Context)
    public DbSet<Curso> Cursos => Set<Curso>(); //representa a tabela


// protected overrride
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-24;Database=EscoladotNet;User id=sa;Password=senai@123;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new CursoEntityConfig());
    }
}