using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitiliazeCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "History",
                type: "int",
                nullable: true);

          

            migrationBuilder.UpdateData(
                table: "History",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AboutId" },
                values: new object[] { 1, null });

           

            migrationBuilder.UpdateData(
                table: "History",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AboutId" },
                values: new object[] { 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_History_AboutId",
                table: "History",
                column: "AboutId");

            

            migrationBuilder.AddForeignKey(
                name: "FK_History_About_AboutId",
                table: "History",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_About_AboutId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_About_AboutId1",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_AboutId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_AboutId1",
                table: "History");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "History");

            migrationBuilder.DropColumn(
                name: "AboutId1",
                table: "History");
        }
    }
}
