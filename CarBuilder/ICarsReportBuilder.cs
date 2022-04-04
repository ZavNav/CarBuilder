namespace CarBuilder;

public interface ICarsReportBuilder
{
    ICarsReportBuilder BuildNumberOfCars();
    ICarsReportBuilder BuildReportBody();
    ICarsReportBuilder BuildConclusion();

    CarsReport GetReport();
}