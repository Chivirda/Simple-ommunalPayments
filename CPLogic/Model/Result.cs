using System;

namespace CPLogic.Model
{
    public class Result
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RateId { get; set; }
        public virtual Rate Rate { get; set; }
        public int HouseId { get; set; }
        public virtual House House { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return $"Оплата за период с: {StartDate} по: {EndDate}. Для помещения по адресу: {House.Address}, {Room.Address}. Составляет: {Value} рублей.";
        }
    }
}
