namespace RPAService.MercadoLivre
{
    public static class MercadoLivreTools
    {
        public static decimal ConvertTextToDecimalPrice(string fractionText, string centsText)
        {
            decimal fractionPrice = Convert.ToDecimal(fractionText);
            decimal centsPrice = !string.IsNullOrWhiteSpace(centsText) ? Convert.ToDecimal(centsText) : 0;
            centsPrice /= 100;

            decimal totalPrice = fractionPrice + centsPrice;

            return totalPrice;
        }
    }
}
