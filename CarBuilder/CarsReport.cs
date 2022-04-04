namespace CarBuilder;

public class CarsReport
{
    public int NumberOfCars { get; set; }
    public string ReportBody { get; set; }
    public string Conclusion { get; set; }

    public override string ToString() =>
        $"We have {NumberOfCars} cars\n{ReportBody}\n{Conclusion}";
}