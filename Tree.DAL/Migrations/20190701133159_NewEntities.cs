using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tree.DAL.Migrations
{
    public partial class NewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationLayers_Organizations_IdOrganizationId",
                table: "OrganizationLayers");

            migrationBuilder.RenameColumn(
                name: "IdParent",
                table: "OrganizationLayers",
                newName: "IdOrganization");

            migrationBuilder.RenameColumn(
                name: "IdOrganizationId",
                table: "OrganizationLayers",
                newName: "OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationLayers_IdOrganizationId",
                table: "OrganizationLayers",
                newName: "IX_OrganizationLayers_OrganizationId");

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offerings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offerings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryLayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: true),
                    IdCountry = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IdParent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryLayers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryLayers_OrganizationLayers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OrganizationLayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessLayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessId = table.Column<int>(nullable: true),
                    IdBusiness = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IdParent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessLayers_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessLayers_CountryLayers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "CountryLayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamilyLayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FamilyId = table.Column<int>(nullable: true),
                    IdFamily = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IdParent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyLayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyLayers_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamilyLayers_BusinessLayers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BusinessLayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferingLayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferingId = table.Column<int>(nullable: true),
                    IdOffering = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IdParent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferingLayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferingLayers_Offerings_OfferingId",
                        column: x => x.OfferingId,
                        principalTable: "Offerings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OfferingLayers_FamilyLayers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "FamilyLayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentLayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentId = table.Column<int>(nullable: true),
                    IdDepartment = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IdParent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentLayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentLayers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentLayers_OfferingLayers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OfferingLayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLayers_BusinessId",
                table: "BusinessLayers",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLayers_ParentId",
                table: "BusinessLayers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLayers_CountryId",
                table: "CountryLayers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLayers_ParentId",
                table: "CountryLayers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLayers_DepartmentId",
                table: "DepartmentLayers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLayers_ParentId",
                table: "DepartmentLayers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyLayers_FamilyId",
                table: "FamilyLayers",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyLayers_ParentId",
                table: "FamilyLayers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferingLayers_OfferingId",
                table: "OfferingLayers",
                column: "OfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferingLayers_ParentId",
                table: "OfferingLayers",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationLayers_Organizations_OrganizationId",
                table: "OrganizationLayers",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationLayers_Organizations_OrganizationId",
                table: "OrganizationLayers");

            migrationBuilder.DropTable(
                name: "DepartmentLayers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "OfferingLayers");

            migrationBuilder.DropTable(
                name: "Offerings");

            migrationBuilder.DropTable(
                name: "FamilyLayers");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "BusinessLayers");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "CountryLayers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "OrganizationLayers",
                newName: "IdOrganizationId");

            migrationBuilder.RenameColumn(
                name: "IdOrganization",
                table: "OrganizationLayers",
                newName: "IdParent");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationLayers_OrganizationId",
                table: "OrganizationLayers",
                newName: "IX_OrganizationLayers_IdOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationLayers_Organizations_IdOrganizationId",
                table: "OrganizationLayers",
                column: "IdOrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
