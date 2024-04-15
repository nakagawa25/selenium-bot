using RPADomain.MercadoLivre;
using System.ComponentModel.DataAnnotations;

namespace RPAService.MercadoLivre
{
    public class MercadoLivreService
    {
        private readonly MercadoLivreBot bot;

        public MercadoLivreService()
        {
            bot = new MercadoLivreBot();
        }

        public IEnumerable<Product> GetCompetitorProducts(string productDesription)
        {
            if (string.IsNullOrWhiteSpace(productDesription))
            {
                throw new ValidationException("A Descrição do produto não pode ser nula. ");
            }
            var products = bot.GetCompetitorProducts(productDesription);

            return products;
        }

        public decimal GetProductsAverage(IEnumerable<Product> products)
        {
            if (products != null && products!.Count() > 0)
            {
                var average = products!.Select(p => p.Price).Average();
                return average;
            }

            return 0;
        }
    }
}