using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Tests
{
	public class Tests
	{
		private IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Url = "https://localhost:7220/Portfolios/Software_Development/Index";
		}

		[Test]
		public void Test1()
		{
			IWebElement home = driver.FindElement(By.Id("Home"));
			home.Click();

			IWebElement about = driver.FindElement(By.Id("About"));
			about.Click();

			IWebElement portfolio = driver.FindElement(By.Id("Portfolio"));
			portfolio.Click();

			IWebElement contact = driver.FindElement(By.Id("Contact"));
			contact.Click();
		}

		[TearDown]
		public void close_browser()
		{
			driver.Close();
		}
	}
}