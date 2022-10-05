using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvl5 : MonoBehaviour
{
    public Text cont;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene(0);

        }
    }
}
