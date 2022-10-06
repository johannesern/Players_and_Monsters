namespace Players_and_Monsters
{
	internal class Program
	{
		public static List<Player> allPlayers = new List<Player>();
		public static List<Enemy> allEnemies = new List<Enemy>();
		static void Main(string[] args)
		{

			MenuControl();

		}
		private static void MenuControl()
		{
			bool run = true;
			while (run)
			{
				Console.WriteLine("=== MENU ===");
				Console.WriteLine("1. Add player");
				Console.WriteLine("2. List players");
				Console.WriteLine("3. Select player");
				Console.WriteLine("\n Chose > ");

				int menuChoise = Convert.ToInt32(Console.ReadLine());

				switch (menuChoise)
				{
					case 1:
						{
							AddPlayer();
							break;
						}						
					case 2:
						{
							ListPlayer();
							break;
						}						
					case 3:
						{
							SelectPlayer();
							break;
						}						
					case 4:
						{
							AddPlayer();
							break;
						}						
					default:
						{
							break;
						}
				}
			}
		}
		public static void AddPlayer()
		{
			string name = Console.ReadLine();
			int strength = int.Parse(Console.ReadLine());
			Player player = new Player(name, strength);
			allPlayers.Add(player);
		}
		public static void ListPlayer()
		{
			foreach(Player player in allPlayers)
			{
				Console.WriteLine(player);
			}
		}
	}
	interface ICharacters
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public bool IsDead { get; set; }
		void Attack();
		void GetsHit();
		void Die();
	}

	public class Player : ICharacters
	{
		// Variables
		public string Name { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public bool IsDead { get; set; }

		public Player(string name, int strength)
		{
			Name = name;
			Health = 100;
			Strength = strength;
			IsDead = false;
		}

		// Methods
		public void Attack()
		{
			
		}
		public void GetsHit()
		{
			int hitValue = 10;
			GetHitvalue(hitValue);
		}
		private void GetHitvalue(int hitValue)
		{
			Health -= hitValue;
			if (Health > 0)
			{
				Console.WriteLine($"Got hit");
			}

			if (Health <= 0)
			{
				Die();
			}
		}
		public void Die()
		{
			
		}
	}

	abstract class Enemy : ICharacters
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public bool IsDead { get; set; }

		public void Attack()
		{

		}
		public void GetsHit()
        {
			int hitValue = 10;
			GetHitvalue(hitValue);            
        }
		private void GetHitvalue(int hitValue)
		{
			Health -= hitValue;
			if (Health > 0)
			{
				Console.WriteLine($"Got hit");
			}

			if (Health <= 0)
			{
				Die();
			}
		}
		public void Die()
		{

		}
	}

	class Monster : Enemy
	{
		
	}
}

 //public class Enenmy
 //   {
 //       public int Health { get; set; }
 //       public string Name { get; set; }
 //       public bool IsDead { get; set; }

 //       public Enenmy(string name)
 //       {
 //           Health = 100;
 //           Name = name;
 //       }
 //       public void GetsHit(int hitValue)
 //       {
 //           Health -= hitValue;
 //           if (Health > 0)
 //           {
 //               Console.WriteLine($"\nYou hit the {Name}! He was damaged for {hitValue}. He now has {Health} in health remaining. Make another choice!\n");
 //           }

 //           if (Health <= 0)
 //           {

 //               Die();

 //           }


 //       }
 //       private void Die()
 //       {
 //           Console.WriteLine($"{Name} has died.");
 //           IsDead = true;  
 //       }
 //   }