using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafehouseBusiness.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_local_consulta_contatos_id_contato",
                table: "local_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_local_consulta_enderecos_id_endereco",
                table: "local_consulta");

            migrationBuilder.AlterColumn<int>(
                name: "id_endereco",
                table: "local_consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_contato",
                table: "local_consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdDocumento",
                table: "local_consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_local_consulta_contatos_id_contato",
                table: "local_consulta",
                column: "id_contato",
                principalTable: "contatos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_local_consulta_enderecos_id_endereco",
                table: "local_consulta",
                column: "id_endereco",
                principalTable: "enderecos",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_local_consulta_contatos_id_contato",
                table: "local_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_local_consulta_enderecos_id_endereco",
                table: "local_consulta");

            migrationBuilder.AlterColumn<int>(
                name: "id_endereco",
                table: "local_consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_contato",
                table: "local_consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdDocumento",
                table: "local_consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_local_consulta_contatos_id_contato",
                table: "local_consulta",
                column: "id_contato",
                principalTable: "contatos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_local_consulta_enderecos_id_endereco",
                table: "local_consulta",
                column: "id_endereco",
                principalTable: "enderecos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
