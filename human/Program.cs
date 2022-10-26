using human;
CollectionPeople collection = new CollectionPeople();
Student student = new Student();
collection.CreateHuman();
void Menu()
{
    Console.WriteLine("1. Уволить человека");
    Console.WriteLine("2. Отчислить студента");
    Console.WriteLine("3. Поменять работу");
    Console.WriteLine("4. Повысить степендию");
    Console.WriteLine("5. Получить информацию о каждом человеке");
}
void GetMenu()
{
    string menu1 = Console.ReadLine();
    bool menu2 = int.TryParse(menu1, out var menu);
    if (menu == 1)
    {
        collection.Dismiss();
    }
    else if (menu == 2)
    {
        collection.AxpelAStudent();
    }
    else if (menu == 3)
    {
        collection.ChangeWork();
    }
    else if (menu == 4)
    {
        collection.Grant(student);
    }
    else if (menu == 5)
    {
        collection.GetInfo();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Введите пункт из меню");
        Console.WriteLine();
    }
}
while (true)
{
    Menu();
    GetMenu();
}

