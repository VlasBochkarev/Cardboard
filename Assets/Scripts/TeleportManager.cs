using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public GameObject portal;



    private void Start()
    {
        portal.GetComponent<Transform>();
    }

    public void TeleportToPortal()
    {
        float portalPosX = portal.transform.position.x;
        float portalPosZ = portal.transform.position.z;
        transform.position = new Vector3(portalPosX, 20f, portalPosZ);
    }
    public void OnPointerClick()
    {
        TeleportToPortal();
    }

 
}
