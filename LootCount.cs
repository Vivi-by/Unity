using UnityEngine;

public class LootCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int attack = 100;
        int r = 95;
        if(attack >= 100)
        {
            Debug.Log("You defeated the enemy!");
        }
        if(attack < 100)
        {
            Debug.Log("You need more points!");
        }
        if(r >= 90)
        {
            Debug.Log("Special Weapon dropped");
        }
        if(r < 90)
        {
            Debug.Log("The enemy has dropped a normal weapon");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
