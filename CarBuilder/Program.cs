using CarBuilder;

List<Car> cars = new()
{
    new Car(){Model = "Tesla", Price = 5000},
    new Car(){Model = "Ford", Price = 2000},
    new Car(){Model = "Lada", Price = 500},
    new Car(){Model = "Pontiac", Price = 4000},
    new Car(){Model = "Honda", Price = 3500},
    new Car(){Model = "Toyota", Price = 2500},
    new Car(){Model = "Cadillac", Price = 4500}
};

var builder = new CarsReportBuilder(cars);
var director = new CarsReportDirector(builder);

director.Build();

var report = builder.GetReport();
Console.WriteLine(report);