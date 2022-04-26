namespace FactoryDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }


        //public static CreditCard GetCreditCard(string cardType)
        //{
        //    CreditCard cardDetails = null;

        //    if (cardType == "MoneyBack")
        //    {
        //        cardDetails = new MoneyBack();
        //    }
        //    else if (cardType == "Titanium")
        //    {
        //        cardDetails = new Titanium();
        //    }
        //    else if (cardType == "Platinum")
        //    {
        //        cardDetails = new Platinum();
        //    }

        //    return cardDetails;
        //}
    }
}
