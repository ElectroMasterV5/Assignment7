using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public GameObject DialoCanvasS;
    public GameObject GameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShutSelf()
    {
        
        DialoCanvasS.SetActive(false);
       
    }
    void PassDay()
    {
        DialoCanvasS.SetActive(false);
        GameController.transform.GetComponent<GameControl>().DayPass();
    }
}
