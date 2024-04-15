using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RPADomain.MercadoLivre;

namespace RPAService.MercadoLivre
{
    internal class MercadoLivreBot
    {
        private readonly IWebDriver _webDriver;

        internal MercadoLivreBot()
        {
            var options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Driver, LogLevel.Off);
            options.SetLoggingPreference(LogType.Browser, LogLevel.Off);
            options.SetLoggingPreference(LogType.Client, LogLevel.Off);
            options.AddArgument("--disable-extensions");
            // options.AddArgument("headless");

            _webDriver = new ChromeDriver(options);
        }

        private void GoToProductListPage(string productDescription)
        {
            _webDriver.Navigate().GoToUrl("https://www.mercadolivre.com.br/");

            var inputElement = _webDriver.FindElement(By.XPath("//*[@id=\"cb1-edit\"]"));
            inputElement.SendKeys(productDescription);

            var searchButton = _webDriver.FindElement(By.XPath("/html/body/header/div/div[2]/form/button"));
            searchButton.Click();
        }

        internal IEnumerable<Product> GetCompetitorProducts(string productDescription)
        {
            var products = new List<Product>();
            GoToProductListPage(productDescription);

            var productElements = _webDriver.FindElements(By.ClassName("ui-search-layout__item"));

            foreach (var productElement in productElements)
            {
                var priceSectionElement = productElement.FindElement(By.ClassName("ui-search-price__part--medium"));
                var priceFractionText = priceSectionElement.FindElement(By.ClassName("andes-money-amount__fraction")).Text;              
                var priceCentsElements = priceSectionElement.FindElements(By.ClassName("andes-money-amount__cents"));
                var priceCentsText = priceCentsElements.Count > 0 ? priceCentsElements[0].Text : string.Empty;

                var description = productElement.FindElement(By.ClassName("ui-search-item__title")).Text;
                var totalPrice = MercadoLivreTools.ConvertTextToDecimalPrice(priceFractionText, priceCentsText);

                products.Add(new Product() { Description = description, Price = totalPrice });
            }

            return products;
        }
    }
}
