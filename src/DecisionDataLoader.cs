using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using LifeQuest;

// Path to the JSON file that contains the decision data
string jsonFilePath = "assets/decisions.json";

public class DecisionDataLoader
{
    public List<Stage> LoadDecisionData(string jsonFilePath)
    {
        try
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            List<Stage> decisionData = JsonSerializer.Deserialize<List<Stage>>(jsonData);
            return decisionData;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading decision data: {ex.Message}");
            return null;
        }
    }
}
