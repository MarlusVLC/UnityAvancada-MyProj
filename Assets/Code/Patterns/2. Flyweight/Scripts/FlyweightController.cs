using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    //Illustrates the flyweight pattern
    //Open the profiler and click on Memory to see how much memory is being used
    //Switch between Heavy and Flyweight to compare and you should see that the difference is several hundred megabytes even though the data in this case is just 20 doubles
    public class FlyweightController : MonoBehaviour
    {
        [SerializeField] private bool useFlyWeight;
        
        private List<Heavy> heavyObjects = new List<Heavy>();

        private List<Flyweight> flyweightObjects = new List<Flyweight>();

        private const int numberOfObjects = 1000000;


        void Start()
        {

            if (!useFlyWeight)
            {
                InstantiateNormalObjects();
            }
            
            InstantiateFlyweightObjects();
        }

        [ContextMenu("Instantiate Flyweight Objects")]
        private void InstantiateFlyweightObjects()
        {
            //Generate Heavy objects that doesn't share any data

            Data data = new Data();

            for (int i = 0; i < numberOfObjects; i++)
            {
                Flyweight newFlyweight = new Flyweight(data);

                flyweightObjects.Add(newFlyweight);
            }
        }

        [ContextMenu("Instantiate Normal Objects")]
        private void InstantiateNormalObjects()
        {
            //Generate Flyweight objects

            //Generate the data that's being shared among all objects
            for (int i = 0; i < numberOfObjects; i++)
            {
                Heavy newHeavy = new Heavy();

                heavyObjects.Add(newHeavy);
            }
        }

        
        
        
    }
}
