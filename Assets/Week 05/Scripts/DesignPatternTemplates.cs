using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPatternTemplates : MonoBehaviour
{
    #region Frame Rate Info
    // 60 fps....... what does it mean?!
    // 60 Frames Per Second
    // this means we have 16.67 milliseconds per frame
    // if "GameObject.FindGameObjectsWithTag("Enemy");" takes 1 millisecond...
    // ...we can only perform 16 of them before our FRAMERATE IS AFFECTED
    // So, we do things to prevent that:
    // - Don't use GameObject.FindX during gameplay
    // - If you have to, stagger it using a coroutine
    // - Get all your Finds done at game start
    // - When you Instantiate an object, store a REFERENCE to it (the best way??)
    // - Add objects manually in the Inspector
    #endregion

    [SerializeField] private List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        ResetAllEnemiesForLoop();
    }

    private void ResetAllEnemies()
    {
        // I need to get all of the enemies in the scene, reset their health,
        // reset their position to where they spawned, and stop any animations they are playing.
        // How do I go through my whole list of enemies?
        // What do I use?
        // ...a FOR LOOP


        // BAD:
        enemies[0].transform.position = Vector3.zero; // Vector3.zero is equal to Vector3(0, 0, 0)
        enemies[1].transform.position = Vector3.zero;
        enemies[2].transform.position = Vector3.zero;
        enemies[3].transform.position = Vector3.zero;
        // ...and so on...

        // Using a tag:
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject.Find("Enemy (1)");
        allEnemies[0].transform.position = Vector3.zero;
        allEnemies[1].transform.position = Vector3.zero;
        allEnemies[2].transform.position = Vector3.zero;
    }

    private void ResetAllEnemiesForLoop()
    {
        // I need to get all of the enemies in the scene, reset their health,
        // reset their position to where they spawned, and stop any animations they are playing.
        // How do I go through my whole list of enemies?
        // What do I use?
        // ...a FOR LOOP

        // A for loop has 4 parts, that each tell the computer one instruction:
        //  int i = 0; "Computer, declare an integer called i, and give it the value 0."
        //  i < length; (which we replaced above with enemies.Count)
        //      ^ comparison check: "Computer, if i is less than length, perform the action below!"
        //  i++ "Computer, once we have performed our actions, increase the value of i by 1."
        //  the stuff between the { } braces
        for (int i = 0; i < enemies.Count; i++)
        {
            // Perform our actions here!
            enemies[i].transform.position = Vector3.zero;
            enemies[i].name = "Enemy " + (i + 1) + " - Reset";
            enemies[i].transform.localScale = Vector3.one;

            Debug.Log("Enemy " + (i + 1) + " has been reset.");
        }
    }
}

// Class Template
// What do I need to declare a class?
// - the word class
// - what NAME will our class will have (using PascalCase or UpperCamelCase)
// - our INHERITANCE operator : and the class it is inheriting from, if appropriate
// - a set of { } braces
// - between the { } braces go our methods and variables (data, etc)
//
// Example, a Cat class with a parent "Pet" class:
class Pet
{
    public string name;
    public int age;

    public void MakeNoise()
    {
        Debug.Log("Hello, World!");
    }
}

class Cat : Pet
{
    public new void MakeNoise()
    {
        Debug.Log("Meow");
    }
}

class MoreTemplates : MonoBehaviour
{
    // Variable Template
    // What do I need to declare a variable?
    // - what kind of ACCESS our scripts have to the variable? (eg: public, private...)
    // - what TYPE of data the variable will hold? (eg: int, float, string, bool...)
    // - what NAME will our variable have? (using lowerCamelCase)
    // For a player's health, for example, we could write:
    private int playerHealth;

    // Method Template
    // What do I need to have to declare a method?
    // - what kind of ACCESS our scripts have to the method? (eg: public, private...)
    // - What type of data the method will return (its RETURN TYPE) (eg: int, GameObject, bool... "void" returns nothing)
    // - what NAME will our method have? (using PascalCase or UpperCamelCase)
    // - between the ( ) parentheses, we have any PARAMETERS (which in turn, have TYPE and NAME, and can have VALUE too)
    // - between the { } braces, our actions/stuff to do
    // - if the method RETURNS something, RETURN it
    //
    // For calculating the highest score between two players, for example, we could write:
    private int HighestScore(int scoreOne, int scoreTwo)
    {
        if(scoreOne > scoreTwo)
        {
            Debug.Log("Player 1 has a higher score.");
            return scoreOne;
        }
        else if(scoreOne == scoreTwo)
        {
            Debug.Log("Neither is greater!");
            return scoreOne;
        }
        else // perform everything else
        {
            Debug.Log("Player 2 has a higher score.");
            return scoreTwo;
        }
    }
}
