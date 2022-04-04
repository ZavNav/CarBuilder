namespace CarBuilder;

public class CarsReportBuilder : ICarsReportBuilder
{
    private CarsReport _report;
    private readonly List<Car> _cars;

    public CarsReportBuilder(List<Car> cars)
    {
        _cars = cars;
        _report = new();
    }
    
    public ICarsReportBuilder BuildNumberOfCars()
    {
        _report.NumberOfCars = _cars.Count;
        return this;
    }

    public ICarsReportBuilder BuildReportBody()
    {
        _report.ReportBody = string.Join(Environment.NewLine,
            _cars.Select(x => $"Car model: {x.Model}\t\tCar Price: {x.Price}"));
        return this;
    }

    public ICarsReportBuilder BuildConclusion()
    {
        _report.Conclusion = $"CONCLUSION:\nTotal cars price: {_cars.Sum(x => x.Price)}" +
                             $"\nNumber of 'BEYOND 3K'-cars: {_cars.Count(x => x.Price > 3000)}";
        return this;
    }

    public CarsReport GetReport()
    {
        var carsReport = _report;
        _report = new();
        return carsReport;
    }
}