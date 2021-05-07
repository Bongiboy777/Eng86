using Microsoft.EntityFrameworkCore.Migrations;

namespace GameData.Migrations
{
    public partial class attempt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elementals",
                columns: table => new
                {
                    ElementalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fire = table.Column<int>(type: "int", nullable: false),
                    Electricity = table.Column<int>(type: "int", nullable: false),
                    Ice = table.Column<int>(type: "int", nullable: false),
                    Poison = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elementals", x => x.ElementalID);
                });

            migrationBuilder.CreateTable(
                name: "PartyMember",
                columns: table => new
                {
                    PartyMemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    XP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyMember", x => x.PartyMemberID);
                });

            migrationBuilder.CreateTable(
                name: "Damages",
                columns: table => new
                {
                    DamageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strike = table.Column<int>(type: "int", nullable: false),
                    Blunt = table.Column<int>(type: "int", nullable: false),
                    Pierce = table.Column<int>(type: "int", nullable: false),
                    ElementalDamageElementalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damages", x => x.DamageID);
                    table.ForeignKey(
                        name: "FK_Damages_Elementals_ElementalDamageElementalID",
                        column: x => x.ElementalDamageElementalID,
                        principalTable: "Elementals",
                        principalColumn: "ElementalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guns",
                columns: table => new
                {
                    GunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireRate = table.Column<int>(type: "int", nullable: false),
                    PartyMemberID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guns", x => x.GunID);
                    table.ForeignKey(
                        name: "FK_Guns_PartyMember_PartyMemberID",
                        column: x => x.PartyMemberID,
                        principalTable: "PartyMember",
                        principalColumn: "PartyMemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ammos",
                columns: table => new
                {
                    AmmoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DamageID = table.Column<int>(type: "int", nullable: true),
                    GunID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammos", x => x.AmmoID);
                    table.ForeignKey(
                        name: "FK_Ammos_Damages_DamageID",
                        column: x => x.DamageID,
                        principalTable: "Damages",
                        principalColumn: "DamageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ammos_Guns_GunID",
                        column: x => x.GunID,
                        principalTable: "Guns",
                        principalColumn: "GunID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ammos_DamageID",
                table: "Ammos",
                column: "DamageID");

            migrationBuilder.CreateIndex(
                name: "IX_Ammos_GunID",
                table: "Ammos",
                column: "GunID");

            migrationBuilder.CreateIndex(
                name: "IX_Damages_ElementalDamageElementalID",
                table: "Damages",
                column: "ElementalDamageElementalID");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_PartyMemberID",
                table: "Guns",
                column: "PartyMemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ammos");

            migrationBuilder.DropTable(
                name: "Damages");

            migrationBuilder.DropTable(
                name: "Guns");

            migrationBuilder.DropTable(
                name: "Elementals");

            migrationBuilder.DropTable(
                name: "PartyMember");
        }
    }
}
