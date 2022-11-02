using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public GameObject DialoCanvasS;
    public GameObject GameController;
    public AudioClip Phoneclip;
    public GameObject Ablum;
    public GameObject Neighbor;
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
        Invoke("Delay",2f);
    }

    void Phone()
    {
        SounController.Instance.PlaySound(Phoneclip);
    }

    private void Delay(){
        GameController.transform.GetComponent<GameControl>().DayPass();
    }

    void Day20()
    {
        Ablum.SetActive(true);
        Neighbor.SetActive(true);
    }
}
