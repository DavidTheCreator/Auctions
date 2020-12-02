namespace Auctions.Models.View {
    public class FilterModel {
        public string auction_name { get; set; }
        public int from_price { get; set; }
        public int to_price { get; set; }
        public int page { get; set; } = 1;
        public Auctions.Models.Database.state state { get; set; }
    }
}