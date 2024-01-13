using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private Rigidbody playerRb;
    public float Force = 2;
    private GameObject focal;
    void Start()   {
        playerRb = GetComponent<Rigidbody>();
        focal = GameObject.Find("FocalPoint");
    }

    void Update()    {
        float Vimp = Input.GetAxis("Vertical");
        playerRb.AddForce(focal.transform.forward * Force * Vimp);

    }
}
