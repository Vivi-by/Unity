using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text text;
    void Start()
    {
        text.text = "Coins: " + coins;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Debug.Log("You collected a coin!");
            coins += 1;
            text.text = "Coins: " + coins;
        }
        if (collision.gameObject.tag == "Big Coin")
        {
            Debug.Log("You collected 5 coins!");
            coins += 5;
            text.text = "Coins: " + coins;
        }
        
    }
}
