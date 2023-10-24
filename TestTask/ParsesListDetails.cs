using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    internal class ParsesListDetails
    {
        private async Task<List<string>> GetPage(List<CarsTable> Cars)
        {
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (var car in Cars)
            {
                Console.WriteLine(car.Id);
                tasks.Add(URLClass.CallUrl(car.Path));
                await Task.Delay(100);
            }
            IEnumerable<string> results = await Task.WhenAll(tasks);
            return results.ToList();
        }

        public async Task ParseFourPage()
        {

            int Counter = 0;
            var CarsTables = CarsTableParser.GetDataSecondPageDB();
            for (int i = 0; i < CarsTables.Count; i += 100)
            {
                var TCarsTabels = CarsTables.Skip(i).Take(100).ToList();
                var Paths = await GetPage(TCarsTabels);
                foreach (var path in Paths)
                {
                    ParseFourPage(path, CarsTables[Counter].Complectation);
                    Counter++;
                }
                TCarsTabels.Clear();
            }

        }

        private void ParseFourPage(string html, string IdCar)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Contains("name"))
                .ToList();

            var electricsTable = ParseFourPageElectrics(programmerLinks, IdCar);
            var engineTable = ParseFourPageEngine(programmerLinks, IdCar);
            var transmissionTable = ParseFourPageTransmission(programmerLinks, IdCar);
            var bodyTable = ParseFourPageBody(programmerLinks, IdCar);

        }

        private ElectricsTable ParseFourPageElectrics(List<HtmlNode> programmerLinks, string IdCar)
        {
            ElectricsTable electricsTable = new ElectricsTable();
            electricsTable.Id = Guid.NewGuid().ToString();
            electricsTable.Car_Id = IdCar;
            foreach (var link in programmerLinks)
            {
                if (link.InnerText == "ПЕРЕДНИЕ ФАРЫ")
                {
                    electricsTable.HEADLIGHTS = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT TURN SIGNAL LAMP")
                {
                    electricsTable.FRONT_TURN_SIGNAL_LAMP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЗАДНИЙ ФОНАРЬ")
                {
                    electricsTable.BACK_LIGHT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR LICENSE PLATE LAMP")
                {
                    electricsTable.REAR_LICENSE_PLATE_LAMP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "АККУМУЛЯТОР & ПРОВОД АКБ")
                {
                    electricsTable.BATTERY_BATTERY_CABLE = GetHref(link.InnerHtml); ;
                }
                if (link.InnerText == "ЭЛЕКТРОПРОВОДКА & КЛЕММА")
                {
                    electricsTable.WIRING_TERMINAL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "АНАЛИЗАТОР")
                {
                    electricsTable.ANALYZER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ФОНАРЬ УКАЗАТЕЛЯ ПОВОРОТА")
                {
                    electricsTable.TURN_INDICATOR_LIGHT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТЕКЛООЧИСТИТЕЛЬ ВЕТРОВОГО СТЕКЛА")
                {
                    electricsTable.WINDSCREEN_WIPER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТЕКЛООЧИСТИТЕЛЬ ЗАДНИЙ")
                {
                    electricsTable.REAR_WIPER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТЕКЛООМЫВАТЕЛЬ")
                {
                    electricsTable.GLASS_WASHER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR WASHER")
                {
                    electricsTable.REAR_WASHER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "DOOR MOTOR & DOOR SOLENOID")
                {
                    electricsTable.DOOR_MOTOR_DOOR_SOLENOID = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "RADIO RECEIVER & УСИЛИТЕЛЬ & КОНДЕНСАТОР")
                {
                    electricsTable.RADIO_RECEIVER_AMPLIFIER_CONDENSER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ДИНАМИК")
                {
                    electricsTable.SPEAKER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "АНТЕННА")
                {
                    electricsTable.ANTENNA = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЗЕРКАЛО")
                {
                    electricsTable.MIRROR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - SET")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_SET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - HEATER UNIT & КРЫЛЬЧАТКА")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_HEATER_UNIT_IMPELLER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - COOLER UNIT")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_COOLER_UNIT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - WATER PIPING")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_WATER_PIPING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - VACUUM PIPING")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_VACUUM_PIPING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - COOLER PIPING")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_COOLER_PIPING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДОГРЕВ & AIR CONDITIONING - COMPRESSOR")
                {
                    electricsTable.HEATING_AIR_CONDITIONING_COMPRESSOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ELECTRONIC FUEL INJECTION SYSTEM")
                {
                    electricsTable.ELECTRONIC_FUEL_INJECTION_SYSTEM = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "CLEARANCE & BACK SONAR")
                {
                    electricsTable.CLEARANCE_BACK_SONAR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "WIRELESS DOOR LOCK")
                {
                    electricsTable.WIRELESS_DOOR_LOCK = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДУШКА БЕЗОПАСНОСТИ")
                {
                    electricsTable.AIRBAG = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПРОТИВОУГОННОЕ УСТОЙСТВО")
                {
                    electricsTable.ANTI_THEFT_DEVICE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR WASHER")
                {
                    electricsTable.REAR_WASHER = GetHref(link.InnerHtml);
                }
                if (link.InnerHtml == "СИСТЕМА НАВИГАЦИИ & FRONT MONITOR DISPLAY")
                {
                    electricsTable.NAVIGATION_SYSTEM_FRONT_MONITORDISPLAY = GetHref(link.InnerHtml);
                }

            }
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.ElectricsTables.Add(electricsTable);
            applicationContext.SaveChanges();

            return electricsTable;

        }

        private EngineTable ParseFourPageEngine(List<HtmlNode> programmerLinks, string IdCar)
        {

            EngineTable engineTable = new EngineTable();
            engineTable.Id = Guid.NewGuid().ToString();
            engineTable.Car_Id = IdCar;
            foreach (var link in programmerLinks)
            {
                if (link.InnerText == "ДВИГАТЕЛЬ")
                {
                    engineTable.ENGINE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТАНДАРТНЫЕ ИНСТРУМЕНТЫ")
                {
                    engineTable.STANDARD_TOOLS = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЧАСТИЧНАЯ СБОРКА ДВИГАТЕЛЯ")
                {
                    engineTable.PARTIAL_ENGINE_ASSEMBLY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОРОТКИЙ ДВИГАТЕЛЬ В СБОРЕ")
                {
                    engineTable.SHORT_ENGINE_ASSEMBLY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОМПЛЕКТ ПРОКЛАДОК ДЛЯ КАПИТАЛЬНОГО РЕМОНТА ДВИГАТЕЛЯ")
                {
                    engineTable.GASKET_SET_FOR_ENGINE_OVERHAUL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ГОЛОВКА БЛОКА ЦИЛИНДРОВ")
                {
                    engineTable.CYLINDER_HEAD = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "БЛОК ЦИЛИНДРОВ")
                {
                    engineTable.CYLINDER_BLOCK = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КРЫШКА ГАЗОРАСПРЕДЕЛИТЕЛЬНОГО МЕХАНИЗМА & ЗАДНЯЯ ТОРЦЕВАЯ ПЛАСТИНА")
                {
                    engineTable.TIMING_COVER_REAR_END_PLATE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "МОНТАЖ")
                {
                    engineTable.INSTALLATION = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВЕНТИЛЯЦИОННЫЙ ШЛАНГ")
                {
                    engineTable.VENTILATION_HOSE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОЛЕНВАЛ & ПОРШНИ")
                {
                    engineTable.CRANKSHAFT_PISTONS = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАСПРЕДВАЛ & КЛАПАНА")
                {
                    engineTable.CAMSHAFT_VALVE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "МАСЛЯНЫЙ НАСОС ДВИГАТЕЛЯ")
                {
                    engineTable.ENGINE_OIL_PUMP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "МАСЛЯНЫЙ ФИЛЬТР")
                {
                    engineTable.OIL_FILTER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ОХЛАДИТЕЛЬ МОТОРНОГО МАСЛА")
                {
                    engineTable.ENGINE_OIL_COOLER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВОДЯНОЙ НАСОС")
                {
                    engineTable.WATER_PUMP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАДИАТОР & ВЫХОД ВОДЫ")
                {
                    engineTable.RADIATOR_WATER_OUTLET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КЛИНОВОЙ РЕМЕНЬ")
                {
                    engineTable.V_BELT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОЛЛЕКТОР")
                {
                    engineTable.COLLECTOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТРУБА ВЫХЛОПНОГО ГАЗА")
                {
                    engineTable.EXHAUST_GAS_PIPE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВОЗДУХООЧИСТИТЕЛЬ")
                {
                    engineTable.AIR_CLEANER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "VACUUM PIPING")
                {
                    engineTable.VACUUM_PIPING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "CAUTION PLATE & NAME PLATE (ДВИГАТЕЛЬ)")
                {
                    engineTable.CAUTION_PLATE_NAME_PLATE_ENGINE = GetHref(link.InnerHtml);

                }
                if (link.InnerText == "КАТУШКА ЗАЖИГАНИЯ & СВЕЧА ЗАЖИГАНИЯ")
                {
                    engineTable.IGNITION_COIL_SPARK_PLUG = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ГЕНЕРАТОРСТАРТЕР")
                {
                    engineTable.GENERATORSTARTER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВАКУУМНЫЙ НАСОС")
                {
                    engineTable.VACUUM_PUMP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ФОРСУНКА")
                {
                    engineTable.NOZZLE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "INJECTION PUMP ASSEMBLY")
                {
                    engineTable.INJECTION_PUMP_ASSEMBLY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "INJECTION PUMP BODY")
                {
                    engineTable.INJECTION_PUMP_BODY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТОПЛИВНЫЙ ФИЛЬТР")
                {
                    engineTable.FUEL_FILTER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СИСТЕМА РЕЦИРКУЛЯЦИИ ВЫХЛОПНЫХ ГАЗОВ")
                {
                    engineTable.EXHAUST_GAS_RECIRCULATION_SYSTEM = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ГЕНЕРАТОР")
                {
                    engineTable.GENERATOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ИНЖЕКЦИОННАЯ СИСТЕМА ЗАПИТКИ")
                {
                    engineTable.INJECTION_POWER_SYSTEM = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАСПРЕДЕЛИТЕЛЬ ЗАЖИГАНИЯ")
                {
                    engineTable.DISTRIBUTOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТАРТЕР")
                {
                    engineTable.STARTER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КАРБЮРАТОР В СБОРЕ")
                {
                    engineTable.CARBURETOR_ASSEMBLY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КАРБЮРАТОР")
                {
                    engineTable.CARBURETOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТОПЛИВНЫЙ НАСОС & ТРУБА")
                {
                    engineTable.FUEL_PUMP_PIPE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТОПЛИВНЫЙ ФИЛЬТР")
                {
                    engineTable.FUEL_FILTER = GetHref(link.InnerHtml);
                }
            }
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.EngineTables.Add(engineTable);
            applicationContext.SaveChanges();

            return engineTable;
        }

        private TransmissionTable ParseFourPageTransmission(List<HtmlNode> programmerLinks, string IdCar)
        {
            TransmissionTable transmissionTable = new TransmissionTable();
            transmissionTable.Id = Guid.NewGuid().ToString();
            transmissionTable.Car_Id = IdCar;
            foreach (var link in programmerLinks)
            {
                if (link.InnerText == "ВИЛКА ВЫКЛЮЧЕНИЯ СЦЕПЛЕНИЯ")
                {
                    transmissionTable.CLUTCH_RELEASE_FORK = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПЕДАЛЬ & FLEXIBLE HOSE")
                {
                    transmissionTable.PEDAL_FLEXIBLE_HOSE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ГЛАВНЫЙ ЦИЛИНДР СЦЕПЛЕНИЯ")
                {
                    transmissionTable.CLUTCH_MASTER_CYLINDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАБОЧИЙ ЦИЛИНДР ГИДРОПРИВОДА СЦЕПЛЕНИЯ")
                {
                    transmissionTable.CLUTCH_HYDRAULIC_SLAVE_CYLINDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "TRANSAXLE OR TRANSMISSION ASSY & НАБОР ПРОКЛАДОК (MTM)")
                {
                    transmissionTable.TRANSAXLE_OR_TRANSMISSION_ASSY_GASKET_SET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВЕДОМАЯ ШЕСТЕРНЯ ПРИВОДА СПИДОМЕТРА (MTM)")
                {
                    transmissionTable.SPEEDOMETER_DRIVE_GEAR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ШЕСТЕРНЯ КОРОБКИ ПЕРЕДАЧ (MTM)")
                {
                    transmissionTable.TRANSMISSION_GEAR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "GEAR SHIFT FORK & LEVER SHAFT (MTM)")
                {
                    transmissionTable.GEAR_SHIFT_FORK_LEVER_SHAFT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РЫЧАГ ПЕРЕКЛЮЧЕНИЯ ПЕРЕДАЧ & ФИКСАТОР")
                {
                    transmissionTable.GEAR_SHIFT_LEVER_RETAINER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "POWER TAKE-OFF CASE & ШЕСТЕРНЯ")
                {
                    transmissionTable.POWER_TAKE_OFF_CASE_GEAR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПРИВОДНОЙ ВАЛ")
                {
                    transmissionTable.DRIVE_SHAFT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "TRANSFER ASSEMBLY & НАБОР ПРОКЛАДОК")
                {
                    transmissionTable.TRANSFER_ASSEMBLY_GASKET_SET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАЗДАТОЧНАЯ КОРОБКА & EXTENSION HOUSING")
                {
                    transmissionTable.TRANSFER_CASE_EXTENSION_HOUSING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РАЗДАТОЧНАЯ КОРОБКА")
                {
                    transmissionTable.TRANSFER_CASE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "PЫЧАГ ДЕМУЛЬТИПЛИКАТОРА & ШТОК ВИЛКИ ПЕРЕКЛЮЧЕНИЯ ПЕРЕДАЧ")
                {
                    transmissionTable.RANGE_LEVER_SHIFT_ROD = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПЕРЕДАТОЧ. ВАЛ & КАРДАННЫЙ ШАРНИР С КРЕСТОВИНОЙ")
                {
                    transmissionTable.GEARBOX_SHAFT_CROSS_JOINT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "WINCH KIT")
                {
                    transmissionTable.WINCH_KIT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЛЕБЕДКА")
                {
                    transmissionTable.WINCH = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КАРТЕР ЗАДНЕЙ ОСИ & ДИФФЕРЕНЦИАЛ")
                {
                    transmissionTable.REAR_AXLE_CASE_DIFFERENTIAL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВАЛ ПРИВОДА ЗАДНИХ КОЛЕС & СТУПИЦА")
                {
                    transmissionTable.REAR_DRIVE_SHAFT_HUB = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ДИСКОВОЕ КОЛЕСО & WHEEL CAP")
                {
                    transmissionTable.DISC_WHEEL_WHEEL_CAP = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КАРТЕР ПЕРЕДНЕГО МОСТА & ДИФФЕРЕНЦИАЛ")
                {
                    transmissionTable.FRONT_AXLE_CASE_DIFFERENTIAL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT DRIVE SHAFT")
                {
                    transmissionTable.FRONT_DRIVE_SHAFT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТУПИЦА ПЕРЕДНЕГО КОЛЕСА")
                {
                    transmissionTable.FRONT_WHEEL_HUB = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РУЛЕВАЯ КОЛОНКА И ВАЛ")
                {
                    transmissionTable.STEERING_COLUMN_AND_SHAFT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЛОПАСТНОЙ НАСОС & БАК (РУЛЕВОЙ МЕХАНИЗМ С УСИЛИТЕЛЕМ)")
                {
                    transmissionTable.VANE_PUMP_TANK = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "POWER STEERING TUBE")
                {
                    transmissionTable.POWER_STEERING_TUBE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РУЛЕВОЕ КОЛЕСО")
                {
                    transmissionTable.STEERING_WHEEL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПЕДАЛЬ ТОРМОЗА & СКОБА")
                {
                    transmissionTable.BRAKE_PEDAL_BRACKET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЦЕЛИНДЕР РУЧНОГО ТОРМОЗА")
                {
                    transmissionTable.HANDBRAKE_CYLINDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТОРМОЗНОЙ ТРУБОПРОВОД & КЛЕММА")
                {
                    transmissionTable.BRAKE_PIPE_TERMINAL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT AXLE ARM & ПОВОРОТНЫЙ КУЛАК")
                {
                    transmissionTable.FRONT_AXLE_ARM_STEERING_KNIGHT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПЕРЕДЖНЯЯ ПРУЖИНА & АМОРТИЗАТОР")
                {
                    transmissionTable.FRONT_SPRING_SHOCK_ABSORBER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЗАДНЯЯ ПРУЖИНА & АМОРТИЗАТОР")
                {
                    transmissionTable.REAR_SPRING_SHOCK_ABSORBER = GetHref(link.InnerHtml);
                }
            }
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.TransmissionTables.Add(transmissionTable);
            applicationContext.SaveChanges();

            return transmissionTable;
        }

        private BodyTable ParseFourPageBody(List<HtmlNode> programmerLinks, string IdCar)
        {
            BodyTable bodyTable = new BodyTable();
            bodyTable.Id = Guid.NewGuid().ToString();
            bodyTable.Car_Id = IdCar;
            foreach (var link in programmerLinks)
            {
                if (link.InnerText == "РАМА")
                {
                    bodyTable.FRAME = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "SUSPENSION CROSSMEMBER & ПОДКЛАДКА")
                {
                    bodyTable.SUSPENSION_CROSSMEMBER_LINING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ДЕРЖАТЕЛЬ ЗАПАСНОГО КОЛЕСА")
                {
                    bodyTable.SPARE_WHEEL_HOLDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ОПОРА КАБИНЫ & КРЕПЛЕНИЕ КАБИНЫ")
                {
                    bodyTable.CAB_MOUNTING_CAB_MOUNTING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПЕРЕДНИЙ БАМПЕР & BUMPER STAY")
                {
                    bodyTable.FRONT_BUMPER_BUMPER_STAY = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РЕШЕТКА РАДИАТОРА")
                {
                    bodyTable.RADIATOR_GRILLE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОЗЫРЕК & КРЫЛО ПЕРЕДНЕЕ")
                {
                    bodyTable.VISOR_FRONT_FENDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЗАПОРНЫЙ МЕХАНИЗМ КАПОТА & ШАРНИР")
                {
                    bodyTable.HOOD_LOCK_HINGE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT FENDER APRON & DASH PANEL")
                {
                    bodyTable.FRONT_FENDER_APRON_DASH_PANEL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПАНЕЛЬ УПРАВЛЕНИЯ & ВЕЩЕВОЙ ЯЩИК")
                {
                    bodyTable.CONTROL_PANEL_GLOVE_BOX = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПАНЕЛЬ КОЖУХА & ВЕТРОВОЕ СТЕКЛО")
                {
                    bodyTable.HOUSING_PANEL_WINDSCREEN = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT FLOOR PANEL & FRONT FLOOR MEMBER")
                {
                    bodyTable.FRONT_FLOOR_PANEL_FRONT_FLOOR_MEMBER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FLOOR INSULATOR")
                {
                    bodyTable.FLOOR_INSULATOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОВРИК & SILENCER PAD")
                {
                    bodyTable.MAT_SILENCER_PAD = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЛОНЖЕРОН")
                {
                    bodyTable.SPAR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КРЫША & ПАНЕЛЬ ЗАДНЯЯ")
                {
                    bodyTable.ROOF_REAR_PANEL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR VENTILATOR & ПОТОЛОЧНОЕ СОПЛО ВЕНТИЛЯЦИИ")
                {
                    bodyTable.REAR_VENTILATOR_CEILING_VENTILATION_NOZZLE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "INSIDE TRIM BOARD")
                {
                    bodyTable.INSIDE_TRIM_BOARD = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ROOF HEADLINING & SILENCER PAD")
                {
                    bodyTable.ROOF_HEADLINING_SILENCER_PAD = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR BODY FLOOR & КРЫЛО")
                {
                    bodyTable.REAR_BODY_FLOOR_FENDER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR BODY GUARD FRAME & ДВЕРЬ БАГАЖНИКА")
                {
                    bodyTable.REAR_BODY_GUARD_FRAME_TRUNK_DOOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "REAR BODY SIDE PANEL")
                {
                    bodyTable.REAR_BODY_SIDE_PANEL = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ФИКСАТОР КУЗОВА ЗАДНИЙ")
                {
                    bodyTable.REAR_BODY_RETAINER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "БОКОВОЙ ПАЗ ПЕРЕДНЕЙ ДВЕРИ & ОСТЕКЛЕНИЕ")
                {
                    bodyTable.FRONT_DOOR_SIDE_GROOVE_GLAZING = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "FRONT DOOR VENTILATOR WINDOW")
                {
                    bodyTable.FRONT_DOOR_VENTILATOR_WINDOW = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЗАМОК ПЕРЕДНЕЙ ДВЕРИ И РУЧКА")
                {
                    bodyTable.FRONT_DOOR_LOCK_AND_HANDLE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СТЕКЛОПОДЪЕМ. ДВЕРЬ ВОДИТ. & ШАРНИР")
                {
                    bodyTable.WINDOW_UP_THE_DOOR_DRIVES_HINGE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "КОМПЛЕКТ ЗАМКА")
                {
                    bodyTable.LOCK_KIT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "СИДЕНИЯ & SEAT TRACK")
                {
                    bodyTable.SEATS_SEAT_TRACK = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "РЕМЕНЬ БЕЗОПАСНОСТ")
                {
                    bodyTable.SEAT_BELT = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ПОДЛОКОТНИК & ВИЗИР")
                {
                    bodyTable.ARMREST_VISITOR = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "BATTERY CARRIER")
                {
                    bodyTable.BATTERY_CARRIER = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "CAUTION PLATE")
                {
                    bodyTable.CAUTION_PLATE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ASH RECEPTACLE")
                {
                    bodyTable.ASH_RECEPTACLE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ЭМБЛЕМА & NAME PLATE")
                {
                    bodyTable.EMBLEM_NAME_PLATE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ВЫПУКЛОЕ УКРАШЕНИЕ")
                {
                    bodyTable.CONVEX_DECORATION = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ИНСТРУМЕНТАЛЬНЫЙ ЯЩИК & КРОНШТЕЙН НОМЕРНОГО ЗНАКА")
                {
                    bodyTable.TOOL_BOX_LICENSE_PLATE_BRACKET = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ТОПЛИВНЫЙ БАК & ТРУБКА")
                {
                    bodyTable.FUEL_TANK_PIPE = GetHref(link.InnerHtml);
                }
                if (link.InnerText == "ACCELERATOR LINK")
                {
                    bodyTable.ACCELERATOR_LINK = GetHref(link.InnerHtml);
                }
            }
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.BodyTables.Add(bodyTable);
            applicationContext.SaveChanges();

            return bodyTable;

        }
        private string GetHref(string href)
        {
            return Regex.Match(href, "<a [^>]*href=(?:'(?<href>.*?)')|(?:\"(?<href>.*?)\")").Groups["href"].Value;
        }
    }
}
