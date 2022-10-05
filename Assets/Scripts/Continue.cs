using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Continue : MonoBehaviour
{
    public Text cont;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
          
        }
    }
 
}
