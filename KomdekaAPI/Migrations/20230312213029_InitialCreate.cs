using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KomdekaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AdmissionOrderDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OrderDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    OrderComments = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CustomerSignature = table.Column<bool>(type: "bit", nullable: false),
                    ContractorSignature = table.Column<bool>(type: "bit", nullable: false),
                    AreRequirementsDefined = table.Column<bool>(type: "bit", nullable: false),
                    AreDocumentsUpToDate = table.Column<bool>(type: "bit", nullable: false),
                    AreQualityApprovalsUpToDate = table.Column<bool>(type: "bit", nullable: false),
                    HaveSuppliersApprovals = table.Column<bool>(type: "bit", nullable: false),
                    HaveProductionAndEquipmentProcedures = table.Column<bool>(type: "bit", nullable: false),
                    HaveControlProcedures = table.Column<bool>(type: "bit", nullable: false),
                    HaveTheResources = table.Column<bool>(type: "bit", nullable: false),
                    HaveEmployeesAndSkills = table.Column<bool>(type: "bit", nullable: false),
                    AreFirstPieceRequirementsDefined = table.Column<bool>(type: "bit", nullable: false),
                    HaveWarehousesAndResources = table.Column<bool>(type: "bit", nullable: false),
                    HasRiskAssessed = table.Column<bool>(type: "bit", nullable: false),
                    IsPriceCorrect = table.Column<bool>(type: "bit", nullable: false),
                    AreDeliveryTermsChecked = table.Column<bool>(type: "bit", nullable: false),
                    OrderReviewResult = table.Column<bool>(type: "bit", nullable: false),
                    OrderNum = table.Column<int>(type: "int", nullable: false),
                    OrderRequirements = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    RequirementsEstablishedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OrderingPersonSignature = table.Column<bool>(type: "bit", nullable: false),
                    ProjectCardNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    OrderingPersonName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProjectTeam = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    ReviewResult = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IdentifiedProblems = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    PlannedActivities = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    VerificationResult = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    EncounteredProblems = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    PlannedWorks = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    ValidationResult = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Problems = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    DescriptionOfChange = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    ShiftCardNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DocName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentOrDrawingNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    AdditionalComments = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    ProjectApproval = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    DesignTeamSignatures = table.Column<bool>(type: "bit", nullable: false),
                    JobGuideNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReleaseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DrawingNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DrawingRelease = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MeltCertificateProof = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrderNr = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    JobGuideContent = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    QualityCertificateNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Purchaser = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrderNbr = table.Column<int>(type: "int", nullable: false),
                    MadeProducts = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    RemarksAndLimitations = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Signature = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CustomerComments = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    TimeSatisfaction = table.Column<int>(type: "int", nullable: false),
                    QualitySatisfaction = table.Column<int>(type: "int", nullable: false),
                    ClientSignature = table.Column<bool>(type: "bit", nullable: false),
                    ExecutingPersonSignature = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdNumber);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    IdNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ActivitiesRange = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ApprovalDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApprovalExpirationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.IdNumber);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    IdNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsMetrologicalService = table.Column<bool>(type: "bit", nullable: true),
                    MetrologicalServiceInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMetrologicalService = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ValidUntil = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.IdNumber);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58db5b56-638e-426f-b82e-a0f4e8a5107f", null, "Pracownik", "PRACOWNIK" },
                    { "8d8b789f-6df1-4019-8dc1-6be66c73d8f8", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
