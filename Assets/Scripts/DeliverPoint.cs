using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPoint : MonoBehaviour
{
    public GameObject DP;
    public GameObject takeoutBox;
    public GameObject Gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DPDp()
    {
        DP.SetActive(false);
        takeoutBox.SetActive(true);
        Gamecontroller.GetComponent<GameControl>().DayPass();
    }
}
