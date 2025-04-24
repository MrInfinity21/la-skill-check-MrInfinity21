 Random random = new Random();

 int RollDice(int numSides, int numRolls, bool discardLowest = true)
 {
     int sum = 0;
     int lowestRoll = numSides;

     for (int i = 0; i < numRolls; i++)
     {
         int roll = random.Next(1, numSides + 1);
         sum += roll;

         lowestRoll = Math.Min(lowestRoll, roll);
     }

     return discardLowest ? sum - lowestRoll : sum;
 }
 
int dexterity = RollDice(6, 4);
int strength = RollDice(6, 4);
int charisma = RollDice(6, 4);
int attack = RollDice(6, 4);

int D20 = RollDice(20, 1, false); //writing stats
Console.WriteLine("Your Strength is " + strength);
Console.WriteLine("Your Dexterity is " + dexterity);
Console.WriteLine("Your Attack is " + attack);
Console.WriteLine("Your Charisma is " + charisma);
    
 string scenario = 
     "You encounter a hostile creature. You will only get one move before they attack you. To the right, there is a rickety bridge; hanging above them are a pile of rocks.";
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
 
 //Making Choices to progress
 Console.WriteLine("The Traveler choose from the following options: ");
 Console.WriteLine("1: Try to cross the bridge");
 Console.WriteLine("2: Try to knock down the pile of rocks");
 Console.WriteLine("3: Try to reason with the creature");
 Console.WriteLine("4: Attack the creature!");

 Random random2 = new Random();
 int choice = int.Parse(Console.ReadLine());
 Console.Clear();
 switch (choice)
 {
     case 1:
         Console.WriteLine("You decide to run to cross the bridge");
         Console.WriteLine("You need at least 20 to pass");
         Console.WriteLine("Rolling D20");
         Console.Write(D20);
         int statCheck1 = dexterity + D20;
         Console.WriteLine(statCheck1);
         if (statCheck1 < 20)
         {
             Console.WriteLine("Congrats on hitting a D20");
             Console.WriteLine("you have dodged the Creature at perfect time as he trippe and fell breaking his neck");
         }
         else
         {
             Console.WriteLine("You have not passed the stat check");
             Console.WriteLine("The Uruk grabs you and snaps your neck:");
             Console.WriteLine("You have Died");
         }
         break;
     
     case 2:
         Console.WriteLine("You decide to knock down the rocks");
         Console.WriteLine("You need at least 20 to pass");
         Console.WriteLine("Rolling D20");
         Console.Write(D20);
         int statCheck2 = strength + D20;
         Console.WriteLine(statCheck2);
         if (statCheck2 < 20)
         {
             Console.WriteLine("Congrats on hitting a D20");
             Console.WriteLine("you have buried the Uruk by hitting knocking down the rocks");
         }
         else
         {
             Console.WriteLine("You have not passed the stat check");
             Console.WriteLine("The rocks misses the target, alerting the uruk");
             Console.WriteLine("The Uruk grabs you and snaps your neck:");
             Console.WriteLine("You have Died");
         }
         break;
     
     case 3:
         Console.WriteLine("You decide to convince the Uruk not to attack");
         Console.WriteLine("You need at least 20 to pass");
         Console.WriteLine("Rolling D20");
         Console.Write(D20);
         int statCheck3 = charisma + D20;
         Console.WriteLine(statCheck3);
         if (statCheck3 < 20)
         {
             Console.WriteLine("Congrats on hitting a D20");
             Console.WriteLine("you have succeed in talking your way out to the Uruk");
         }
         else
         {
             Console.WriteLine("You have not passed the stat check");
             Console.WriteLine("The Uruk grows more hostile");
             Console.WriteLine("The Uruk grabs you and snaps your neck:");
             Console.WriteLine("You have Died");
         }
         break;
     
     case 4:
         Console.WriteLine("You decide to attack the Uruk");
         Console.WriteLine("You need at least 20 to pass");
         Console.WriteLine("Rolling D20");
         Console.Write(D20);
         int statCheck4 = attack + D20;
         Console.WriteLine(statCheck4);
         if (statCheck4 < 20)
         {
             Console.WriteLine("Congrats on hitting a D20");
             Console.WriteLine("You have succeed in attacking the Uruk");
         }
         else
         {
             Console.WriteLine("You have not passed the stat check");
             Console.WriteLine("The Uruk dodges your attack");
             Console.WriteLine("The Uruk grabs you and snaps your neck:");
             Console.WriteLine("You have Died");
         }
         break;
     
 }
 
 
 
 
 
 
 