using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Restartscript : MonoBehaviour
{

    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
