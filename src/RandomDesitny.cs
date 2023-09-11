// using System;

// namespace LifeQuest
// {
//     public class RandomDestiny
//     {
//         // Destiny attributes
//         public string name { get; set; }
//         public string description { get; set; }
//         public int lifeExpectancy { get; set; }
    
//         private int RollDiceForDestiny(Player player)
//         {
//             Random random = new Random();
//             int diceRoll = random.Next(1, 7);
//             if(diceRoll == 1)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.CarAccident();
//             }
//             else if(diceRoll == 2)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.Cancer();
//             }
//             else if(diceRoll == 3)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.HeartAttack();
//             }
//             else if(diceRoll == 4)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.Stroke();
//             }
//             else if(diceRoll == 5)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.Diabetes();
//             }
//             else if(diceRoll == 6)
//             {
//                 player.destiny = new RandomDestiny();
//                 player.destiny.Depression();
//             }
//         }

//         public void CarAccident()
//         {
//             name = "Car Accident";
//             description = "You were in a car accident. You have got some long-term injuries.";
//             lifeExpectancy -= 10;
//         }

//         public void Cancer()
//         {
//             name = "Cancer";
//             description = "You were diagnosed with cancer. You fought it and survived.";
//             lifeExpectancy -= 20;
//         }

//         public void HeartAttack()
//         {
//             name = "Heart Attack";
//             description = "You had a heart attack but you survived.";
//             lifeExpectancy = 0;
//         }

//         public void Stroke()
//         {
//             name = "Stroke";
//             description = "You had a stroke. You reacted well and survived.";
//             lifeExpectancy -= 5;
//         }

//         public void Diabetes()
//         {
//             name = "Diabetes";
//             description = "You were diagnosed with diabetes. You learn to live with it.";
//             lifeExpectancy -= 10;
//         }

//         public void Depression()
//         {
//             name = "Depression";
//             description = "You were diagnosed with depression. You learn to live with it.";
//             lifeExpectancy -= 7;
//         }
//     }

//         // Destiny constructor


//         // Destiny methods


//      // Roll dice for Destiny


// }