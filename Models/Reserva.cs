namespace HotelPlaza.Models
{
    public class Reserva : Usuario
    {
        public Reserva(string nome, string email) : base (nome,email)
        {

        }

        public override void Logar()
        {
            base.Logar();
        }

        public int HoraReserva {  get; set; }
    }
}
