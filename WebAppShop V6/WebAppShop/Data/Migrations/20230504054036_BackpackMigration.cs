using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppShop.Data.Migrations
{
    public partial class BackpackMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_Tent",
                table: "Tent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SleapingBag",
                table: "SleapingBag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoe",
                table: "Shoe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Literature",
                table: "Literature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Food",
                table: "Food");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Electronic",
                table: "Electronic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clothes",
                table: "Clothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caremat",
                table: "Caremat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpack",
                table: "Backpack");

            migrationBuilder.DropColumn(
                name: "Distributor_Id",
                table: "Backpack");

            migrationBuilder.RenameTable(
                name: "Tent",
                newName: "Tents");

            migrationBuilder.RenameTable(
                name: "SleapingBag",
                newName: "SleapingBags");

            migrationBuilder.RenameTable(
                name: "Shoe",
                newName: "Shoes");

            migrationBuilder.RenameTable(
                name: "Literature",
                newName: "Literatures");

            migrationBuilder.RenameTable(
                name: "Food",
                newName: "Foods");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Equipments");

            migrationBuilder.RenameTable(
                name: "Electronic",
                newName: "Electronics");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "Dishs");

            migrationBuilder.RenameTable(
                name: "Clothes",
                newName: "Clothess");

            migrationBuilder.RenameTable(
                name: "Caremat",
                newName: "Caremats");

            migrationBuilder.RenameTable(
                name: "Backpack",
                newName: "Backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_Tent_DistributorId",
                table: "Tents",
                newName: "IX_Tents_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_SleapingBag_DistributorId",
                table: "SleapingBags",
                newName: "IX_SleapingBags_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_DistributorId",
                table: "Shoes",
                newName: "IX_Shoes_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Literature_DistributorId",
                table: "Literatures",
                newName: "IX_Literatures_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Food_DistributorId",
                table: "Foods",
                newName: "IX_Foods_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_DistributorId",
                table: "Equipments",
                newName: "IX_Equipments_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Electronic_DistributorId",
                table: "Electronics",
                newName: "IX_Electronics_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Dish_DistributorId",
                table: "Dishs",
                newName: "IX_Dishs_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Clothes_DistributorId",
                table: "Clothess",
                newName: "IX_Clothess_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Caremat_DistributorId",
                table: "Caremats",
                newName: "IX_Caremats_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Backpack_DistributorId",
                table: "Backpacks",
                newName: "IX_Backpacks_DistributorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tents",
                table: "Tents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SleapingBags",
                table: "SleapingBags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoes",
                table: "Shoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Literatures",
                table: "Literatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Electronics",
                table: "Electronics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishs",
                table: "Dishs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clothess",
                table: "Clothess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caremats",
                table: "Caremats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Distributors_DistributorId",
                table: "Backpacks",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Caremats_Distributors_DistributorId",
                table: "Caremats",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothess_Distributors_DistributorId",
                table: "Clothess",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishs_Distributors_DistributorId",
                table: "Dishs",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Electronics_Distributors_DistributorId",
                table: "Electronics",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Distributors_DistributorId",
                table: "Equipments",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Distributors_DistributorId",
                table: "Foods",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Literatures_Distributors_DistributorId",
                table: "Literatures",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Distributors_DistributorId",
                table: "Shoes",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SleapingBags_Distributors_DistributorId",
                table: "SleapingBags",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tents_Distributors_DistributorId",
                table: "Tents",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Distributors_DistributorId",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Caremats_Distributors_DistributorId",
                table: "Caremats");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothess_Distributors_DistributorId",
                table: "Clothess");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishs_Distributors_DistributorId",
                table: "Dishs");

            migrationBuilder.DropForeignKey(
                name: "FK_Electronics_Distributors_DistributorId",
                table: "Electronics");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Distributors_DistributorId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Distributors_DistributorId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Literatures_Distributors_DistributorId",
                table: "Literatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Distributors_DistributorId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_SleapingBags_Distributors_DistributorId",
                table: "SleapingBags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tents_Distributors_DistributorId",
                table: "Tents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tents",
                table: "Tents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SleapingBags",
                table: "SleapingBags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoes",
                table: "Shoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Literatures",
                table: "Literatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Electronics",
                table: "Electronics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishs",
                table: "Dishs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clothess",
                table: "Clothess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caremats",
                table: "Caremats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks");

            migrationBuilder.RenameTable(
                name: "Tents",
                newName: "Tent");

            migrationBuilder.RenameTable(
                name: "SleapingBags",
                newName: "SleapingBag");

            migrationBuilder.RenameTable(
                name: "Shoes",
                newName: "Shoe");

            migrationBuilder.RenameTable(
                name: "Literatures",
                newName: "Literature");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "Food");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment");

            migrationBuilder.RenameTable(
                name: "Electronics",
                newName: "Electronic");

            migrationBuilder.RenameTable(
                name: "Dishs",
                newName: "Dish");

            migrationBuilder.RenameTable(
                name: "Clothess",
                newName: "Clothes");

            migrationBuilder.RenameTable(
                name: "Caremats",
                newName: "Caremat");

            migrationBuilder.RenameTable(
                name: "Backpacks",
                newName: "Backpack");

            migrationBuilder.RenameIndex(
                name: "IX_Tents_DistributorId",
                table: "Tent",
                newName: "IX_Tent_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_SleapingBags_DistributorId",
                table: "SleapingBag",
                newName: "IX_SleapingBag_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_DistributorId",
                table: "Shoe",
                newName: "IX_Shoe_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Literatures_DistributorId",
                table: "Literature",
                newName: "IX_Literature_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Foods_DistributorId",
                table: "Food",
                newName: "IX_Food_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_DistributorId",
                table: "Equipment",
                newName: "IX_Equipment_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Electronics_DistributorId",
                table: "Electronic",
                newName: "IX_Electronic_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishs_DistributorId",
                table: "Dish",
                newName: "IX_Dish_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Clothess_DistributorId",
                table: "Clothes",
                newName: "IX_Clothes_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Caremats_DistributorId",
                table: "Caremat",
                newName: "IX_Caremat_DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Backpacks_DistributorId",
                table: "Backpack",
                newName: "IX_Backpack_DistributorId");

            migrationBuilder.AddColumn<int>(
                name: "Distributor_Id",
                table: "Backpack",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tent",
                table: "Tent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SleapingBag",
                table: "SleapingBag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoe",
                table: "Shoe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Literature",
                table: "Literature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Food",
                table: "Food",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Electronic",
                table: "Electronic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clothes",
                table: "Clothes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caremat",
                table: "Caremat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpack",
                table: "Backpack",
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
    }
}
