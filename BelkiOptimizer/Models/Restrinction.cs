namespace BelkiOptimizer.Models;

public class Restrinction
{
    public Restrinction(int from, int to)
    {
        From = from;
        To = to;
    }

    public int From { get; set; }
    public int To { get; set; }
}