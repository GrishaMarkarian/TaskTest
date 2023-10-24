using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class CarsTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Car_Id { get; set; }
        public string Complectation { get; set; }
        public string Date { get; set; }
        public string Path { get; set; }
        public string? Body { get; set; }
        public string? Grade { get; set; }
        [Column("ATM MTM")]
        public string? ATM_MTM { get; set; }
        [Column("Gear Shift Type")]
        public string? Gear_Shift_Type { get; set; }
        public string? Cab { get; set; }
        [Column("Transmission Model")]
        public string? Transmission_Model { get; set; }
        [Column("Engine 1")]
        public string? Engine_1 { get; set; }
        [Column("Engine 2")]
        public string? Engine_2 { get; set; }
        [Column("Loading Capacity")]
        public string? Loading_Capacity { get; set; }
        [Column("Rear Tire")]
        public string? Rear_Tire { get; set; }
        [Column("Destination")]
        public string? Destination { get; set; }
        [Column("Fuel Induction")]
        public string? Fuel_Induction { get; set; }
        [Column("Bulding Condition")]
        public string? Bulding_Condition { get; set; }
        [Column("Product")]
        public string? Product { get; set; }
        [Column("Drivers Position")]
        public string? Drivers_Position { get; set; }
        [Column("NOOF DOORS")]
        public string? NOOF_DOORS { get; set; }
        [Column("Destination 1")]
        public string? Destination_1 { get; set; }
        [Column("Destination 2")]
        public string? Destination_2 { get; set; }
        [Column("ROOF")]
        public string? ROOF { get; set; }
        [Column("Body 1")]
        public string? Body_1 { get; set; }
        [Column("Body 2")]
        public string? Body_2 { get; set; }
        [Column("Seating Capasity")]
        public string? Seating_Capasity { get; set; }
        [Column("Rear Time")]
        public string? Rear_Time { get; set; }
        [Column("Vehicle Model")]
        public string? Vehicle_Model { get; set; }
        [Column("Side Window")]
        public string? Side_Window { get; set; }
        [Column("Model Mark")]
        public string? Model_Mark { get; set; }
        [Column("Desk")]
        public string? Desk { get; set; }
        [Column("Top Back Door")]
        public string? Top_Back_Dorr { get; set; }
        [Column("Roll Bar")]
        public string? Roll_Bar { get; set; }
        [Column("Emission Regulation")]
        public string? Emission_Regulation { get; set; }
        [Column("Truck or Van")]
        public string? Truck_Or_Van { get; set; }
        [Column("DECK,CAB")]
        public string? DECK_CAB { get; set; }
        [Column("DECK(MATERIAL)")]
        public string? DECK_MATERIAL { get; set; }
    }
}
