namespace CPLogic.Model
{
    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return Name; 
        }
    }
}
