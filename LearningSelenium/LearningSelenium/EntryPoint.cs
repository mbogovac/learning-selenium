using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement SpecialElements;
    static IWebElement TextBoxLink;
    static IWebElement TextBox;

    static void Main()
    {
        string url = "https://testing.todorvachev.com";
        string specialElements = "#menu-item-35 > a";

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(1000);
        driver.Manage().Window.Maximize();

        SpecialElements = driver.FindElement(By.CssSelector(specialElements));
        SpecialElements.Click();
        Thread.Sleep(2000);

        TextBoxLink = driver.FindElement(By.XPath("//*[@id=\"main-content\"]/article[2]/div/header/h3/a"));
        TextBoxLink.Click();
        Thread.Sleep(2000);

        TextBox = driver.FindElement(By.Name("username"));
        TextBox.SendKeys("Mila");
        Console.WriteLine(TextBox.GetAttribute("value"));
        Console.WriteLine(TextBox.GetAttribute("maxlength"));

        driver.Quit();
    }
}