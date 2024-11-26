using LearningEasyAutomation;

var filePath = @"..\..\..\..\fake_user_data.csv";


var lines = File.ReadAllLines(filePath);
var checkouts = lines.Skip(1).Select(Checkout.Map).ToList(); 

using var checkoutDriver = new CheckoutWeb();

foreach (var checkout in checkouts)
{
    checkoutDriver.SendForm(checkout);
   
}
