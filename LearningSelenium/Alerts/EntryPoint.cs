using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/alert-box/";
        

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(1000);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        Thread.Sleep(2000);
        driver.Quit();
    }
}