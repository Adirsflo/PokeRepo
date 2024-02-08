using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeRepo.Migrations
{
    /// <inheritdoc />
    public partial class AddingAbilityAndType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbilityModel_Pokemons_pokemon_id",
                table: "AbilityModel");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeModel_Pokemons_pokemon_id",
                table: "TypeModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeModel",
                table: "TypeModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbilityModel",
                table: "AbilityModel");

            migrationBuilder.RenameTable(
                name: "TypeModel",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "AbilityModel",
                newName: "Abilities");

            migrationBuilder.RenameIndex(
                name: "IX_TypeModel_pokemon_id",
                table: "Types",
                newName: "IX_Types_pokemon_id");

            migrationBuilder.RenameIndex(
                name: "IX_AbilityModel_pokemon_id",
                table: "Abilities",
                newName: "IX_Abilities_pokemon_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abilities_Pokemons_pokemon_id",
                table: "Abilities",
                column: "pokemon_id",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Pokemons_pokemon_id",
                table: "Types",
                column: "pokemon_id",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_Pokemons_pokemon_id",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_Pokemons_pokemon_id",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "TypeModel");

            migrationBuilder.RenameTable(
                name: "Abilities",
                newName: "AbilityModel");

            migrationBuilder.RenameIndex(
                name: "IX_Types_pokemon_id",
                table: "TypeModel",
                newName: "IX_TypeModel_pokemon_id");

            migrationBuilder.RenameIndex(
                name: "IX_Abilities_pokemon_id",
                table: "AbilityModel",
                newName: "IX_AbilityModel_pokemon_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeModel",
                table: "TypeModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbilityModel",
                table: "AbilityModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityModel_Pokemons_pokemon_id",
                table: "AbilityModel",
                column: "pokemon_id",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeModel_Pokemons_pokemon_id",
                table: "TypeModel",
                column: "pokemon_id",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
