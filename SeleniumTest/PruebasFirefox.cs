
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    internal class PruebasFirefox
    {
        string geckoDriverPath = "ruta/al/geckodriver.exe";
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverPath);

            // Configuración adicional del controlador
            // service.AddArgument("--headless");  // Opcional: para ejecución sin ventana
            // service.AddArgument("--disable-gpu");  // Opcional: si hay problemas con la GPU

            // Inicializar el controlador de Firefox
            driver = new FirefoxDriver(service);
        }

        [Test]
        public void Test()
        {

            // Abrir la URL de inicio de sesión de YouTube
            driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?dsh=S1543894493%3A1687470217722816&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26hl%3Des-419%26next%3Dhttps%253A%252F%252Fwww.youtube.com%252F%253Fhl%253Des-419&ec=65620&hl=es-419&ifkv=Af_xneE54SfHusaz_rDllq8wp5_HOhPFyxzT2_sR77y0WmUTn-qYSJmlO1T8xocZ--VvHm8CalFFvQ&passive=true&service=youtube&uilel=3&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

            // Encontrar el campo de correo electrónico y completarlo
            IWebElement emailInput = driver.FindElement(By.Id("identifierId"));
            emailInput.SendKeys("Lecheconchocolate800@gmail.com");

            // Hacer clic en el botón "Siguiente"
            IWebElement nextButton = driver.FindElement(By.Id("identifierNext"));
            nextButton.Click();

            // Esperar un momento para que se cargue la página de contraseña
            System.Threading.Thread.Sleep(2000);

            // Encontrar el campo de contraseña y completarlo
            IWebElement passwordInput = driver.FindElement(By.Name("Passwd"));
            passwordInput.SendKeys("LecheConChocolate800");

            // Hacer clic en el botón "Siguiente" de contraseña
            IWebElement signInButton = driver.FindElement(By.Id("passwordNext"));
            signInButton.Click();

            // Esperar un momento para que se cargue la página de verificación de contraseña
            System.Threading.Thread.Sleep(2000);

            // Esperar un momento para que se inicie sesión
            System.Threading.Thread.Sleep(5000);


            // Abrir la URL de YouTube directamente después de iniciar sesión
            driver.Navigate().GoToUrl("https://www.youtube.com/");

            // Esperar un momento para que se cargue la página de YouTube
            System.Threading.Thread.Sleep(2000);

            // Abrir un video específico
            driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=KHlZ2Hq5N7g");

            // Esperar un momento para que se cargue el anuncio de youtube de YouTube
            System.Threading.Thread.Sleep(6000);

            // Hacer clic en el botón "Me gusta" del video
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("document.querySelector('.yt-spec-touch-feedback-shape__fill').click();");

            Console.WriteLine("Video liked!");

            // Esperar un momento para que se aplique el "Me gusta" en el video
            System.Threading.Thread.Sleep(2000);

            // Continuar realizando más acciones según sea necesario
        }

        [TearDown]
        public void close_Browser()
        {
            // Cierra el navegador y libera recursos
            driver.Quit();
        }
    }
}



