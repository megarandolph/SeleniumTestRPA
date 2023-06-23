using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Edge;

namespace SeleniumTest
{
    public class MicrosoftEdgeTest
    {
        String test_url = "https://accounts.google.com/o/oauth2/v2/auth/oauthchooseaccount?redirect_uri=https%3A%2F%2Fdevelopers.google.com%2Foauthplayground&prompt=consent&response_type=code&client_id=407408718192.apps.googleusercontent.com&scope=email&access_type=offline&flowName=GeneralOAuthFlow";

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Local Selenium WebDriver
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-notifications");
            driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {

            driver.Url = test_url;
            System.Threading.Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement Correo = driver.FindElement(By.CssSelector("#identifierId"));
            Correo.SendKeys("Lecheconchocolate800@gmail.com");


            IWebElement Next = driver.FindElement(By.CssSelector("#identifierNext > div > button"));
            Next.Click();
            System.Threading.Thread.Sleep(5000);


            IWebElement Pass = driver.FindElement(By.CssSelector("#password > div.aCsJod.oJeWuf > div > div.Xb9hP > input"));
            Pass.SendKeys("LecheConChocolate800");


            Next = driver.FindElement(By.CssSelector("#passwordNext > div > button"));
            Next.Click();
            System.Threading.Thread.Sleep(1000);


            driver.Url = "https://www.youtube.com/";
            System.Threading.Thread.Sleep(2000);


            IWebElement campoBusqueda = driver.FindElement(By.CssSelector("input#search"));
            campoBusqueda.Clear();
            campoBusqueda.SendKeys("TALLER SOBRE LA ANALÍTICA DE LOS DATOS (1/2)");
            System.Threading.Thread.Sleep(1000);


            IWebElement Buscar = driver.FindElement(By.CssSelector("#search-icon-legacy"));
            Buscar.Click();
            System.Threading.Thread.Sleep(1000);


            IWebElement Video = driver.FindElement(By.CssSelector("a#video-title"));
            Video.Click();
            System.Threading.Thread.Sleep(4000);


            IWebElement Like = driver.FindElement(By.CssSelector("#segmented-like-button > ytd-toggle-button-renderer > yt-button-shape > button"));
            Like.Click();
            System.Threading.Thread.Sleep(1000);


            IWebElement Suscribirse = driver.FindElement(By.CssSelector("#subscribe-button > ytd-subscribe-button-renderer > yt-smartimation > yt-button-shape > button"));
            Suscribirse.Click();
            System.Threading.Thread.Sleep(3000);


            IWebElement Comentar = driver.FindElement(By.CssSelector("div#placeholder-area"));
            Comentar.Click();
            System.Threading.Thread.Sleep(3000);


            IWebElement escribir = driver.FindElement(By.Id("contenteditable-root"));
            escribir.SendKeys("¡Me gustaría expresar mi más profundo agradecimiento por su increíble explicación sobre la analítica de datos! quedé impresionado por su habilidad para desglosar conceptos complejos en una forma clara y comprensible. Su pasión por el tema y su dedicación para asegurarnos que comprendamos cada aspecto de la analítica de datos es realmente admirable.");
            System.Threading.Thread.Sleep(1000);


            IWebElement EnviarComentario = driver.FindElement(By.CssSelector("#submit-button > yt-button-shape > button"));
            EnviarComentario.Click();
            System.Threading.Thread.Sleep(5000);


            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}