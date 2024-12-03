using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Dtos.OfferDiscountDtos
{
    public class CreateOfferDiscountDto
    {        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ButtonTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
