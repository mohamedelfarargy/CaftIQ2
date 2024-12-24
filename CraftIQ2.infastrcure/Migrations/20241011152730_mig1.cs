using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftIQ2.infastrcure.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    _CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Inventroy_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    _InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Reorderlevel = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    _OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TotalAmount = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ExpectedDeliveryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    OrderType = table.Column<int>(type: "int", nullable: true),
                    ReceivedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    _OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderDeatils_Quantity = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    _ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Length = table.Column<float>(type: "real", nullable: true),
                    Width = table.Column<float>(type: "real", nullable: true),
                    Height = table.Column<float>(type: "real", nullable: true),
                    TaxCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitPerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductionCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    TransActionsId = table.Column<int>(type: "int", nullable: true),
                    _TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TransActions_Quantity = table.Column<int>(type: "int", nullable: true),
                    TransactionType = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_OrderId",
                        column: x => x.OrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TransActionsId",
                        column: x => x.TransActionsId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_CategoryId",
                table: "BaseEntities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_OrderId",
                table: "BaseEntities",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductId",
                table: "BaseEntities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TransActionsId",
                table: "BaseEntities",
                column: "TransActionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
