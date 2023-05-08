using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppShop.Data.Migrations
{
    public partial class DistributorMigrateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor");

            migrationBuilder.RenameTable(
                name: "Distributor",
                newName: "Distributors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpack_Distributors_DistributorId",
                table: "Backpack",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Caremat_Distributors_DistributorId",
                table: "Caremat",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Distributors_DistributorId",
                table: "Clothes",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Distributors_DistributorId",
                table: "Dish",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Electronic_Distributors_DistributorId",
                table: "Electronic",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Distributors_DistributorId",
                table: "Equipment",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Distributors_DistributorId",
                table: "Food",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Literature_Distributors_DistributorId",
                table: "Literature",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Distributors_DistributorId",
                table: "Shoe",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SleapingBag_Distributors_DistributorId",
                table: "SleapingBag",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tent_Distributors_DistributorId",
                table: "Tent",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpack_Distributors_DistributorId",
                table: "Backpack");

            migrationBuilder.DropForeignKey(
                name: "FK_Caremat_Distributors_DistributorId",
                table: "Caremat");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Distributors_DistributorId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Distributors_DistributorId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_Electronic_Distributors_DistributorId",
                table: "Electronic");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Distributors_DistributorId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Food_Distributors_DistributorId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Literature_Distributors_DistributorId",
                table: "Literature");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Distributors_DistributorId",
                table: "Shoe");

            migrationBuilder.DropForeignKey(
                name: "FK_SleapingBag_Distributors_DistributorId",
                table: "SleapingBag");

            migrationBuilder.DropForeignKey(
                name: "FK_Tent_Distributors_DistributorId",
                table: "Tent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors");

            migrationBuilder.RenameTable(
                name: "Distributors",
                newName: "Distributor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor",
                column: "Id");

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
    }
}
