using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Pet : IBirthdable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get => name; private set => name = value; }
        public string Birthdate { get => birthdate; private set => birthdate = value; }
        
    }
}
