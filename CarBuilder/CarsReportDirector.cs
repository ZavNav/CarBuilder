namespace CarBuilder;

public class CarsReportDirector
{
    private readonly ICarsReportBuilder _builder;

    public CarsReportDirector(ICarsReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder
            .BuildNumberOfCars()
            .BuildReportBody()
            .BuildConclusion();
    }
}