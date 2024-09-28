using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

        }
        
    }

//    static void Main()
//    {
//        // Example: generate a number between 1 and 10 with the tenths place between 5 and 9,
//        // and a 70% chance for the tenths place to be 7.
//        var weightedTenths = new Dictionary<int, double> {
//            { 5, 0.1 },  // 10% chance
//            { 6, 0.1 },  // 10% chance
//            { 7, 0.7 },  // 70% chance
//            { 8, 0.05 }, // 5% chance
//            { 9, 0.05 }  // 5% chance
//        };

//        // Example usage
//        double randomNumber = CustomRandomNumber(1, 10, weightedTenths);
//        Debug.Log(randomNumber);
//    }

//    static double CustomRandomNumber(int minValue, int maxValue, Dictionary<int, double> weightedTenths)
//    {
//        Random random = new Random();

//        // Generate the integer part
//        int integerPart = random.Next(minValue, maxValue + 1);

//        // Generate the tenths place based on weighted probabilities
//        int tenthsPlace = GetWeightedRandom(weightedTenths, random);

//        // Generate the hundredths and thousandths places randomly
//        int hundredthsPlace = random.Next(0, 10);
//        int thousandthsPlace = random.Next(0, 10);

//        // Construct the final number
//        double randomNumber = integerPart + tenthsPlace * 0.1 + hundredthsPlace * 0.01 + thousandthsPlace * 0.001;
//        return Math.Round(randomNumber, 3);
//    }

//    static int GetWeightedRandom(Dictionary<int, double> weightedValues, Random random)
//    {
//        double total = weightedValues.Values.Sum();
//        double randomValue = random.NextDouble() * total;

//        foreach (var item in weightedValues)
//        {
//            if (randomValue < item.Value)
//                return item.Key;
//            randomValue -= item.Value;
//        }

//        // Default return in case something goes wrong (this shouldn't happen)
//        return weightedValues.Keys.First();
//    }
//}
}
