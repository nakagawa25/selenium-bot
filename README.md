<h1 align="center">
  <span>Selenium</span> RPA
  <img src="assets/selenium-icon.png" width="32">
</h1>

<p align="center">Application to consult product information on Mercado Livre.</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/53760877/138791241-50a815be-dbd6-4a0e-b62c-68f3b28d155b.png" alt=".NET" />
  <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://camo.githubusercontent.com/f22051667b1f035a16e2c17c0ec3109f56a971a91d8acf84f61d5e163696b35e/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2d73656c656e69756d2d253433423032413f7374796c653d666f722d7468652d6261646765266c6f676f3d73656c656e69756d266c6f676f436f6c6f723d7768697465" alt="Selenium"/>
  <img src="https://camo.githubusercontent.com/22c9aa77ff4eda4401f010263321f196535dd1c8894f8ec57ddb2abbffbd90e4/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f476f6f676c652532304368726f6d652d3432383546343f7374796c653d666f722d7468652d6261646765266c6f676f3d476f6f676c654368726f6d65266c6f676f436f6c6f723d7768697465" alt="Chrome"/>
  <img src="https://camo.githubusercontent.com/c8af3418f8fe508aed1c66f474b50f9e9d8f64db648d1bd947527b35b6243a99/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f636861744750542d3734616139633f7374796c653d666f722d7468652d6261646765266c6f676f3d6f70656e6169266c6f676f436f6c6f723d7768697465" alt="ChatGPT"/>
</p>

## :book: About
This is a Robotic Process Automation (RPA) using .NET and C# to get the information about products on Mercado Livre based on the product description provided.

This application outputs the description and the price of all the products found in the first page, after that, show the average price.

<img src="assets/image-1.png" alt="Imagem do output">

> Doing a product check with the product description "celulares da samsung" that means Samsung Smartphones.

<img src="assets/image-2.png" alt="Imagem do output">

> Return from data extraction, displaying product description, price and average price of all listed products.

## ⚒️ Technologies
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET 8](https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-8/overview)
- [ChatGPT](https://chat.openai.com/)
- [Selenium](https://www.selenium.dev/)
- [Google Chrome](https://www.google.com/intl/pt-BR/chrome/)

## 🚀 Running the Application

- Clone this repository with `git clone https://github.com/nakagawa25/selenium-bot.git`
- Open Windows PowerShell in repository root directory
- Build the project with `dotnet build .\CLIApplication\`
- Start the application with `.\CLIApplication\bin\Debug\net8.0\CLIApplication.exe`

## 🥾 Next Steps

Project progress.

- [x] Get products from the Mercado Livre products list.
- [x] Get current prices for each product.
- [x] Calculate average price of products.
- [ ] Extract data from all product list pages.
- [ ] Identify kits and batch products for greater price accuracy.
