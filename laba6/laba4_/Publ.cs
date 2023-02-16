using System;
   public class Publ
    {
    public enum Genre
    {

        Fantasy,
        Drama,
        Romance,
        Thriller,
        Action,
        Detectives,
        Science,
        History,
        Medicine,
        Crime
    }
    public struct Date
    {
        public int Day;
        public int Month;
        public int Year;
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
            if (this.Day > 31 || this.Day < 0 || this.Month > 12 || this.Month < 0 || this.Year < 0)
            {
                throw new DateException("Ошибка! Некорректо введена дата:", this.Day, this.Month, this.Year);
            }
        }
    }
}

