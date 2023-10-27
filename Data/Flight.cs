namespace BlazorHybridApp2.Data
{
    public class Flight
    {
        public string Code { get; set; }
        public string AirlineCode { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string WeekDay { get; set; }
        public string Time { get; set; }
        public int TotalSeats { get; set; }
        public decimal CostPerSeat { get; set; }
        public Flight()
        {

        }

        public Flight(string code, string airline, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
        {
            Code = code;
            AirlineCode = airline;
            From = from;
            To = to;
            WeekDay = weekday;
            Time = time;
            TotalSeats = seats;
            CostPerSeat = costPerSeat;
        }
        public bool Equals(Flight other)
        {
            // Equality logic
            return other != null &&
                   Code == other.Code &&
                   AirlineCode == other.AirlineCode &&
                   From == other.From &&
                   To == other.To &&
                   WeekDay == other.WeekDay &&
                   Time == other.Time &&
                   TotalSeats == other.TotalSeats &&
                   CostPerSeat == other.CostPerSeat;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Flight);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code, AirlineCode, From, To, WeekDay, Time, TotalSeats, CostPerSeat);
        }

        public override string ToString()
        {
            return $"{Code}, Airline: {AirlineCode}, From: {From}, To: {To}, " +
                   $"Day: {WeekDay}, Time: {Time}, Seats: {TotalSeats}, Cost: {CostPerSeat}";
        }
    }
}