using UnityEngine;

public class Loop1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 17; i <= 192; i++)
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
