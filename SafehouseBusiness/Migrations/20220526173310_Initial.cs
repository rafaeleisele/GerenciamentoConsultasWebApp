using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafehouseBusiness.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dados_login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    login = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dados_login", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logradouro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complemento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "local_consulta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_contato = table.Column<int>(type: "int", nullable: false),
                    IdDocumento = table.Column<int>(type: "int", nullable: false),
                    id_endereco = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo_local_consulta = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_local_consulta", x => x.id);
                    table.ForeignKey(
                        name: "FK_local_consulta_contatos_id_contato",
                        column: x => x.id_contato,
                        principalTable: "contatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_local_consulta_enderecos_id_endereco",
                        column: x => x.id_endereco,
                        principalTable: "enderecos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_contato = table.Column<int>(type: "int", nullable: false),
                    id_endereco = table.Column<int>(type: "int", nullable: false),
                    id_dados_login = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_contatos_id_contato",
                        column: x => x.id_contato,
                        principalTable: "contatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_dados_login_id_dados_login",
                        column: x => x.id_dados_login,
                        principalTable: "dados_login",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_enderecos_id_endereco",
                        column: x => x.id_endereco,
                        principalTable: "enderecos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "documentos_local_consulta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_local_consulta = table.Column<int>(type: "int", nullable: false),
                    identificacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentos_local_consulta", x => x.id);
                    table.ForeignKey(
                        name: "FK_documentos_local_consulta_local_consulta_id_local_consulta",
                        column: x => x.id_local_consulta,
                        principalTable: "local_consulta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "documentos_usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    identificacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentos_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_documentos_usuarios_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "unidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numero = table.Column<int>(type: "int", nullable: false),
                    IdLocalConsulta = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioUnidade = table.Column<int>(type: "int", nullable: false),
                    aluguel = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    tamanho = table.Column<double>(type: "double", nullable: false),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_unidade_local_consulta_IdLocalConsulta",
                        column: x => x.IdLocalConsulta,
                        principalTable: "local_consulta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_unidade_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios_locais_consulta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_local_consulta = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios_locais_consulta", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_locais_consulta_local_consulta_id_local_consulta",
                        column: x => x.id_local_consulta,
                        principalTable: "local_consulta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_locais_consulta_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reunioes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    horario = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdLocalConsulta = table.Column<int>(type: "int", nullable: false),
                    IdUnidade = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reunioes", x => x.id);
                    table.ForeignKey(
                        name: "FK_reunioes_local_consulta_IdLocalConsulta",
                        column: x => x.IdLocalConsulta,
                        principalTable: "local_consulta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reunioes_unidade_IdUnidade",
                        column: x => x.IdUnidade,
                        principalTable: "unidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios_unidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_unidade = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios_unidades", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_unidades_unidade_id_unidade",
                        column: x => x.id_unidade,
                        principalTable: "unidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_unidades_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios_reunioes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_reuniao = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios_reunioes", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_reunioes_reunioes_id_reuniao",
                        column: x => x.id_reuniao,
                        principalTable: "reunioes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_reunioes_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_documentos_local_consulta_id_local_consulta",
                table: "documentos_local_consulta",
                column: "id_local_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_documentos_usuarios_id_usuario",
                table: "documentos_usuarios",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_local_consulta_id_contato",
                table: "local_consulta",
                column: "id_contato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_local_consulta_id_endereco",
                table: "local_consulta",
                column: "id_endereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_reunioes_IdLocalConsulta",
                table: "reunioes",
                column: "IdLocalConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_reunioes_IdUnidade",
                table: "reunioes",
                column: "IdUnidade");

            migrationBuilder.CreateIndex(
                name: "IX_unidade_IdLocalConsulta",
                table: "unidade",
                column: "IdLocalConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_unidade_UsuarioId",
                table: "unidade",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_contato",
                table: "usuarios",
                column: "id_contato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_dados_login",
                table: "usuarios",
                column: "id_dados_login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_endereco",
                table: "usuarios",
                column: "id_endereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_locais_consulta_id_local_consulta",
                table: "usuarios_locais_consulta",
                column: "id_local_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_locais_consulta_id_usuario",
                table: "usuarios_locais_consulta",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_reunioes_id_reuniao",
                table: "usuarios_reunioes",
                column: "id_reuniao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_reunioes_id_usuario",
                table: "usuarios_reunioes",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_unidades_id_unidade",
                table: "usuarios_unidades",
                column: "id_unidade");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_unidades_id_usuario",
                table: "usuarios_unidades",
                column: "id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documentos_local_consulta");

            migrationBuilder.DropTable(
                name: "documentos_usuarios");

            migrationBuilder.DropTable(
                name: "usuarios_locais_consulta");

            migrationBuilder.DropTable(
                name: "usuarios_reunioes");

            migrationBuilder.DropTable(
                name: "usuarios_unidades");

            migrationBuilder.DropTable(
                name: "reunioes");

            migrationBuilder.DropTable(
                name: "unidade");

            migrationBuilder.DropTable(
                name: "local_consulta");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "contatos");

            migrationBuilder.DropTable(
                name: "dados_login");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
