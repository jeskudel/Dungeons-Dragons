using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject, 2);
        Debug.Log("COLISION!");
    }
}
