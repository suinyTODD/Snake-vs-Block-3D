using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private Control componentControl;
    public GameObject gameOverScreen;
    public GameObject intrfc;

    private void Start()
    {
        componentControl = GameObject.FindGameObjectWithTag("Player").GetComponent<Control>();
        Time.timeScale = 1;

    }
    public void PlayerDeath()
    {
        if (componentControl.snakeLength == 0)
        {
            gameOverScreen.SetActive(true);
            intrfc.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("You die");
        }
        
    }
    public void Update()
    {
        PlayerDeath();
    }

}
