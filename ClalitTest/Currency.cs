namespace ClalitTest
{
    public class Currency
    {
        public string Name { get; set; } = null!;
        public int Unit { get; set; }
        public string Country { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public double Rate { get; set; }
        public double Change { get; set; }
    }
}