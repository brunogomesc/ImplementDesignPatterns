using FactoryMethod.Creator;
using FactoryMethod.Product;

Screen webScreen = new ConcreteWebScreenCreator().CreateScreen();
Screen smartphoneScreen = new ConcreteSmartphoneScreenCreator().CreateScreen();
Screen smartwatchScreen = new ConcreteSmartwatchScreenCreator().CreateScreen();
Screen smartTvScreen = new ConcreteSmartTvScreenCreator().CreateScreen();

Console.WriteLine("WEB SCREEN => " + webScreen.GetMessageText()); 
Console.WriteLine("SMARTPHONE SCREEN => " + smartphoneScreen.GetMessageText()); 
Console.WriteLine("SMARTWATCH SCREEN => " + smartwatchScreen.GetMessageText()); 
Console.WriteLine("SMART TV SCREEN => " + smartTvScreen.GetMessageText()); 