using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
public class Food : MonoBehaviour
{
    private Control componentControl;
   
    public int _foodValue;
    public TextMeshPro countFood;

    private void Start()
    {
        componentControl = GetComponent<Control>();
        _foodValue = Random.Range(3, 10);
        countFood.text = _foodValue.ToString();
    }
 
     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < _foodValue; i++)
            {
                other.GetComponent<Control>().AddTail();
            }
           
            Destroy(gameObject);
        }
    }
   

        
    
    
}

