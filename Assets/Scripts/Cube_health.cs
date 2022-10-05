using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class Cube_health : MonoBehaviour
{
    public int _hpBlock;
    public Shader HP;
    public UnityEngine.Object explosion;
    public TextMeshPro hpCount;
    public GameObject[] CubePrefab;
    public Material fullHp;
    public Material midHp;
    public Material lowHp;
    public TailMovement mainSnake;
    public Control Player;
   


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Control>();
        

        _hpBlock = Random.Range(1, 30);

        explosion = Resources.Load("Explosion");
      
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
    public void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
     
        Player.Speed = 0;
        Player.turnSpeed = 3;

        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _hpBlock--;
        other.GetComponent<Control>().LessTail();
        
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.Speed = 5;
            Player.turnSpeed = 5;
            
        }
    }
    void KillBlock()
    {
        Destroy(gameObject);
        Player.Speed = 5;
        Player.turnSpeed = 5;
    }
   
    public void Update()
    {
        hpCount.text = _hpBlock.ToString();

      
        if (_hpBlock <= 30)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (_hpBlock <= 20)
        {
            GetComponent<Renderer>().material.color = Color.yellow;

        }

        if (_hpBlock <= 10)
        {
            GetComponent<Renderer>().material.color = Color.red;

        }

        if (_hpBlock == 0)
        {
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            KillBlock();
        }
       
    }
}
    

