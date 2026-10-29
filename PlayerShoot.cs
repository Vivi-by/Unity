using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlayerShoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Ammo: " + ammo;
    }
    public GameObject bullet;
    public TMP_Text text;
    
    public float bulletSpeed = 10f;
    //the amount of ammo the player has
    public int ammo = 10;
    void OnAttack()
    {
        //check to see if we have ammo to be able to shoot
        //we also want to check to make sure the game is unpaused before we shoot
        //we can use && to combine two conditions
        if(ammo > 0 && Time.timeScale ==1)
        if(ammo > 0)
        {
            //reduce ammo
            ammo--;
            //set my ammo text
            text.text = "Ammo: " + ammo;
            Debug.Log("PEW PEW!");
            //when I push the attack button, I want to spawn in a bullet
            //I also want to push the bullet in the direction of the mouse
            //I also want to destroy the bullet after a period of time, so it doesn't live forever
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            //find where the mouse is on the screen
            Vector3 mousePos = Mouse.current.position.ReadValue();
            //need to convert from pixel coordinates to world position in the game
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            //desination - starting position to calculate the vector from the player to the mouse
            Vector3 shootDir = mousePos - transform.position;
            shootDir.Normalize();
            

            //push the bullet in the direction calculated
            //CHALLENGE:
            //Make it so the bullets go faster, but still maintain a consistent velocity
            //Try to get Enemy Health that will reduce when hit by a bullet
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
            Destroy(shot, 10);
        }
       
       
    }
    
}
