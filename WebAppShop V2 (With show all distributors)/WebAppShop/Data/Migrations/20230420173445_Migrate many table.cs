using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppShop.Data.Migrations
{
    public partial class Migratemanytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Tent",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "SleapingBag",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Shoe",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Literature",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Food",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Equipment",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Electronic",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Dish",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Clothes",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Caremat",
                newName: "Distributor_Id");

            migrationBuilder.RenameColumn(
                name: "Distributor_id",
                table: "Backpack",
                newName: "Distributor_Id");

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Tent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "SleapingBag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Shoe",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Literature",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Food",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Electronic",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Clothes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Caremat",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Backpack",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tent_DistributorId",
                table: "Tent",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_SleapingBag_DistributorId",
                table: "SleapingBag",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoe_DistributorId",
                table: "Shoe",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Literature_DistributorId",
                table: "Literature",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_DistributorId",
                table: "Food",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_DistributorId",
                table: "Equipment",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Electronic_DistributorId",
                table: "Electronic",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_DistributorId",
                table: "Dish",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_DistributorId",
                table: "Clothes",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Caremat_DistributorId",
                table: "Caremat",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Backpack_DistributorId",
                table: "Backpack",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpack_Distributor_DistributorId",
                table: "Backpack",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Caremat_Distributor_DistributorId",
                table: "Caremat",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Distributor_DistributorId",
                table: "Clothes",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Distributor_DistributorId",
                table: "Dish",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Electronic_Distributor_DistributorId",
                table: "Electronic",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Distributor_DistributorId",
                table: "Equipment",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Distributor_DistributorId",
                table: "Food",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Literature_Distributor_DistributorId",
                table: "Literature",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Distributor_DistributorId",
                table: "Shoe",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SleapingBag_Distributor_DistributorId",
                table: "SleapingBag",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tent_Distributor_DistributorId",
                table: "Tent",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpack_Distributor_DistributorId",
                table: "Backpack");

            migrationBuilder.DropForeignKey(
                name: "FK_Caremat_Distributor_DistributorId",
                table: "Caremat");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Distributor_DistributorId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Distributor_DistributorId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_Electronic_Distributor_DistributorId",
                table: "Electronic");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Distributor_DistributorId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Food_Distributor_DistributorId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Literature_Distributor_DistributorId",
                table: "Literature");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Distributor_DistributorId",
                table: "Shoe");

            migrationBuilder.DropForeignKey(
                name: "FK_SleapingBag_Distributor_DistributorId",
                table: "SleapingBag");

            migrationBuilder.DropForeignKey(
                name: "FK_Tent_Distributor_DistributorId",
                table: "Tent");

            migrationBuilder.DropIndex(
                name: "IX_Tent_DistributorId",
                table: "Tent");

            migrationBuilder.DropIndex(
                name: "IX_SleapingBag_DistributorId",
                table: "SleapingBag");

            migrationBuilder.DropIndex(
                name: "IX_Shoe_DistributorId",
                table: "Shoe");

            migrationBuilder.DropIndex(
                name: "IX_Literature_DistributorId",
                table: "Literature");

            migrationBuilder.DropIndex(
                name: "IX_Food_DistributorId",
                table: "Food");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_DistributorId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Electronic_DistributorId",
                table: "Electronic");

            migrationBuilder.DropIndex(
                name: "IX_Dish_DistributorId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_DistributorId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Caremat_DistributorId",
                table: "Caremat");

            migrationBuilder.DropIndex(
                name: "IX_Backpack_DistributorId",
                table: "Backpack");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Tent");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "SleapingBag");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Shoe");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Literature");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Electronic");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Caremat");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Backpack");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Tent",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "SleapingBag",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Shoe",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Literature",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Food",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Equipment",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Electronic",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Dish",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Clothes",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Caremat",
                newName: "Distributor_id");

            migrationBuilder.RenameColumn(
                name: "Distributor_Id",
                table: "Backpack",
                newName: "Distributor_id");
        }
    }
}
