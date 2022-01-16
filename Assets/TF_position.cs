using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TF_position : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObjectToMove;
    public void MoveGameObject()
    {
        gameObjectToMove.transform.position = new Vector3(10, 10, 10);
    }
}
