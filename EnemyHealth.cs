using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;

    //if enemy is hit by a bullet, reduce its health
    //if enemy health gets too low, they should die

    public GameObject healthPack;
    //this function DOES run if the collider is set to trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //if the enemy hits a bullet
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Ouch!");
            health -= 1;
            //if enemy health gets too low, destroy them
            if(health <= 0)
            {
                Destroy(gameObject);
                int r = Random.Range(1, 11);
                if(r >= 5)
                {
                    Instantiate(healthPack, transform.position, Quaternion.identity);
                }
                
            }
            


            //CHALLENGE:
            //modify enemy health to have a CHANCE of dropping a health pack object
            //create a new script on the player bullet to destroy the player bullet 
            //when it hits anything whose tag != (this means NOT equal) to the player
        }
    }
}
