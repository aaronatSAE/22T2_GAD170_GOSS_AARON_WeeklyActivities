using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CheatSheet : MonoBehaviour
    {
        // TODO: Set up templates for class/variable/method/if-else/for loop

        // To declare a variable, we need:
        // - a variable to declare, for example: high score
        //
        // accessModifier Type theNameYouGiveTheVariable;
        //
        // Note: theNameYouGiveTheMethod must use lowerCamelCase.
        // 
        // For example:
        public int score;
        public int highScore;
        public List<GameObject> enemies = new List<GameObject>();

        // To declare a method, we need:
        // accessModifier ReturnType TheNameYouGiveTheMethod() { }
        // You can also include parameters, as in the second example below.
        //
        // Note: TheNameYouGiveTheMethod must use PascalCase (or UpperCamelCase).
        //
        // For example, a method that resets a high score:
        public void ScoreReset()
        {
            // This is our template!
            score = 0;
        }

        public void AddScore(int amount)
        {
            score = score + amount;

            // To declare an "if statement", we use this syntax:
            // (note: it needs to be inside a method)
            // if([value] [operator] [value]) { }
            // For example, to check if our score is higher than our high score, to save a new high score, we do...

            score = 10;
            highScore = 5;

            if(score > highScore)
            {
                highScore = score;
                // Now, highScore is equal to 10
            }
        }

        public void ResetGame()
        {
            // To declare a "for loop", we use this syntax:
            // for (int i = 0; i < length; i++)
            // {
            //
            // }
            // 
            // The logic behind a "for loop" is that it will run the code inside, as many times as you tell it to.
            // The above loop will run 4 times (once per enemy).
            // On each iteration, the code inside will execute.
            //
            // A "for loop" is essentially three instructions:
            // - Declare a variable to iterate
            // - Provide a conditional check that allow us to continue to iterate
            // - Iterate, running the code inside the { } braces
            // 
            // For example, if we needed to reset four enemies, we can write:
            for (int i = 0; i < 4; i++)
            {
                // Change what we want!
                enemies[i].transform.position = Vector3.zero;
                //enemies[i].health = 100;
                //enemies[i].selectedWeapon = GetRandomWeapon();
                // ...etc
            }
        }
    }

    // To declare a class, we need:
    // [accessModifier] [the word "class"] [ClassName]
    // {
    //
    // }
    // For example:

    public class ExampleClass : MonoBehaviour
    {
        // This class can be accessed (i.e. seen) by other classes because it is public.
        // You cannot make a private class. (In general.)
    }

    public class GameController : MonoBehaviour
    {
        public ScoreSystem scoreSystem;
    }

    public class Enemy : MonoBehaviour
    {
        GameController controller;

        public void BecomeDead()
        {
            controller.scoreSystem.IncreaseScore();
        }
    }

    public class ScoreSystem : MonoBehaviour
    {
        private int highScore = 0;

        public void IncreaseScore()
        {
            highScore += 10;
        }
    }
}

