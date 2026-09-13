using System;

namespace GameEnkapulationDemo
{
    public class Character
    {
        public string? characterID;
        public string? characterName;
        internal string? characterClass;
        public float health;
        public int level;


        // ATRIBUT CLASS (STATIC)
        private static int totalCharacterCount = 0;

        // METHOD CLASS (STATIC)
        public static int GetTotalCharacterCount()
        {
            return totalCharacterCount;
        }

        // KONSTRUKTOR
        // 1. Konstruktor Default
        public Character()
        {
            characterID = "UNKNOWN";
            characterName = "Hero";
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            // (inisialisasi atribut instance)
            totalCharacterCount++;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Default.");
        }
        // Konstruktor 1
        public Character(int initialLevel)
        {
            level = initialLevel;
        }

        // 2. Konstruktor Berparamenter (2 paramenter)
        public Character(string id, string name)
        {
            characterID = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;

            totalCharacterCount++;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Berparaenter (ID & Nama).");
        }

        // 3. Konstruktor Berparamenter (3 paramenter)
        public Character(string id, string name, string classType)
        {
            characterID = id;
            characterName = name;
            characterClass = "classType";
            health = 100;
            level = 1;

            totalCharacterCount++;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Berparaenter (ID, Nama, & Class).");
        }

        // 4. Konstruktor Berparamenter (4 paramenter)
        public Character(string id, string name, string cls, float hlt)
        {
            characterID = id;
            characterName = name;
            characterClass = "cls";
            health = hlt;
            level = 1;

            totalCharacterCount++;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Berparaenter (ID, Nama, Class, hlt).");
        }
        

        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {characterName} (Level {level}) memulai petualangan");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! Level sekarang: {level}");

        }
        public void TakeDamage(float dmg)
        {
            health -= dmg;
             Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa: {health}");
             if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;
            Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void ShowStarts()
        {
            Console.WriteLine("=== STARTS KARAKTER ===");
            Console.WriteLine($"ID      : {characterID}");
            Console.WriteLine($"Nama    : {characterName}");
            Console.WriteLine($"Class   : {characterClass}");
            Console.WriteLine($"Level   : {level}");
            Console.WriteLine($"Health  : {health}");
            Console.WriteLine("=======================");
        }


    }


}
