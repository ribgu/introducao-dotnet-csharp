namespace WebAPI.API.Entities
{
    public class Game
    {
        public Game()
        {
            Speakers = new List<GameSpeaker>();
            IsDeleted = false;
        }
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public List<GameSpeaker> Speakers { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string nome, string descricao, string tipo)
        {
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
