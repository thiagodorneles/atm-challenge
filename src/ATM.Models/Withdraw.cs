namespace ATM.Models
{
    public class Withdraw
    {
        public short TenNotes { get; set; }
        public short TwentyNotes { get; set; }
        public short FiftyNotes { get; set; }
        public short HundredNotes { get; set; }

        public Withdraw()
        {
        }

        public Withdraw(short tenNotes, short twentyNotes, short fiftyNotes, short hundredNotes)
        {
            this.TenNotes = tenNotes;
            this.TwentyNotes = twentyNotes;
            this.FiftyNotes = fiftyNotes;
            this.HundredNotes = hundredNotes;
        }
    }
}