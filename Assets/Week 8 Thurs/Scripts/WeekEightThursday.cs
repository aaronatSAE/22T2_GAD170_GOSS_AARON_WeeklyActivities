using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class WeekEightThursday : MonoBehaviour
    {
        public enum Fruit
        {
            Apple,
            Banana,
            Mango,
            Dragonfruit,
            Orange,
            Pear
        }

        public Fruit favouriteFruit = Fruit.Dragonfruit;
        public Fruit[] myFruitBasket = new Fruit[10];

        /// <summary>
        /// The possible states that our AI can perform.
        /// </summary>
        public enum AIState
        {
            /// <summary>
            /// We need to choose another.
            /// </summary>
            Undefined,
            /// <summary>
            /// Play idle animation, but don't move or attack or see enemies.
            /// </summary>
            Idle,
            /// <summary>
            /// Attacks, but does not move.
            /// </summary>
            Attacking,
            Chasing,
            Fleeing,
            Dancing,
            Dying
        }

        private void Start()
        {
            favouriteFruit = Fruit.Mango;
            //Debug.Log("My favourite fruit is " + favouriteFruit);

            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                //myFruitBasket[i] = Fruit.Orange;

                //Debug.Log("These are the fruit in my basket: " + myFruitBasket[i]);
                //Debug.Log("My basket is full of " + myFruitBasket[i]);
                Debug.Log("The fruit I picked out of my basket was a " + myFruitBasket[i]);

                CheckFruit(myFruitBasket[i]);
            }
        }

        private void CheckFruit(Fruit typeOfFruit)
        {
            // We want to output different text depending on which fruit was chosen.
            // If it is an apple, do X.
            // If it is a banana, do Y.
            // ...etc

            switch (typeOfFruit)
            {
                case Fruit.Apple:
                    break;
                case Fruit.Banana:
                    break;
                case Fruit.Mango:
                    // YES; MANGOS
                    break;
                default:
                    break;
            }
        }
    }
}
