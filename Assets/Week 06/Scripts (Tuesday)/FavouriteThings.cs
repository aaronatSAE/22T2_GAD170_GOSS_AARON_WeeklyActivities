using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FavouriteThings : MonoBehaviour
{
    string[] favouriteFruits = { "Granny Smith Apple", "Banana", "Raspberries" };
    List<string> favouriteSuperHeroes = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        favouriteSuperHeroes.Add("Iron Man");
        favouriteSuperHeroes.Add("The Hulk");
        favouriteSuperHeroes.Add("Hawkeye");
        favouriteSuperHeroes.Add("Ironheart");

        favouriteSuperHeroes.Remove("Hawkeye");

        Debug.Log(favouriteFruits[0]);
        Debug.Log(favouriteFruits[1]);
        Debug.Log(favouriteFruits[2]);

        for (int i = 0; i < favouriteFruits.Length; i++)
        {
            Debug.Log(favouriteFruits[i]);
        }

        for (int i = 0; i < favouriteSuperHeroes.Count; i++)
        {
            Debug.Log(favouriteSuperHeroes[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
