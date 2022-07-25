using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class WeekEight : MonoBehaviour
    {
        /// <summary>
        /// My fruit enumerator.
        /// </summary>
        public enum Fruit
        {
            /// <summary>
            /// The apple!
            /// </summary>
            Apple,
            /// <summary>
            /// The banana!
            /// </summary>
            Banana,
            /// <summary>
            /// The orange!
            /// </summary>
            Orange,
            Strawberry,
            Mango,
            Kiwi,
            Watermelon,
            Peach
        }

        /// <summary>
        /// The possible states for the AI agent.
        /// </summary>
        public enum AIState
        {
            /// <summary>
            /// The state has not yet been defined.
            /// </summary>
            Undefined,
            /// <summary>
            /// Plays an idle animation, but does not move, attack, or detect anything.
            /// </summary>
            Idle,
            Chasing,
            Attacking,
            Dying
        }

        public Fruit favouriteFruitOfAaron = Fruit.Mango;
        public Fruit favouriteFruitOfMitch = Fruit.Banana;
        public Fruit favouriteFruitOfRachelle = Fruit.Watermelon;
        public Fruit favouriteFruitOfOwen = Fruit.Kiwi;
        public Fruit favouriteFruitOfCallum = Fruit.Mango;
        public Fruit favouriteFruitOfChester = Fruit.Watermelon;

        public Fruit[] fruitBasket = new Fruit[10];

        /// <summary>
        /// fdksa fhdsalf dsiao fdslk afd
        /// </summary>
        void Start()
        {
            CheckBasketWithSwitch();
        }

        // Update is called once per frame
        void Update()
        {
            //favouriteFruit = Fruit.Orange;
        }

        private void CheckBasketWithIfElse()
        {
            for (int i = 0; i < fruitBasket.Length; i++)
            {
                if (fruitBasket[i] == favouriteFruitOfAaron)
                {
                    Debug.Log("This is Aaron's favourite fruit!");
                }
                else if (fruitBasket[i] == favouriteFruitOfCallum)
                {
                    Debug.Log("Callum's favourite fruit!");
                }
                // etc... it will get LONG
            }
        }

        private void CheckBasketWithSwitch()
        {
            for (int i = 0; i < fruitBasket.Length; i++)
            {
                switch (fruitBasket[i])
                {
                    case Fruit.Apple:
                        // logic
                        Debug.Log("Apple!");
                        break;
                    case Fruit.Banana:
                        // logic
                        Debug.Log("Banana!");
                        break;
                    case Fruit.Orange:
                        // logic
                        Debug.Log("Orange!");
                        break;
                    case Fruit.Strawberry:
                        // logic
                        Debug.Log("Strawberry!");
                        break;
                    default:
                        // logic if no other case returned true (i.e. FAIL)
                        Debug.Log("Some other fruit!");
                        break;
                }
            }
        }
    }
}
