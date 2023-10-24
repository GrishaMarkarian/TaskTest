using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class MIGR_15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarsTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complectation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATMMTM = table.Column<string>(name: "ATM MTM", type: "nvarchar(max)", nullable: true),
                    GearShiftType = table.Column<string>(name: "Gear Shift Type", type: "nvarchar(max)", nullable: true),
                    Cab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransmissionModel = table.Column<string>(name: "Transmission Model", type: "nvarchar(max)", nullable: true),
                    Engine1 = table.Column<string>(name: "Engine 1", type: "nvarchar(max)", nullable: true),
                    Engine2 = table.Column<string>(name: "Engine 2", type: "nvarchar(max)", nullable: true),
                    LoadingCapacity = table.Column<string>(name: "Loading Capacity", type: "nvarchar(max)", nullable: true),
                    RearTire = table.Column<string>(name: "Rear Tire", type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelInduction = table.Column<string>(name: "Fuel Induction", type: "nvarchar(max)", nullable: true),
                    BuldingCondition = table.Column<string>(name: "Bulding Condition", type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriversPosition = table.Column<string>(name: "Drivers Position", type: "nvarchar(max)", nullable: true),
                    NOOFDOORS = table.Column<string>(name: "NOOF DOORS", type: "nvarchar(max)", nullable: true),
                    Destination1 = table.Column<string>(name: "Destination 1", type: "nvarchar(max)", nullable: true),
                    Destination2 = table.Column<string>(name: "Destination 2", type: "nvarchar(max)", nullable: true),
                    ROOF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body1 = table.Column<string>(name: "Body 1", type: "nvarchar(max)", nullable: true),
                    Body2 = table.Column<string>(name: "Body 2", type: "nvarchar(max)", nullable: true),
                    SeatingCapasity = table.Column<string>(name: "Seating Capasity", type: "nvarchar(max)", nullable: true),
                    RearTime = table.Column<string>(name: "Rear Time", type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(name: "Vehicle Model", type: "nvarchar(max)", nullable: true),
                    SideWindow = table.Column<string>(name: "Side Window", type: "nvarchar(max)", nullable: true),
                    ModelMark = table.Column<string>(name: "Model Mark", type: "nvarchar(max)", nullable: true),
                    Desk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopBackDoor = table.Column<string>(name: "Top Back Door", type: "nvarchar(max)", nullable: true),
                    RollBar = table.Column<string>(name: "Roll Bar", type: "nvarchar(max)", nullable: true),
                    EmissionRegulation = table.Column<string>(name: "Emission Regulation", type: "nvarchar(max)", nullable: true),
                    TruckorVan = table.Column<string>(name: "Truck or Van", type: "nvarchar(max)", nullable: true),
                    DECKCAB = table.Column<string>(name: "DECK,CAB", type: "nvarchar(max)", nullable: true),
                    DECKMATERIAL = table.Column<string>(name: "DECK(MATERIAL)", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarsTables");

            migrationBuilder.DropTable(
                name: "Details");
        }
    }
}
