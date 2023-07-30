using System;

public class Dicegame
{
    static void Main(string[] args)
    {
        int playerRandomNum;
        int playerRandomNum2;
        int enemyRandomNum;
        int enemyRandomNum2;

        int playerPoints = 0;
        int enemyPoints = 0;

        Random random = new Random();

        while (playerPoints >= 0 || enemyPoints >= 0)
        {

            Console.WriteLine("Press any key to roll the two dices."); // Displays message asking player to press any key

            Console.ReadKey(); // Waits for the player to press any key before generating number
            //Console.Clear();// if we want to clear the previous results
            playerRandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for player
            playerRandomNum2 = random.Next(1, 7);
            Console.WriteLine("You rolled  " + playerRandomNum + " And " + playerRandomNum2); // Prints out player's randomly generated number

            playerPoints = playerPoints + playerRandomNum + playerRandomNum2;
            if (playerPoints > 100)
            {
                playerPoints = playerPoints - playerRandomNum - playerRandomNum2;
            }


            if (playerRandomNum == 1 && playerRandomNum2 == 1)
            {
                playerPoints = 0;
            }
            else if (playerRandomNum == playerRandomNum2)
            {
                if (playerPoints == 100){
                    Console.WriteLine("Total score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                    Console.WriteLine(); // Creates an empty line in between each round
                    break;
                }

                while (playerRandomNum == playerRandomNum2)
                {
                    Console.WriteLine("Press  any key again to roll the two dices."); // Displays message asking player to press any key

                    Console.ReadKey(); // Waits for the player to press any key before generating number
                                       //Console.Clear();
                    playerRandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for player
                    playerRandomNum2 = random.Next(1, 7);
                    Console.WriteLine("You rolled  " + playerRandomNum + " And " + playerRandomNum2); // Prints out player's randomly generated number
                    playerPoints = playerPoints + playerRandomNum + playerRandomNum2;
                    if (playerPoints > 100)
                    {
                        playerPoints = playerPoints - playerRandomNum - playerRandomNum2;
                    }

                    if (playerRandomNum == 1 && playerRandomNum2 == 1)
                    {
                        playerPoints = 0;
                        break;
                    }
                    if (playerPoints == 100)
                    {
                        break;
                    }
                }
            }

                if (playerPoints == 100) {
                    Console.WriteLine("Total score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                    Console.WriteLine(); // Creates an empty line in between each round
                    break;
                }


                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Waits one second

                enemyRandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for enemy
                enemyRandomNum2 = random.Next(1, 7);
                Console.WriteLine("Enemy  rolled  " + enemyRandomNum + " And " + enemyRandomNum2); // Prints out enemy's randomly generated number
                enemyPoints = enemyPoints + enemyRandomNum + enemyRandomNum2;
                if (enemyPoints > 100)
                {
                    enemyPoints = enemyPoints - enemyRandomNum - enemyRandomNum2;
                }
                

                if (enemyRandomNum == 1 && enemyRandomNum2 == 1){
                    enemyPoints = 0;
                    }
                else if (enemyRandomNum == enemyRandomNum2) {

                    if (enemyPoints == 100){
                        Console.WriteLine("Total score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                        Console.WriteLine(); // Creates an empty line in between each round
                        break;
                    }

                while (enemyRandomNum == enemyRandomNum2)
                    {
                        Console.WriteLine("...");
                        System.Threading.Thread.Sleep(1000); // Waits one second
                        enemyRandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for enemy
                        enemyRandomNum2 = random.Next(1, 7);
                        Console.WriteLine("Enemy rolled  " + enemyRandomNum + " And " + enemyRandomNum2); // Prints out enemy randomly generated number
                        enemyPoints = enemyPoints + enemyRandomNum + enemyRandomNum2;
                        if (enemyPoints > 100)
                        {
                            enemyPoints = enemyPoints - enemyRandomNum - enemyRandomNum2;
                        }
                        if (enemyRandomNum == 1 && enemyRandomNum2 == 1)
                        {
                            enemyPoints = 0;
                            break;
                        }
                        if (enemyPoints == 100)
                        {
                            break;
                        }
                    }
                }

                if (enemyPoints == 100)
                {
                    Console.WriteLine("Total score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                    Console.WriteLine(); // Creates an empty line in between each round
                    break;
                }



                // Displays player and enemy scores
                Console.WriteLine("Total score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine(); // Creates an empty line in between each round


            }

            
            if (playerPoints==100)
            {
                Console.WriteLine("You win!"); // Display a message saying player wins
            }
            else 
            {
                Console.WriteLine("You lose!"); // Display message saying player loses
            }
            

            Console.ReadKey(); // Wait for user input before console window closes
        }
    }