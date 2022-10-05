using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TailMovement : MonoBehaviour
{
    
    public float tailSpeed;

    public Vector3 tailTarget;
    public int index;
    public GameObject tailTargetObj;
    public Control mainSnake;

    void Start()
    {
       
        mainSnake = GameObject.FindGameObjectWithTag("Player").GetComponent<Control>();
        tailSpeed = mainSnake.Speed;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);
        
    }
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * tailSpeed);
        Debug.Log(index);
    }
    
}
