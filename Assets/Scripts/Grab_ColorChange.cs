using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grab_ColorChange : MonoBehaviour
{
    public Material GrayColor = null;
    public Material PinkColor = null;
    private MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabInteractable = null;

    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>();
        /*grabInteractable = gameObject.GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(SetColor(PinkColor));
        grabInteractable.onDeactivate.AddListener(SetColor(GrayColor));*/
    }
    public void SetColor(Material Color)
    {   
        meshRenderer.material = Color;
    }

    
}
