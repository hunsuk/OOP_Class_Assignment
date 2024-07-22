namespace OOP
{
    struct Test
    {
        public string name;
    }

    class Test2
    {
        public string name;
    }


    internal class Program
    {
        
        class Chracter
        {
            int level;
            int hp;
            int speed;
            int power;
        
            public void MoveForward()
            {
                Console.WriteLine($"{speed}만큼 전진");
            }

            public void MoveBackward()
            {
                Console.WriteLine($"{speed}만큼 후진");
            }

            public void MoveRight()
            {
                Console.WriteLine($"{speed}만큼 좌회전");
            }

            public void MoveLeft()
            {
                Console.WriteLine($"{speed}만큼 좌회전");
            }

            public void Attack(Chracter enemy)
            {
                Console.WriteLine($"적을 {power} 만큼 피해를 입혔습니다.");
                enemy.damage(power);

            }

            public void damage(int amount)
            {
                Console.WriteLine($"적에게 {amount} 만큼 피해를 입었습니다.");
                hp = Math.Max(0, hp - amount);
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
