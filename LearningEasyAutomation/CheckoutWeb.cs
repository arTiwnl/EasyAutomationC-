using EasyAutomationFramework;

namespace LearningEasyAutomation;


public class CheckoutWeb : Web
{

        public CheckoutWeb()
        {
                StartBrowser(TypeDriver.GoogleChorme);
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
           
           

        }
    
}