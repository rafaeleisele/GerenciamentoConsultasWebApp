using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("enderecos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.IdUsuarioEndereco).HasColumnName("id_usuario");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Cidade).HasColumnName("cidade");
            builder.Property(x => x.Cep).HasColumnName("cep");
            builder.Property(x => x.Logradouro).HasColumnName("logradouro");
            builder.Property(x => x.Numero).HasColumnName("numero");
            builder.Property(x => x.Complemento).HasColumnName("complemento");

            builder.HasOne(x => x.Usuario).WithOne(s => s.Endereco).HasForeignKey<Endereco>(x => x.IdUsuarioEndereco);
        }
    }
}