using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

    CubeScript cubeData;

    void OnCollisionEnter (Collision col){
        Debug.Log ("Hubo colisión");
        cubeData = col.gameObject.GetComponent<CubeScript>();
        Debug.Log ("Nombre del otro objeto: " + cubeData.objectName);
    }
}
