using Microsoft.EntityFrameworkCore.Migrations;

namespace HC_QLDatVeXemPhim.Migrations
{
    public partial class UpdateTableDatVe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "DatVes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "DatVes");
        }
    }
}
