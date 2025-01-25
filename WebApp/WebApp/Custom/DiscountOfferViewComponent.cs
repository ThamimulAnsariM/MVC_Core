using Microsoft.AspNetCore.Mvc;

namespace WebApp.Custom
{
    public class DiscountOfferViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(decimal productprice)
        {
            if (productprice > 6000)
            {
                decimal discount = productprice * 15 / 100;
                decimal finalPrice=productprice-discount;
                return View("_DiscountOffer",finalPrice);
            }
            return View("_NoOffer");
        }
    }
}
