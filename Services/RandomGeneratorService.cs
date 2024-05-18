namespace WebApplication1.Services
{
    public class RandomGeneratorService
    {
        public string RandomString { get; set; }
        public RandomGeneratorService()
        {
            var random = new Random();
            RandomString = random.Next(1, 1000).ToString();
        }
    }
}
