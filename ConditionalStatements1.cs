using UnityEngine;

public class ConditionalStatements1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (true)
        {
            //this code will always run
        }
        if (false)
        {
            //this code will never run
        }
        if(true && true)
        {
            //true && true is true, so this code will run
        }
        if(true && false)
        {
            //true && false, at least one of these is false, so the code doesn't run
            //you have enough money, but charisma isn't high enough to bribe the guard
        }
        if(true || false)
        {
            //true or false,at least one of these is true, so this code runs
        }
        if(true && false || true && true && false || true && true && true || false)
        {
            //START PANICKING!!!
            //first break it down into each OR section, and figure out true or false
            //false || false || true || false
            //at least one of these conditions is true, so the code runs!
            //HOORAYY!!
        }
        if(true && true || false && false || true && false || true && true)
        {
            //does this code run? YES
        }
        if (false || true && !false)
        {
            //does this code run? YES. !false is true
        }
        //this is what the real world will look like
        bool hasKey = false;
        if (hasKey)
        {
            //open the door
        }
        bool hasCake = false;
        int eggs = 0;
        bool hasOil = true;
        bool hasBoxMix = true;
        bool hasMoney = false;
        if(hasCake || eggs > 0 && hasOil && hasBoxMix || hasMoney)
        {
            //i get to eat cake!!!
        }
        else
        {
            //I eat a cookie
            //else code only runs if the if condition is false, and the if code doesn't run
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
