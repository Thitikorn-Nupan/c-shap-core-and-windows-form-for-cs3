namespace UnderstandWindownsForms.entities {

    internal class Mobile {
        private string mbid;
        private string model;
        private string brand;
        private double price;
        private int amount;

        public Mobile(string mbid, string model, string brand, double price, int amount) {
            this.mbid = mbid;
            this.model = model;
            this.brand = brand;
            this.price = price;
            this.amount = amount;
        }

        public string Mbid => mbid;

        public string Model => model;

        public string Brand => brand;

        public double Price => price;

        public int Amount => amount;
    }
}