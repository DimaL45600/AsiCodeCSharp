namespace FirstGameLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
        }
    }
    public class Game
    {
        private static string gameName = "Medieval Tactic";
        private static string gameVerion = "a0.0.1";

        private const int fieldWidth = 8;
        private const int fieldHeight = 8;

        private List<Character> playerCharacters;
        private List<Character> enemyCharacters;

        public Game()
        {
            playerCharacters = new List<Character>()
            {
                new Character(CharacterTypes.Warior, new Coordinates(1,4)),
                new Character(CharacterTypes.Archer, new Coordinates(0,3)),
                new Character(CharacterTypes.Balista, new Coordinates(0,5)),
            };
            enemyCharacters = new List<Character>()
            {
                new Character(CharacterTypes.Warior, new Coordinates(6,4)),
                new Character(CharacterTypes.Archer, new Coordinates(7,2)),
                new Character(CharacterTypes.Balista, new Coordinates(7,6)),
            };
        }

        public void StartGame()
        {
            while (true)
            {
                RenderGame();
                PlayerMove();
            }
            
            Console.ReadKey();
        }
        private void RenderGame()
        {
            Console.Clear();
            Render.RenderField(fieldWidth, fieldHeight);
            Render.RenderPlayerCharacters(playerCharacters);
            Render.RenderEnemyCharacters(enemyCharacters);
            Console.SetCursorPosition(0, 25);
        }
        private void PlayerMove()
        {
            foreach (Character character in playerCharacters)
            {
                if (character.IsAlive)
                {
                    Console.WriteLine($"{character.Type} in position ({character.Position.X},{character.Position.Y})");
                    Console.WriteLine("1 - move");
                    Console.WriteLine("2 - attack");
                    Console.WriteLine("Select action!");
                    var action = Console.ReadKey();
                    while(action.Key != ConsoleKey.D1 && action.Key != ConsoleKey.D2)
                    {
                        action = Console.ReadKey();
                    }
                    switch (action.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("Select Diraction!");
                            var direction = Console.ReadKey();
                            while (direction.Key != ConsoleKey.W && direction.Key != ConsoleKey.S && direction.Key != ConsoleKey.A && direction.Key != ConsoleKey.D)
                            {
                                direction = Console.ReadKey();
                            }
                            switch (direction.Key)
                            {
                                case ConsoleKey.S:
                                    character.Move = new Coordinates(character.Position.X, character.Position.Y + 1);
                                    break;
                                case ConsoleKey.W:
                                    character.Move = new Coordinates(character.Position.X, character.Position.Y - 1);
                                    break;
                                case ConsoleKey.A:
                                    character.Move = new Coordinates(character.Position.X - 1, character.Position.Y);
                                    break;
                                case ConsoleKey.D:
                                    character.Move = new Coordinates(character.Position.X + 1, character.Position.Y);
                                    break;
                            }
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine("Attack action");
                            break;
                    }
                }
            }
        }

    }
    public static class Render
    {
        public static void RenderField(int width, int height)
        {
            for (int i = 0;i <= height*3; i++)
            {
                for(int j = 0;j <= width * 4; j++)
                {
                    if (i%3 == 0 || i == 0)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        if(j == 0 || j % 4 == 0)
                        {
                            Console.Write('|');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void RenderPlayerCharacters(List<Character> characters)
        {
            foreach(var character in characters)
            {
                if (character.IsAlive)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(2 + (4 * character.Position.X),1 + (3 * character.Position.Y));
                    switch (character.Type)
                    {
                        case CharacterTypes.Warior:
                            Console.Write('W');
                            break;
                        case CharacterTypes.Archer:
                            Console.Write('A');
                            break;
                        case CharacterTypes.Balista:
                            Console.Write('B');
                            break;
                    }
                    if (character.Health > 100)
                    {
                        Console.SetCursorPosition(1 + (4 * character.Position.X), 2 + (3 * character.Position.Y));
                    }
                    else
                    {
                        Console.SetCursorPosition(2 + (4 * character.Position.X), 2 + (3 * character.Position.Y));
                    }
                    Console.Write(character.Health);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public static void RenderEnemyCharacters(List<Character> characters)
        {
            foreach (var character in characters)
            {
                if (character.IsAlive)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2 + (4 * character.Position.X), 1 + (3 * character.Position.Y));
                    switch (character.Type)
                    {
                        case CharacterTypes.Warior:
                            Console.Write('W');
                            break;
                        case CharacterTypes.Archer:
                            Console.Write('A');
                            break;
                        case CharacterTypes.Balista:
                            Console.Write('B');
                            break;
                    }
                    if (character.Health > 100)
                    {
                        Console.SetCursorPosition(1 + (4 * character.Position.X), 2 + (3 * character.Position.Y));
                    }
                    else
                    {
                        Console.SetCursorPosition(2 + (4 * character.Position.X), 2 + (3 * character.Position.Y));
                    }
                    Console.Write(character.Health);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
    public class Character
    {
        Coordinates coordinates;
        CharacterTypes type;
        bool isAlive;
        int health;
        int armor;
        int attackPower;
        int attackRange;
        public int Health { get { return health; } }
        public int Damage
        {
            set {
                if(value - armor >= health)
                {
                    health = 0;
                    isAlive = false;
                }
                else
                {
                    health -= value - armor;
                }
            }
        }
        public int Attack { get { return attackPower; } }
        public CharacterTypes Type { get { return type; } }
        public bool IsAlive { get { return isAlive; } }
        public Coordinates Position { get { return coordinates; } }
        public Coordinates Move { 
            set {
                if (Math.Abs(coordinates.X - value.X) <= 1 || Math.Abs(coordinates.Y - value.Y) <= 1)
                {
                    coordinates = value;
                }
                else
                {
                    coordinates = new Coordinates((coordinates.X - value.X) > 0? coordinates.X-1: (coordinates.X - value.X) < 0? coordinates.X + 1: coordinates.X, (coordinates.Y - value.Y) > 0 ? coordinates.Y - 1 : (coordinates.Y - value.Y) < 0 ? coordinates.Y + 1 : coordinates.Y);
                }
            } 
        }
        public Character(CharacterTypes type, Coordinates coordinates)
        {
            this.type = type;
            this.coordinates = coordinates;
            isAlive = true;
            switch(type)
            {
                case CharacterTypes.Warior:
                    health = 250;
                    armor = 80;
                    attackPower = 100;
                    attackRange = 1;
                    break;
                case CharacterTypes.Archer:
                    health = 160;
                    armor = 30;
                    attackPower = 150;
                    attackRange = 2;
                    break;
                case CharacterTypes.Balista:
                    health = 80;
                    armor = 10;
                    attackPower = 260;
                    attackRange = 3;
                    break;
            }
        }
    }
    public enum CharacterTypes
    {
        Warior,
        Archer,
        Balista,
    }
    public class Coordinates
    {
        int x;
        int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool isCollide(Coordinates other)
        {
            return (this.x == other.x && this.y == other.y);
        }
    }
}
