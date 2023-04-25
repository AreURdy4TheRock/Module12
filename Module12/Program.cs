using Module12.Services;

namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> people = new List<User>(); // Создаём и заполняем список пользователей
            people.Add(new User("login", "Артём", true ));
            people.Add(new User("login1", "Максим", false));
            people.Add(new User("login", "Михаил", true));
            people.Add(new User("login", "Светлана", false));

            foreach (User user in people) // Для каждого пользователя из списка
            {
                Show.Greetengs(user.Name); // Выводим приветствие
                if (!user.IsPremium) // Если нет премиум аккаунта
                {
                    Show.ShowAds(); // Показываем рекламу
                }
            }
            Console.ReadKey();
        }
    }
}