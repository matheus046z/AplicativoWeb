
using AplicativoWeb.Models; //Camada Moldel
using Microsoft.EntityFrameworkCore; //EF Framework
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Fluent API -> Configura a futura table na classe
namespace AplicativoWeb.EntityConfigs; // Novo namespace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");
        // Id -> Única - Iniversal - Imutável
        builder.HasKey(c=>c.Id); // Chave primária
        
        //TiutloMarketing
        builder.Property(c=>c.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired(); 
        
        //TiutloInterno
        builder.Property(c=>c.TituloInterno)
               .HasColumnType("nvarchar(80)")
               .IsRequired(); 
        
        //TiutloInterno
        builder.Property(c=>c.Descricao)
               .HasColumnType("text")
               .IsRequired(); 
    }
}
// Lambda
/*
public void Somar(int x, int y){
    return x+y;
}

s=>x+y   <-- Lambda

*/