class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("====== Selamat Datang di Rajawali Cinema App  ======"); 
            Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
            Console.Write("Pilih opsi: ");
            var opsi = Console.ReadLine();

            if (opsi == "1")
            {
                 
                Console.Write("Username: ");
                var user = Console.ReadLine();
                Console.Write("Password: ");
                var pass = Console.ReadLine();
                if (User.Register(user, pass, out string error))
                    Console.WriteLine("Registrasi berhasil!!.");
                else
                    Console.WriteLine($"Gagal: {error}");
            }
            else if (opsi == "2")
            {
                Console.Write("Username: ");
                var user = Console.ReadLine();
                Console.Write("Password: ");
                var pass = Console.ReadLine();
                if (User.Login(user, pass))
                {
                    Console.WriteLine("Login sukses.");
                    Film.PilihFilm();
                }
                else
                {
                    Console.WriteLine("Login gagal.");
                }
            }
            else if (opsi == "3")
                break;
        }
    }
}
