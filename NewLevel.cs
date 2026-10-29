using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //any time we are looping through something, it can be heavy in processing
        //for loop is the most common form of looping through repeated behavior
        //as we example: loop through all the enemies, shoot at nearest one
        //for loop anatomy: first, has a starting variable, then break condition,
        //finally an operation that happens each loop

        for (int i = 0; i < 100; i++)
        {
            //for each number starting at 0 and going up to 9, will do something
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
