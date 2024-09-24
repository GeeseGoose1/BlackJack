namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            int playerPoints = 0;
            int dealerPoints = 0; 

            Console.WriteLine("Hej och Välkommen till BlackJack! Vill du slå eller stanna?");
            string answer = Console.ReadLine();

            while (playerPoints < 21)
            {
                //Spelarens tärning
                if (answer != "Stanna" && answer != "stanna")
                {

                    Random rand = new Random();
                    int diceNumber = rand.Next(1, 7);
                    playerPoints += diceNumber;

                    Console.WriteLine("Du slog: " + diceNumber + ", din poäng är: " + playerPoints);
                }

                //Dealerns tärning
                if (dealerPoints <= 17)
                {
                    Random randD = new Random();
                    int diceNumber2 = randD.Next(1, 7);
                    dealerPoints += diceNumber2;
                    Console.WriteLine("Dealern slog: " + diceNumber2 + ", dealerns poäng är: " + dealerPoints);
                    Console.WriteLine("Vill du slå eller stanna?");
                }
                
                //Vinnande systemet
                if (dealerPoints > 21)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Du vann!");
                    break;
                } 
                if (playerPoints > 21)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Dealern vann!");
                    break;
                }

                if (dealerPoints == 21)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Dealern vann!");
                    break;
                }

                if (playerPoints == 21)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Du vann!");
                    break;
                }

                //"Stanna" vinn systemet
                if (answer == "Stanna" || answer == "stanna" && dealerPoints > playerPoints)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Dealern vann!");
                    break;
                }

                else if (answer == "Stanna" || answer == "stanna" && dealerPoints < playerPoints)
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Du vann!");
                    break;
                }
                
                else if (answer == "Stanna" || answer == "stanna" && dealerPoints == playerPoints) 
                {
                    Console.WriteLine("Dealern fick: " + dealerPoints + ", Du fick: " + playerPoints + ". Dealern vann!");
                    break;
                }

                //HEJ
                answer = Console.ReadLine();
            }
            

            

            

           
 

            




        }
    }
}
