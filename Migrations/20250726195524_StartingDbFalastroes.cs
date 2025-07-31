using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace falastroes_no_comando.Migrations
{
    /// <inheritdoc />
    public partial class StartingDbFalastroes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Political",
                columns: table => new
                {
                    IdPolitical = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    Status_2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Political", x => x.IdPolitical);
                });

            migrationBuilder.CreateTable(
                name: "Proposal",
                columns: table => new
                {
                    IdProposal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposal", x => x.IdProposal);
                });

            migrationBuilder.CreateTable(
                name: "Political_has_Proposal",
                columns: table => new
                {
                    IdPolitical_has_Proposal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPolitical = table.Column<int>(type: "int", nullable: false),
                    IdProposal = table.Column<int>(type: "int", nullable: false),
                    PoliticalIdPolitical = table.Column<int>(type: "int", nullable: false),
                    ProposalIdProposal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Political_has_Proposal", x => x.IdPolitical_has_Proposal);
                    table.ForeignKey(
                        name: "FK_Political_has_Proposal_Political_PoliticalIdPolitical",
                        column: x => x.PoliticalIdPolitical,
                        principalTable: "Political",
                        principalColumn: "IdPolitical",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Political_has_Proposal_Proposal_ProposalIdProposal",
                        column: x => x.ProposalIdProposal,
                        principalTable: "Proposal",
                        principalColumn: "IdProposal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Political_has_Proposal_PoliticalIdPolitical",
                table: "Political_has_Proposal",
                column: "PoliticalIdPolitical");

            migrationBuilder.CreateIndex(
                name: "IX_Political_has_Proposal_ProposalIdProposal",
                table: "Political_has_Proposal",
                column: "ProposalIdProposal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Political_has_Proposal");

            migrationBuilder.DropTable(
                name: "Political");

            migrationBuilder.DropTable(
                name: "Proposal");
        }
    }
}
