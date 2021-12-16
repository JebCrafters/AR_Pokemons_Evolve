using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance1 : MonoBehaviour
{
  public GameObject object1;
  public GameObject object2;

  void Update()
  {
    float dist = Vector3.Distance(object1.transform.position, object2.transform.position);
    Debug.Log(dist);
  }
}
