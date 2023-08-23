using System.Data;

namespace RPG
{
    public class Character
    {
        public string name;
        public string job;
        public int level;
        public int attack;
        public int defense;
        public int hp;
        public int gold;

        public Character(string _name, string _job, int _level, int _attack, int _defense, int _hp, int _gold)
        {
            name = _name;
            job = _job;
            level = _level;
            attack = _attack;
            defense = _defense;
            hp = _hp;
            gold = _gold;
        }
        internal class Program
        {
            public static Character player;

            static void Main(string[] args)
            {
                GameDataSetting();
                DisplayGameIntro();
                

                static void GameDataSetting()
                {
                    // 캐릭터 정보 세팅
                    player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

                    // 아이템 정보 세팅
                }
                static void DisplayGameIntro()
                {
                    while (true)
                    {
                        Console.Clear();

                        Console.Clear();
                        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                        Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
                        Console.WriteLine();
                        Console.WriteLine("1. 상태보기");
                        Console.WriteLine("2. 인벤토리");
                        Console.WriteLine("3. 상점");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");

                        int input = CheckValidInput(0, 3);
                        switch (input)
                        {
                            case 0:
                                return;
                            case 1:
                                DisplayMyInfo();
                                break;

                            case 2:
                                DisplayInventory();
                                break;

                            case 3:
                                DisplayShop();
                                break;
                        }
                    }
                }


                static void DisplayInventory()
                {
                    Console.WriteLine("   무쇠갑옷    | 방어력 + 5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                    Console.WriteLine("   낡은 검     | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검입니다.");
                    Console.WriteLine("   무쇠갑옷    | 방어력 + 9 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                    Console.WriteLine("스파르타의 창  | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
                    Console.WriteLine("   빨간 물약   | Hp를 회복시켜주는 물약입니다.");
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine("1. 장착 관리");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");


                    int input = CheckValidInput(0, 1);
                    switch (input)
                    {
                        case 0:
                            return;

                        case 1:
                            DisplayInventory();

                            break;

                    }
                    static void DisplayItemUsing()
                    {
                        while (true)
                        {
                            Console.WriteLine("인벤토리 - 장착 관리");
                            Console.WriteLine("  보유 중인 아이템을 관리할 수 있습니다.");
                            Console.WriteLine();
                            Console.WriteLine("          [아이템 목록]");
                            Console.WriteLine("1.  무쇠 갑옷   | 방어력 + 5  | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                            Console.WriteLine("2.   낡은 검    | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검입니다.");
                            Console.WriteLine("3.   무쇠갑옷   | 방어력 + 9 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                            Console.WriteLine("4.스파르타의 창 | 공격력 + 7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
                            Console.WriteLine();
                            Console.WriteLine("0. 나가기");
                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                                }

                    }
                   static void DisplayShop()
                    {
                        Console.WriteLine("  수련자 갑옷    | 방어력 + 5 |         수련에 도움을 주는 갑옷입니다.            | 1000 G");
                        Console.WriteLine("    무쇠갑옷     | 방어력 + 9 |       무쇠로 만들어져 튼튼한 갑옷입니다.          | 구매완료");
                        Console.WriteLine(" 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
                        Console.WriteLine("     낡은검      | 공격력 + 2 |        쉽게 볼 수 있는 낡은 검 입니다.            | 600  G");
                        Console.WriteLine("    청동 도끼    | 공격력 + 5 |        어디선가 사용됐던거 같은 도끼입니다.       | 1500 G");
                        Console.WriteLine("  스파르타의 창  | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.   | 구매완료");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.WriteLine();
                        Console.WriteLine("1. 아이템 구매");
                        Console.WriteLine("0. 나가기");

                        int input = CheckValidInput(0, 1);
                        switch (input)
                        {
                            case 0:
                                return;

                            case 1:
                                DisplayGameIntro();
                                break;

                        }
                        Console.WriteLine("1.  수련자 갑옷    | 방어력 + 5 |         수련에 도움을 주는 갑옷입니다.            | 1000 G");
                        Console.WriteLine("2.   무쇠갑옷     | 방어력 + 9 |       무쇠로 만들어져 튼튼한 갑옷입니다.          | 구매완료");
                        Console.WriteLine("3. 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
                        Console.WriteLine("4.     낡은검      | 공격력 + 2 |        쉽게 볼 수 있는 낡은 검 입니다.            | 600  G");
                        Console.WriteLine("5.    청동 도끼    | 공격력 + 5 |        어디선가 사용됐던거 같은 도끼입니다.       | 1500 G");
                        Console.WriteLine("6.  스파르타의 창  | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.   | 구매완료");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        int _input = CheckValidInput(0, 6);
                        switch (input)
                        {
                            case 0:
                                return;

                            case 1:
                                Console.WriteLine("아이템 구매");
                                break;
                            case 2:
                                Console.WriteLine("아이템 구매");
                                break;
                            case 3:
                                Console.WriteLine("아이템 구매");
                                break;
                            case 4:
                                Console.WriteLine("아이템 구매");
                                break;
                            case 5:
                                Console.WriteLine("아이템 구매");
                                break;
                            case 6:
                                Console.WriteLine("아이템 구매");
                                break;

                        }
                        Console.WriteLine();
                        Console.WriteLine("구매가 완료 되었습니다.");



                    }


                    int _input = CheckValidInput(1, 3);
                    switch (input)
                    {

                        case 1:
                            DisplayMyInfo();
                            break;

                        case 2:
                            DisplayInventory();
                            break;

                        case 3:
                            DisplayShop();
                            break;
                    }
                }
                static void DisplayMyInfo()
                {
                    Console.Clear();

                    Console.WriteLine("상태보기");
                    Console.WriteLine("캐릭터의 정보를 표시합니다.");
                    Console.WriteLine();
                    Console.WriteLine($"Lv.{player.level}");
                    Console.WriteLine($"{player.name}({player.job})");
                    Console.WriteLine($"공격력 : {player.attack}");
                    Console.WriteLine($"방어력 : {player.defense}");
                    Console.WriteLine($"체력 : {player.hp}");
                    Console.WriteLine($"Gold : {player.gold} g");
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    int input = CheckValidInput(0, 0);
                    switch (input)
                    {
                        case 0:
                            return;
                    }
                }
                static int CheckValidInput(int min, int max)
                {
                    while (true)
                    {
                        string input = Console.ReadLine();

                        bool parseSuccess = int.TryParse(input, out var ret);
                        if (parseSuccess)
                        {
                            if (ret >= min && ret <= max)
                                return ret;
                        }
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
            }
        }
    }
}




