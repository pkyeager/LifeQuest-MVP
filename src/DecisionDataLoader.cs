// really buggy and not working, but I'm leaving it here for now in case I want to come back to it later


// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Text.Json;

// namespace LifeQuest
// {
//     public class DecisionDataLoader
//     {
//         // Path to the JSON file that contains the decision data
//         private string jsonFilePath = "assets/decisions.json";

//         public List<Decision> LoadDecisionsForStage(string stage)
//         {
//             try
//             {
//                 string jsonData = File.ReadAllText(jsonFilePath);
//                 List<Stage> allStages = JsonSerializer.Deserialize<List<Stage>>(jsonData);

//                 // Find the specific stage by name
//                 Stage targetStage = allStages.FirstOrDefault(s => s.lifeStage == stage);

//                 if (targetStage != null)
//                 {
//                     return targetStage.decisions;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Stage '{stage}' not found in decision data.");
//                     return null;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error loading decision data: {ex.Message}");
//                 return null;
//             }
//         }
//     }
// }
