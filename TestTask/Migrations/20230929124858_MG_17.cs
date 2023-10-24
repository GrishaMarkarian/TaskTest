using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class MG_17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyTables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FRAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUSPENSION_CROSSMEMBER_LINING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPARE_WHEEL_HOLDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAB_MOUNTING_CAB_MOUNTING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_BUMPER_BUMPER_STAY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RADIATOR_GRILLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VISOR_FRONT_FENDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOOD_LOCK_HINGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_FENDER_APRON_DASH_PANEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTROL_PANEL_GLOVE_BOX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOUSING_PANEL_WINDSCREEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_FLOOR_PANEL_FRONT_FLOOR_MEMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FLOOR_INSULATOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAT_SILENCER_PAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROOF_REAR_PANEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_VENTILATOR_CEILING_VENTILATION_NOZZLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INSIDE_TRIM_BOARD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROOF_HEADLINING_SILENCER_PAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_BODY_FLOOR_FENDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_BODY_GUARD_FRAME_TRUNK_DOOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_BODY_SIDE_PANEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_BODY_RETAINER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_DOOR_SIDE_GROOVE_GLAZING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_DOOR_VENTILATOR_WINDOW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_DOOR_LOCK_AND_HANDLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WINDOW_UP_THE_DOOR_DRIVES_HINGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCK_KIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEATS_SEAT_TRACK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEAT_BELT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ARMREST_VISITOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BATTERY_CARRIER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAUTION_PLATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ASH_RECEPTACLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMBLEM_NAME_PLATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONVEX_DECORATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOOL_BOX_LICENSE_PLATE_BRACKET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUEL_TANK_PIPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCELERATOR_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricsTables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HEADLIGHTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_TURN_SIGNAL_LAMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_CLEARANCE_LAMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BACK_LIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_LICENSE_PLATE_LAMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BATTERY_BATTERY_CABLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIRING_TERMINAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANALYZER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TURN_INDICATOR_LIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WINDSCREEN_WIPER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_WIPER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLASS_WASHER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_WASHER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOOR_MOTOR_DOOR_SOLENOID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RADIO_RECEIVER_AMPLIFIER_CONDENSER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPEAKER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANTENNA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MIRROR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_SET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_HEATER_UNIT_IMPELLER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_COOLER_UNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_CONTROL_DUCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_WATER_PIPING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_VACUUM_PIPING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_COOLER_PIPING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEATING_AIR_CONDITIONING_COMPRESSOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ELECTRONIC_FUEL_INJECTION_SYSTEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANTI_LOCK_BRAKE_DEVICES_VSC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLEARANCE_BACK_SONAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIRELESS_DOOR_LOCK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AIRBAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANTI_THEFT_DEVICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAVIGATION_SYSTEM_FRONT_MONITORDISPLAY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricsTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineTables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENGINE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STANDARD_TOOLS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARTIAL_ENGINE_ASSEMBLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHORT_ENGINE_ASSEMBLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GASKET_SET_FOR_ENGINE_OVERHAUL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CYLINDER_HEAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CYLINDER_BLOCK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIMING_COVER_REAR_END_PLATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INSTALLATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VENTILATION_HOSE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRANKSHAFT_PISTONS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAMSHAFT_VALVE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENGINE_OIL_PUMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OIL_FILTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENGINE_OIL_COOLER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WATER_PUMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RADIATOR_WATER_OUTLET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    V_BELT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLLECTOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXHAUST_GAS_PIPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AIR_CLEANER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VACUUM_PIPING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAUTION_PLATE_NAME_PLATE_ENGINE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGNITION_COIL_SPARK_PLUG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENERATORSTARTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VACUUM_PUMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOZZLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INJECTION_PUMP_ASSEMBLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INJECTION_PUMP_BODY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUEL_FILTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXHAUST_GAS_RECIRCULATION_SYSTEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENERATOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INJECTION_POWER_SYSTEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DISTRIBUTOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STARTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CARBURETOR_ASSEMBLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CARBURETOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUEL_PUMP_PIPE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionTables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLUTCH_RELEASE_FORK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PEDAL_FLEXIBLE_HOSE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLUTCH_MASTER_CYLINDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLUTCH_HYDRAULIC_SLAVE_CYLINDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSAXLE_OR_TRANSMISSION_ASSY_GASKET_SET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPEEDOMETER_DRIVE_GEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSMISSION_GEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GEAR_SHIFT_FORK_LEVER_SHAFT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GEAR_SHIFT_LEVER_RETAINER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POWER_TAKE_OFF_CASE_GEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRIVE_SHAFT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSFER_ASSEMBLY_GASKET_SET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSFER_CASE_EXTENSION_HOUSING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSFER_CASE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RANGE_LEVER_SHIFT_ROD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GEARBOX_SHAFT_CROSS_JOINT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WINCH_KIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WINCH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_AXLE_CASE_DIFFERENTIAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_DRIVE_SHAFT_HUB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DISC_WHEEL_WHEEL_CAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_AXLE_CASE_DIFFERENTIAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_DRIVE_SHAFT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_WHEEL_HUB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STEERING_COLUMN_AND_SHAFT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VANE_PUMP_TANK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POWER_STEERING_TUBE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STEERING_WHEEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAKE_PEDAL_BRACKET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HANDBRAKE_CYLINDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAKE_PIPE_TERMINAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_AXLE_ARM_STEERING_KNIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRONT_SPRING_SHOCK_ABSORBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REAR_SPRING_SHOCK_ABSORBER = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionTables", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyTables");

            migrationBuilder.DropTable(
                name: "ElectricsTables");

            migrationBuilder.DropTable(
                name: "EngineTables");

            migrationBuilder.DropTable(
                name: "TransmissionTables");
        }
    }
}
