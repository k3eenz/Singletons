using Singleton_Pattern;
// Lazy
//Servers instance = Servers.Instance;
// Eager
EagerServers instance = EagerServers.Instance;
while (true)
{
    Console.WriteLine("Выберите действие:\n" +
        "1 - Добавить сервер\n" +
        "2 - Показать сервера http\n" +
        "3 - Показать сервера https\n" +
        "4 - Выйти");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Write("Введите адрес сервера: ");
            string address = Console.ReadLine();
            Console.WriteLine(instance.AddServer(address));
            break;
        case "2":
            instance.ShowServers(false);
            break;
        case "3":
            instance.ShowServers(true);
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте еще раз.");
            break;
    }
}

