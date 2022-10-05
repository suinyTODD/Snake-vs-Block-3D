using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public int Level;
    public GameObject winScreen;

    public GameObject intrfc;
    public Control mainSnake;
  

    [System.Obsolete]
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            winScreen.SetActive(true);
            intrfc.SetActive(false);
            Time.timeScale = 0;
        }
        Debug.Log("You win");

    }
}
