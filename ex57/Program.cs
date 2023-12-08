using System;
using System.Collections.Generic;
using System.Linq;

namespace ex57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandShowSoldiersInfo = "1";
            const string CommandShowShortSoldiersInfo = "2";
            const string CommandExit = "3";

            MilitaryBase militaryBase = new MilitaryBase();
            bool isOpen = true;

            while (isOpen)
            {
                Console.Write($"{CommandShowSoldiersInfo} - показать полную информацию о солдатах\n" +
                    $"{CommandShowShortSoldiersInfo} - показать сокращенную информацию о солдатах\n" +
                    $"{CommandExit} - выйти из программы\n" +
                    $"Ваш ввод: ");

                switch (Console.ReadLine())
                {
                    case CommandShowSoldiersInfo:
                        militaryBase.ShowAllSoldiersInfo();
                        break;

                    case CommandShowShortSoldiersInfo:
                        militaryBase.ShowShortSoldiersInfo();
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Неверный ввод...");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class MilitaryBase
    {
        private List<Soldier> _soldiers = new List<Soldier>();

        public MilitaryBase()
        {
            AddSoldiers();
        }

        public void ShowShortSoldiersInfo()
        {
            var shortSoldiersInfo = _soldiers.Select(soldiers => new { name = soldiers.Name, rank = soldiers.Rank });

            Console.Clear();

            foreach (var soldier in shortSoldiersInfo)
                Console.WriteLine($"{soldier.name}. Звание: {soldier.rank}");
        }

        public void ShowAllSoldiersInfo()
        {
            Console.Clear();

            foreach (Soldier soldier in _soldiers)
                soldier.ShowInfo();
        }

        private void AddSoldiers()
        {
            _soldiers.Add(new Soldier("Василий", "Ак-47", "Майор", 81));
            _soldiers.Add(new Soldier("Георгий", "Famas", "Полковник", 129));
            _soldiers.Add(new Soldier("Вечеслав", "Aug", "Генерал майор", 162));
            _soldiers.Add(new Soldier("Владимир", "m4a1-s", "Старшина", 35));
            _soldiers.Add(new Soldier("Михаил", "Пистолет Макарова", "Сержант", 48));
            _soldiers.Add(new Soldier("Владислав", "Negev", "Ефрейтор", 12));
        }
    }

    class Soldier
    {
        public Soldier(string name, string armament, string rank, int dutyPeriod)
        {
            Name = name;
            Armament = armament;
            Rank = rank;
            DutyPeriod = dutyPeriod;
        }

        public string Name { get; private set; }
        public string Armament { get; private set; }
        public string Rank { get; private set; }
        public int DutyPeriod { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}. Вооружение: {Armament}. Звание: {Rank}. Срок службы: {DutyPeriod} месяцев.");
        }
    }
}
