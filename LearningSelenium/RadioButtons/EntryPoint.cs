using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement SpecialElements;
    static IWebElement RadioButtonLink;
    static IWebElement firstRadioBtn;

    static void Main()
    {
        string url = "https://testing.todorvachev.com";
        string specialElements = "#menu-item-35 > a";
        string radioButtonLink = "//*[@id=\"main-content\"]/article[4]/div/header/h3/a";
        string[] option = { "1", "3", "5" };

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(1000);
        driver.Manage().Window.Maximize();

        SpecialElements = driver.FindElement(By.CssSelector(specialElements));
        SpecialElements.Click();
        Thread.Sleep(2000);

        RadioButtonLink = driver.FindElement(By.XPath(radioButtonLink));
        RadioButtonLink.Click();

        for(int i = 0; i < option.Length; i++)
        {
            firstRadioBtn = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option[i] + ")"));

            if (firstRadioBtn.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + (i+1) + " radio button is checked!");
            }
            else
            {
                Console.WriteLine("The " + (i+1) + ". radio button is NOT checked!");
            }
        }


        driver.Quit();
    }
}