using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class DadosLoginMapping : IEntityTypeConfiguration<DadosLogin>
    {
        public void Configure(EntityTypeBuilder<DadosLogin> builder)
        {
            builder.ToTable("dados_login");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.IdUsuarioDadosLogin).HasColumnName("id_usuario");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.UserName).HasColumnName("login");
            builder.Property(x => x.Senha).HasColumnName("senha");

            builder.HasOne(x => x.Usuario).WithOne(s => s.DadosLogin).HasForeignKey<DadosLogin>(x => x.IdUsuarioDadosLogin);
        }
    }
}