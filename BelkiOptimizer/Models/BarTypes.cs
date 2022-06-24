namespace BelkiOptimizer.Models;

public static class BarTypes
{
    public static Dictionary<string, List<Restrinction>> Restrictions = new()
    {
        {
            "PP18", new List<Restrinction>()
            {
                new(0, 6178),
                new(7427, 8427),
                new(10856, 11356)
            }
        },
        {
            "PP17", new List<Restrinction>()
            {
                new(0, 10342),
                new(10855, 11355)
            }
        },
        {
            "PP16", new List<Restrinction>()
            {
                new(0, 6029),
                new(7427, 8427),
                new(10557, 11057)
            }
        },
        {
            "PP15", new List<Restrinction>()
            {
                new(0, 5877),
                new(7427, 8427),
                new(10253, 10753)
            }
        },
        {
            "PP212", new List<Restrinction>()
            {
                new(0, 5683),
                new(9320, 9820)
            }
        },
        {
            "PP29", new List<Restrinction>()
            {
                new(0, 4516),
                new(7531, 8031)
            }
        },
        {
            "PP23", new List<Restrinction>()
            {
                new(0, 4509),
                new(7518, 8018) 
            }
        }
    };
}