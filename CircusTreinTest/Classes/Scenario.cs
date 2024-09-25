namespace UnitTest.Classes;

public class Scenario
{
    public int SmallCarnivoreCount { get; set; }
    public int MediumCarnivoreCount { get; set; }
    public int LargeCarnivoreCount { get; set; }
    public int SmallHerbivoreCount { get; set; }
    public int MediumHerbivoreCount { get; set; }
    public int LargeHerbivoreCount { get; set; }
    public int ExpectedWagonCount { get; set; }
    
    public Scenario(int smallCarnivoreCount, int mediumCarnivoreCount, int largeCarnivoreCount, int smallHerbivoreCount, int mediumHerbivoreCount, int largeHerbivoreCount, int expectedWagonCount)
    {
        SmallCarnivoreCount = smallCarnivoreCount;
        MediumCarnivoreCount = mediumCarnivoreCount;
        LargeCarnivoreCount = largeCarnivoreCount;
        SmallHerbivoreCount = smallHerbivoreCount;
        MediumHerbivoreCount = mediumHerbivoreCount;
        LargeHerbivoreCount = largeHerbivoreCount;
        ExpectedWagonCount = expectedWagonCount;
    }
}