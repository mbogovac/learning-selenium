using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement SpecialElements;
    static IWebElement CheckBoxesLink;
    static IWebElement FirstOption;
    static IWebElement SecondOption;

    static void Main()
    {
        string url = "https://testing.todorvachev.com";
        string specialElements = "#menu-item-35 > a";
        string checkboxesLink = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a";

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(1000);
        driver.Manage().Window.Maximize();

        SpecialElements = driver.FindElement(By.CssSelector(specialElements));
        SpecialElements.Click();
        Thread.Sleep(2000);

        CheckBoxesLink = driver.FindElement(By.XPath(checkboxesLink));
        CheckBoxesLink.Click();

        FirstOption = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
        SecondOption = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));

        FirstOption.Click();
        SecondOption.Click();

        Thread.Sleep(2000);
        driver.Quit();
    }
}