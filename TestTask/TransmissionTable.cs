using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class TransmissionTable
    {
        public string Id { get; set; }
        public string Car_Id { get; set; }
        public string? CLUTCH_RELEASE_FORK { get; set; }
        public string? PEDAL_FLEXIBLE_HOSE{ get; set; }
        public string? CLUTCH_MASTER_CYLINDER { get; set; }
        public string? CLUTCH_HYDRAULIC_SLAVE_CYLINDER { get; set; }
        public string? TRANSAXLE_OR_TRANSMISSION_ASSY_GASKET_SET { get; set; }
        public string? SPEEDOMETER_DRIVE_GEAR { get; set; }
        public string? TRANSMISSION_GEAR { get; set; }
        public string? GEAR_SHIFT_FORK_LEVER_SHAFT { get; set; }
        public string? GEAR_SHIFT_LEVER_RETAINER { get; set; }
        public string? POWER_TAKE_OFF_CASE_GEAR { get; set; }
        public string? DRIVE_SHAFT { get; set; }
        public string? TRANSFER_ASSEMBLY_GASKET_SET { get; set; }
        public string? TRANSFER_CASE_EXTENSION_HOUSING { get; set; }
        public string? TRANSFER_CASE { get; set; }
        public string? RANGE_LEVER_SHIFT_ROD { get; set; }
        public string? GEARBOX_SHAFT_CROSS_JOINT { get; set; }
        public string? WINCH_KIT { get; set; }
        public string? WINCH { get; set; }
        public string? REAR_AXLE_CASE_DIFFERENTIAL { get; set; }
        public string? REAR_DRIVE_SHAFT_HUB { get; set; }
        public string? DISC_WHEEL_WHEEL_CAP { get; set; }
        public string? FRONT_AXLE_CASE_DIFFERENTIAL { get; set; }
        public string? FRONT_DRIVE_SHAFT { get; set; }
        public string? FRONT_WHEEL_HUB { get; set; }
        public string? STEERING_COLUMN_AND_SHAFT { get; set; }
        public string? VANE_PUMP_TANK { get; set; }
        public string? POWER_STEERING_TUBE { get; set; }
        public string? STEERING_WHEEL { get; set; }
        public string? BRAKE_PEDAL_BRACKET { get; set; }
        public string? HANDBRAKE_CYLINDER { get; set; }
        public string? BRAKE_PIPE_TERMINAL { get; set; }
        public string? FRONT_AXLE_ARM_STEERING_KNIGHT { get; set; }
        public string? FRONT_SPRING_SHOCK_ABSORBER { get; set; }
        public string? REAR_SPRING_SHOCK_ABSORBER { get; set; }
    }
}
