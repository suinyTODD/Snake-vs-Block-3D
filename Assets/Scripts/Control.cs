using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Control : MonoBehaviour
{
    public float Speed;
    public float turnSpeed;
    public int snakeHp;
    public int snakeLength;
    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject TailPrefab;
    public Cube_health cbHealth;
    public TextMeshPro hpText;
    private Food food;
    private int hp;
   

    public float z_offset;

    public UnityEvent OnEat;
   
     
    public void Start()
    {
        food = GameObject.FindGameObjectWithTag("Player").GetComponent<Food>();
        AddTail();        

    }
    void Update()
    {
        hpText.text = snakeLength.ToString();
        snakeLength = tailObjects.Count;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * turnSpeed * Time.deltaTime);
        }
    }
    
    public void AddTail()
    {
        snakeLength++;
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(Instantiate(TailPrefab, newTailPos, Quaternion.identity));
        
    }
  
    public void LessTail()
    {
        snakeLength--;
        tailObjects.RemoveAt(tailObjects.Count - 1);
        Speed = 0;
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            if (OnEat != null)
            { 
                OnEat.Invoke();
            }
        }
    }
    /*
     public void FixedUpdate()
     {
         if (Mathf.Abs(sidewaysSpeed) > 4) sidewaysSpeed = 4 * Mathf.Sign(sidewaysSpeed);
         componentRigidBody.velocity = new Vector3(sidewaysSpeed * 5, Speed);

         sidewaysSpeed = 0;
    */
}
