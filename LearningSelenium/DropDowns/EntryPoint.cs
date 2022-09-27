using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement DropDownMenu;
    static IWebElement elementFromDropDown;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(1)";

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(1000);
        driver.Manage().Window.Maximize();

        DropDownMenu = driver.FindElement(By.Name("DropDownTest"));
        Console.WriteLine(DropDownMenu.GetAttribute("value"));

        for(int i = 1; i <= 4; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" +i+ ")";
            elementFromDropDown = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The " +i+ ". option is " +elementFromDropDown.GetAttribute("value"));
        }
        
        driver.Quit();
    }
}