using RPAService.MercadoLivre;
using System.ComponentModel.DataAnnotations;

try
{
    var mlService = new MercadoLivreService();
    bool exit = false;
    do
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=================================================================");
        Console.WriteLine("=====         Consulta de Produtos do Mercado Livre         =====");
        Console.WriteLine("=================================================================");
        Console.ResetColor();

        Console.WriteLine("Insira a descrição do produto: ");
        var description = Console.ReadLine();

        var products = mlService.GetCompetitorProducts(description!);
        var productsAverage = mlService.GetProductsAverage(products);

        if (products.Any())
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Produto: {product.Description}{Environment.NewLine}Preço: R$ {product.Price:0.00}{Environment.NewLine}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A média de preço desses produtos é de R$ {productsAverage:0.00}.");
        }
        else
        {
            Console.WriteLine("Nenhum produto foi encontrado. ");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite (S) para sair ou qualquer tecla para uma nova consulta...");

        exit = Console.ReadLine() == "S";
    } while (!exit);
}
catch (ValidationException error)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Erro de validação. Descrição do erro: " + error.Message);
}
catch (Exception error)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Erro de Sistema. Descrição do erro: " + error.Message);
}

