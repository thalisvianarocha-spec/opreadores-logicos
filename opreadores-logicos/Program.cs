namespace opreadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Operadores logicos======");

            /* bool islogin = true;
             bool hasadminaccess = false;

             Console.WriteLine("\nInformações do usuario");
             Console.WriteLine("Está logado: " + islogin);
             Console.WriteLine("Tem acesso de administrador: " + hasadminaccess);

             // operador(&&) E
             if (islogin && hasadminaccess)
             {
                 Console.WriteLine("Usuario logado e com acesso de administrador");
             }
             else
             {
                 Console.WriteLine("Usuario não logado ou sem acesso de administrador");
             } */

            string usuario;
            int senha;

            Console.WriteLine("informe o usuario: ");
            usuario = Console.ReadLine();

            Console.WriteLine("informe a senha: ");
            senha = Convert.ToInt32(Console.ReadLine());

            if (usuario == "admin" && senha == 1234)
            {
                Console.WriteLine("Usuario logado com sucesso");
            }
            else
            {
                Console.WriteLine("Usuario ou senha incorretos");
            }

            // operador(||) OU
            if (usuario == "admin" || senha == 1234)
            {
                Console.WriteLine("Usuario logado com sucesso");
            }
            else
            {
                Console.WriteLine("Usuario ou senha incorretos");
            }

            // operador(!) NÃO
            if (!(usuario == "admin" && senha == 1234))
            {
                Console.WriteLine("Usuario ou senha incorretos");
            }
            else
            {
                Console.WriteLine("Usuario logado com sucesso");
            }

        }
    }
}
