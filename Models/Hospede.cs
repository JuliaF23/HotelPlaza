namespace HotelPlaza.Models
{
    public class Hospede :  Usuario
    {
        public Hospede(string nome, string email, int NumeroReserva = 0) : base(nome, email)
        {
            if (NumeroReserva == 0)
            {
                Random random = new Random();

                NumeroReserva = random.Next(0, 100);
            }
        }

        public int Id {get; set;}

        public int NumeroReserva { get; set;}
    }
}
