namespace LAB6
{
    class Item
    {
        public int Time { get; set; }
        public int NumberC { get; set; }
        public int NumberA { get; set; }
        public string CityName { get; set; }
        public string Data { get; set; }
        public int CityCode { get; set; }
        public int Tax { get; set; }

        public string GetInfo()
        {
            string info = "Время: " + this.Time + "\r\n" +
                          "Номер (гор.): " + this.NumberC + "\r\n" +
                          "Номер (аб.): " + this.NumberA + "\r\n" +
                          "Город: " + this.CityName + "\r\n" +
                          "Дата: " + this.Data + "\r\n" +
                          "Код города: " + this.CityCode + "\r\n" +
                          "Тариф: " + this.Tax + "\r\n";

            return info;
        }
    }
}
