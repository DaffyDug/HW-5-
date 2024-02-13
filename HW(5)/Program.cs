namespace HW_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passangers passenger1 = new Passangers(Place_Class.Economy, "John", 1);
            Passangers passenger2 = new Passangers(Place_Class.Business, "Sarah", 2);
            Passangers passenger3 = new Passangers(Place_Class.Economy, "Michael", 3);
            Passangers passenger4 = new Passangers(Place_Class.VIP, "Emily", 4);
            List<Passangers> passangers = new List<Passangers>() { passenger1, passenger2, passenger3, passenger4 };

            Airplane airplane = new Airplane(passangers);
            
        }
    }    
    public class Passangers
    {
        //Для ВСЕХ полей в классе пассажира реализовать публичный метод ИЛИ свойство GET (На ваш выбор).
        //Метод или свойство SET должны остаться закрытыми.
        public Place_Class _place_class { get; private set; }//1 – Класс места
        public string _Name { get; private set; }//2 – Имя
        public int _place_number { get; private set; }//3 – Номер места
        public Passangers(Place_Class place_class, string name, int place_number)
        {
            _place_class = place_class;
            _Name = name;
            _place_number = place_number;
        }

    }
    public class Airplane//Создать класс самолёта и добавить в него поле с коллекцией пассажиров.
    {
        private List<Passangers> _passangers;
        public Airplane(List<Passangers> passangers)
        {
            _passangers = passangers;
        }
        public List<Passangers> GetBoocks_Place_Class(Place_Class placeClass)//1 – Получение ВСЕХ пассажиров по Классу места.
        {
            List<Passangers> result = new List<Passangers>();
            foreach (var item in _passangers)
            {
                if (item._place_class == placeClass)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public void RemovePassangers(Passangers PASSANGERS)//3 – Удаление пассажира.
        {
            _passangers.Remove(PASSANGERS);
        }
        public void AddPassangers(Passangers PASSANGERS)//2 – Добавление пассажира.
        {
            _passangers.Add(PASSANGERS);
        }
    }
}

public enum Place_Class//Поле «Класс места» должно быть enum в котором будут следующие значения (Бюджет, бизнес, вип)
{
    Economy,
    Business,
    VIP
}




