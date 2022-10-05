using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public float XSize = 8f;
    public float ZSize = 250f;

    public GameObject foodPrefab;
    public Vector3 currentPosition;
    public GameObject currentFood;


    void AddNewFood()
    {

        FoodPosition();
        currentFood = GameObject.Instantiate(foodPrefab, currentPosition, Quaternion.identity) as GameObject;
    }

    void FoodPosition()
    {
        currentPosition = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
        
    }
   
    void Update()
    {
        if (!currentFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
        
    }        
}
