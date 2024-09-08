namespace FacadeDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShopingFacade shopingFacade = new OnlineShopingFacade();
            shopingFacade.PurchaseProduct();
        }
    }
}
