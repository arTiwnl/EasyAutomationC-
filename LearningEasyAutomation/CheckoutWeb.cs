using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomationFramework;
using OpenQA.Selenium;
using static com.sun.jndi.cosnaming.IiopUrl;



namespace LearningEasyAutomation;


public class CheckoutWeb : Web, IDisposable
{

        public CheckoutWeb()
        {
                StartBrowser(TypeDriver.GoogleChorme);
        }

        public void Dispose()
        {
              CloseBrowser();  
        }

        public void SendForm(Checkout checkout)
        {
                Navigate("https://getbootstrap.com/docs/4.3/examples/checkout/");

                AssignValue(TypeElement.Id,"fistName", checkout.Firstname);
                AssignValue(TypeElement.Id,"lastName", checkout.Lastname);
                AssignValue(TypeElement.Id,"username", checkout.Username);
                AssignValue(TypeElement.Id,"email", checkout.Email);
                AssignValue(TypeElement.Id,"address", checkout.Address);
                
                SelectValue(TypeElement.Id, TypeSelect.Text ,"country", checkout.Country);
                SelectValue(TypeElement.Id, TypeSelect.Text ,"state", checkout.State);
                
                AssignValue(TypeElement.Id,"Zip", checkout.Zip);

                
                driver.FindElements(By.ClassName("custom-control-label")).SingleOrDefault(x => x.GetAttribute("for").Contains(checkout.Payment))?.Click();
             
                
                AssignValue(TypeElement.Id,"cc-name", checkout.Namecard);
                AssignValue(TypeElement.Id,"cc-number", checkout.Creditcard);
                AssignValue(TypeElement.Id,"cc-expiration", checkout.Expiration);
                AssignValue(TypeElement.Id,"cc-cvv", checkout.Cvv);

                Click(TypeElement.Xpath, "/html/body/div/div[2]/div[2]/form/button");

        }
    
}