using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Pause the game!");
            PauseGame();
        }
    }
    public void LoadMainMenu()
    {
        //how do I load the main menu?
        //first: ensure main menu exists as a level(scene)
        //second: actually load the level
        SceneManager.LoadScene("MainMenu2");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Resume()
    {
        //this function, when flicked, will resume the game
        Time.timeScale = 1.0f;
        GetComponent<Canvas>().enabled = false;
    }
    public void PauseGame()
    {
        //this function, when called, should pause the game
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
