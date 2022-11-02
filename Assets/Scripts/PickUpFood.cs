using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFood : MonoBehaviour
{
    public GameObject Food;
    public GameObject Gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BePicked()
    {
        Invoke("Passday",2f);
        Food.SetActive(false);
    }
    private void Passday()
    {
        Gamecontroller.GetComponent<GameControl>().DayPass();
    }
}
