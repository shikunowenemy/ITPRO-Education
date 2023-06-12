List<string> _cargo = new List<string> { "Шоколадки, печеньки, чай" };
PassengerAirplane _passengerAirplane = new PassengerAirplane("Москва – Казань", 15000, 30, "Аэрофлот", "911", 3000, 10000);
CargoAirplane _cargoAirplane = new CargoAirplane(10000, _cargo, 100, 20, "Airobus", "129-227", 2000, 6000);
PassengerCar _passengerCar = new PassengerCar("Premium", 'B', 200, "Jaguar", "X-Trail", 900, 400);
Truck _truck = new Truck(500, _cargo, 'D', 80, "Mercedes", "670", 1200, 120);
Train _train = new Train(10, "РЖД", "Ласточка", 20000, 800);

Console.WriteLine("Пассажирский самолет");
_passengerAirplane.ShowInfo();
Console.WriteLine("\nГрузовой самолет");
_cargoAirplane.ShowInfo();
Console.WriteLine("\nЛегковой автомобиль");
_passengerCar.ShowInfo();
Console.WriteLine("\nГрузовой автомобиль");
_truck.ShowInfo();
Console.WriteLine("\nПоезд");
_train.ShowInfo();