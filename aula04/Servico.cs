namespace visual
{
    public class Servico
    {
        class usuario
        {
            int id;
            string username;
            string hash;

            public Usuario(string u, string p)
            {
                SetUsername(u);
                ApplyHash(p);
            }

            void ApplyHash(string password)
            {
                //TO DO aplicar hash
                hash = password;
            }

            public string GetUsername()
            {
                return username;
            }

            public string GetHash()
            {
                return hash;
            }

            public void SetUsername


        }
    }
}