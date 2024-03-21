using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

Console.WriteLine(" User logged in sucessfully");
driver.Quit();