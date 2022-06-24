using BelkiOptimizer.Models;

namespace BelkiOptimaze.Request;

public class RequestModel
{
    public List<BarModel> Bars { get; set; }
    public List<BarRequest> RequestedBars { get; set; }
}