namespace PA6 {
    public class Book {
        public string _id { get; set; }
        public string CWID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }

        public override string ToString() {
            return Title;
        }

        private bool isRented;

        public bool Rent() {
            if(isRented) return false;
            isRented = true;
            Copies--;

            return true;
        }

        public bool Return() {
            if(!isRented) return false;
            isRented = false;
            Copies++;

            return true;
        }

        public bool IsRented() {
            return isRented;
        }
    }
}
