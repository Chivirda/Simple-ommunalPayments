using System;

namespace CPLogic.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Area { get; set; }
        public DateTime DateOfChanging { get; set; }
        public int HouseId { get; set; }
        public virtual House House { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
