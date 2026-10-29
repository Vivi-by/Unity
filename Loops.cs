using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        //any time we are looping through something, it can be heavy in processing
        //for loop is the most common form of looping through repeated behavior
        //as an example: loop through all the enemies, shoot at the nearest one
        //for loop anatomy: first, has a starting variable, then break condition
        //finally an operation that happens each loop
        for (int i = 1; i <= 10000; i++)
        {
            //for each number starting at 0 and going up to 9, will do something
            //Debug.Log(i);
        }
        //I want to add up all the numbers from 1 to 75 using a for loop
        int sum = 0;
        for (int i = 1; i <= 75; i++)
        {
            //sum up the values
           
            sum += i;
        }
        //Debug.Log(sum);

        //I want to know the locations of all enemies in the level
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //[] means its an array of the varaible
        //an array is a collection of variables of the same type
        //this is an array (collection) of all the GameObjects tagged as enemy in the scene
        //now we can loop through the array to Debug.Log their locations
        for(int i = 0; i < enemies.Length; i++)
        {
            //as long as i is less than the length of the array (how many variables are in it)
            Debug.Log(enemies[i].transform.position);
            //arrays start counting at Index = 0 (index means the location)
        }

        //CHALLENGE: Create a for loop to add up all the numbers from 17 to 192
        
    }

    // Update is called once per frame
    void Update()
    {
        //DANGER ZONE
        //nested loops = loops inside another loop
        //nested loops are scary
    }
}
