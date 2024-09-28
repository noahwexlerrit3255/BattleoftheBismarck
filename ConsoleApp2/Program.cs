namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string germanBattleship = "Bismarck";
            string britishFleet = "Royal Navy";
            string britishBattleships = "HMS Rodney and HMS King George V";
            string britishCruisers = "HMS Norfolk and HMS Dorsetshire";

            int bismarckHealth = 200;
            int rodneyHealth = 150;
            int kingGeorgeVHealth = 150;
            int bismarckFirepower = 30;
            int britishBattleshipsFirepower = 60;
            int britishCruisersFirepower = 30;

            string bismarckStatus = "operational";
            string rodneyStatus = "operational";
            string kingGeorgeVStatus = "operational";

            Console.WriteLine("The final battle of the " + germanBattleship + " begins. The " + britishFleet + " closes in for the attack.");

            // Round 1 - British Fleet Attacks
            bismarckHealth -= britishBattleshipsFirepower;
            Console.WriteLine("The " + britishBattleships + " open fire, dealing " + britishBattleshipsFirepower + " damage to the " + germanBattleship + ".");
            Console.WriteLine(germanBattleship + " health: " + bismarckHealth);

            bismarckHealth -= britishCruisersFirepower;
            Console.WriteLine("The " + britishCruisers + " follow up with " + britishCruisersFirepower + " damage.");
            Console.WriteLine(germanBattleship + " health: " + bismarckHealth);

            // Bismarck retaliates
            rodneyHealth -= bismarckFirepower;
            Console.WriteLine(germanBattleship + " retaliates, dealing " + bismarckFirepower + " damage to HMS Rodney.");
            Console.WriteLine("HMS Rodney health: " + rodneyHealth);

            // Round 2 - British Fleet Attacks

            if (bismarckHealth <= 0)
            {
                bismarckStatus = "sinking";
                Console.WriteLine("The " + germanBattleship + " is sinking. The " + britishFleet + " is victorious!");
            }
            else
            {
                bismarckHealth -= britishBattleshipsFirepower;
                Console.WriteLine("The " + britishBattleships + " fire another salvo, dealing " + britishBattleshipsFirepower + " damage.");
                Console.WriteLine(germanBattleship + " health: " + bismarckHealth);

                kingGeorgeVHealth -= bismarckFirepower;
                Console.WriteLine(germanBattleship + " strikes back, dealing " + bismarckFirepower + " damage to HMS King George V.");
                Console.WriteLine("HMS King George V health: " + kingGeorgeVHealth);

                bismarckHealth -= britishCruisersFirepower;
                Console.WriteLine("The " + britishCruisers + " fire again, dealing " + britishCruisersFirepower + " damage.");
                Console.WriteLine(germanBattleship + " health: " + bismarckHealth);
                if (bismarckHealth <= 0)
                {
                    bismarckStatus = "sinking";
                    Console.WriteLine("The " + germanBattleship + " is sinking. The " + britishFleet + " is victorious!");
                }
                else
                {
                    bismarckHealth -= britishBattleshipsFirepower;
                    Console.WriteLine("The " + britishBattleships + " unleash a final barrage, dealing " + britishBattleshipsFirepower + " damage.");
                    Console.WriteLine(germanBattleship + " health: " + bismarckHealth);

                    bismarckHealth -= britishCruisersFirepower;
                    Console.WriteLine("The " + britishCruisers + " fire one last time, dealing " + britishCruisersFirepower + " damage.");
                    Console.WriteLine(germanBattleship + " health: " + bismarckHealth);
                }
                if (bismarckHealth <= 0)
                {
                    bismarckStatus = "sinking";
                    Console.WriteLine("The " + germanBattleship + " is sinking. The " + britishFleet + " is victorious!");
                }


            }
        }
    }
}
