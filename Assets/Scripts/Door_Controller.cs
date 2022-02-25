using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject Door;
    Animator DoorAnimator;

    void Start()
    {
        DoorAnimator = Door.GetComponent<Animator>(); 
    }
    public void DoorOpenClose(string condicion)
    {
        if(condicion == "abrir")
        {
            DoorAnimator.SetBool("Open", true);
            DoorAnimator.SetBool("Open", false);
        }
        else if (condicion == "cerrar")
        {
            DoorAnimator.SetBool("Open", false);
            DoorAnimator.SetBool("Open", true);
        }
    }
  
    void Update()
    {
        
    }
}
