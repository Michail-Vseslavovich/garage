

namespace garage
{
    class Menu
    {

        Car YourCar = new Car();
        SportCar YourSportCar = new SportCar();
        public void Start()
        {
            Console.WriteLine("Добро пожаловать в ваш гараж! Тут пока нету машин. Давайте это исправим!\n Напишите 1, если хотите добавить обычную машину и 2, если хотите спортивную.");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    AddCar();
                    break;

                case 2:
                    AddSportCar();
                    break;

                default:
                    Console.WriteLine("Не совсем вас понял... \n Давайте попробуем снова!");
                    goto Back;
                    
            }
        Choice:
            Console.WriteLine("Теперь вы можете выбрать, что делать с вашей машиной : \n 1) изменить скорость \n 2)дрифт \n 3) выйти в меню создания машины \n 4)Использовать нитро на спорткаре");
            int UserAnswer = int.Parse(Console.ReadLine());
            
            
                switch (UserAnswer)
                {
                    case (1):

                        Console.WriteLine("Скорость обычной машины : {0}\n Скорость спорткара : {1}", YourCar.Speed, YourSportCar.Speed);
                        Console.WriteLine("Введите новую скорость для вашей обычной машины");
                        int speed = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите скорость для вашего спорткара");
                        int SportSpeed = int.Parse(Console.ReadLine());
                        YourCar.Speed = speed;
                        YourSportCar.Speed = SportSpeed;
                        goto Choice;
                    case (2):
                        Console.WriteLine("Введите, на какой машине вы хотите устроить дрифт : 1) обычная машина 2) спорткар");
                        int UserChoice = int.Parse(Console.ReadLine());
                        switch(UserChoice)
                        {
                            case (1):
                                YourCar.Drift();
                            goto Choice;
                                
                            case (2):
                                YourSportCar.Drift();
                            goto Choice;

                            default:
                               Console.WriteLine("Я не совсем вас понял.... Давайте повторю опции...");
                                goto Choice;

                        }
                    case (3):
                        goto Back;
                    case (4):
                        YourSportCar.SuperCharge();
                        goto Choice;
            }
        Back: Start();

        }
        public void AddSportCar()
        {
            Console.WriteLine("Отличный выбор! Теперь введите скорость машины");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Хорошо. Теперь введите максимальную скорость своей машины");
            int MaxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь последний шаг : введите количество нитро-ускорителей!");
            int nitro = int.Parse(Console.ReadLine());

            YourSportCar = new SportCar(speed, MaxSpeed, nitro);
            
        }
        public void AddCar() 
        {
            Console.WriteLine("Отличный выбор! Теперь введите скорость машины");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Хорошо. Теперь введите максимальную скорость своей машины");
            int MaxSpeed = int.Parse(Console.ReadLine());


            YourCar = new Car(speed, MaxSpeed);
            
        }

    }
}
