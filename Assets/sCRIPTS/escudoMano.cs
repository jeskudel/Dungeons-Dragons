using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class escudoMano : MonoBehaviour
{
    XRGrabInteractable selfobject;
    ActionBasedController mandoI, mandoD;
    Transform agarreCambiado;

    // Start is called before the first frame update
    void Start()
    {
        selfobject = GetComponent<XRGrabInteractable>();
        mandoI = GameObject.Find("LeftHand Controller").GetComponent<ActionBasedController>();
        mandoD = GameObject.Find("RightHand Controller").GetComponent<ActionBasedController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comprobarMano()
    {
        if (selfobject.IsSelected(mandoD.GetComponent<XRDirectInteractor>()))
        {
            Debug.Log("entra den la funcion");
            GameObject.Find("agarreEscudoDefault").transform.Rotate(0,0,180);
                //.rotation = Quaternion.AngleAxis(180, Vector3.forward);
        }
    }
}
