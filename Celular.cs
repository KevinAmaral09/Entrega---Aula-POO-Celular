namespace AulaPOOCelular
{
    public class Celular
    {
        public string modelo;

        public string cor;

        public int tamanho;

        public bool ligado;

        public bool ligar(){
            return ligado = true;
        }

        public bool desligar(){
            return ligado = false;
        }

        public string ligacao(){
            return "FAZER LIGAÇÃO";
        }

        public string mensagem(){
            return "MANDAR MENSAGEM";
        }
    }
}