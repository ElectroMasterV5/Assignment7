using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCall : MonoBehaviour
{
    public Animator Dialo;
    public GameObject DialoCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LastCallStart()
    {
        DialoCanvas.SetActive(true);
        Dialo.SetBool("Lastcall", true);

    }

}
