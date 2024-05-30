/*In this challenge, you will implement a conditional operator to simulate a "coin toss." 
The resulting decision logic will display heads or tails. */



Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");