/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{

  public Transform SnakeHead;
  public float SphereRadius;

  private List<Transform> snakeSphere = new List<Transform>();
  private List<Vector3> positions = new List<Vector3>();


  private void Awake()
  {
      positions.Add(SnakeHead.position);
      AddSphere();
      AddSphere();
      AddSphere();
  }

  void Update()
  {
      float distance = (SnakeHead.position - positions[0]).magnitude;

      if (distance > SphereRadius)
      {

          Vector3 direction = (SnakeHead.position - positions[0]).normalized;

          positions.Insert(0, positions[0] + direction * SphereRadius);
          positions.RemoveAt(positions.Count - 1);

          distance -= SphereRadius;
      }

      for (int i = 0; i < snakeSphere.Count; i++)
      {
          snakeSphere[i].position = Vector3.Lerp(positions[i+1], positions[i], distance/SphereRadius);
      }
  }

  public void AddSphere()
  {     
      Transform sphere = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
      snakeSphere.Add(sphere);
      positions.Add(sphere.position);
  }

  public void RemoveSphere()
  {
      Destroy(snakeSphere[0].gameObject);
      snakeSphere.RemoveAt(0);
      positions.RemoveAt(1);
  }
}
*/