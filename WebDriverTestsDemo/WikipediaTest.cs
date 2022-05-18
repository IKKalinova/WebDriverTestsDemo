using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

// create new Chrom instans
var driver = new ChromeDriver();


//Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE: " +  driver.Title);


var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("TITLE after search: " + driver.Title);

//Close browser
driver.Quit();

