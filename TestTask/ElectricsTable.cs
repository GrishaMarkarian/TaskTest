using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestTask
{
    internal class ElectricsTable
    {
        public string Id { get; set; }
        public string Car_Id { get; set; }
        public string? HEADLIGHTS { get; set; }
        public string? FRONT_TURN_SIGNAL_LAMP { get; set; }
        public string? FRONT_CLEARANCE_LAMP { get; set; }
        public string? BACK_LIGHT { get; set; }
        public string? REAR_LICENSE_PLATE_LAMP { get; set; }
        public string? BATTERY_BATTERY_CABLE { get; set; }
        public string? WIRING_TERMINAL { get; set; }
        public string? ANALYZER { get; set; }
        public string? TURN_INDICATOR_LIGHT { get; set; }
        public string? WINDSCREEN_WIPER { get; set; }
        public string? REAR_WIPER { get; set; }
        public string? GLASS_WASHER { get; set; }
        public string? REAR_WASHER { get; set; }
        public string? DOOR_MOTOR_DOOR_SOLENOID { get; set; }
        public string? RADIO_RECEIVER_AMPLIFIER_CONDENSER { get; set; }
        public string? SPEAKER { get; set; }
        public string? ANTENNA { get; set; }
        public string? MIRROR { get; set; }
        public string? HEATING_AIR_CONDITIONING_SET { get; set; }
        public string? HEATING_AIR_CONDITIONING_HEATER_UNIT_IMPELLER { get; set; }
        public string? HEATING_AIR_CONDITIONING_COOLER_UNIT { get; set; }
        public string? HEATING_AIR_CONDITIONING_CONTROL_DUCT { get; set; }
        public string? HEATING_AIR_CONDITIONING_WATER_PIPING { get; set; }
        public string? HEATING_AIR_CONDITIONING_VACUUM_PIPING { get; set; }
        public string? HEATING_AIR_CONDITIONING_COOLER_PIPING { get; set; }
        public string? HEATING_AIR_CONDITIONING_COMPRESSOR { get; set; }
        public string? ELECTRONIC_FUEL_INJECTION_SYSTEM { get; set; }
        public string? ANTI_LOCK_BRAKE_DEVICES_VSC { get; set; }
        public string? CLEARANCE_BACK_SONAR { get; set; }
        public string? WIRELESS_DOOR_LOCK { get; set; }
        public string? AIRBAG { get; set; }
        public string? ANTI_THEFT_DEVICE { get; set; }
        public string? NAVIGATION_SYSTEM_FRONT_MONITORDISPLAY { get; set; }
    }
}
