using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeControl : MonoBehaviour
{
    public GameObject FrontWheel;
    public GameObject Handlebar;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 20f;
        FrontWheel = GameObject.Find("FrontWheel");
        Handlebar = GameObject.Find("Handlebar.028");
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Transform>().Translate(new Vector3(0, 0, -Speed) *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Transform>().Translate(new Vector3(0, 0, Speed) * Time.deltaTime);
        }
        if ((Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.W)))
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * -1 * Time.deltaTime * 60); 

        }
        if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W) )
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * 1 * Time.deltaTime * 60);
        }
        if ( (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)))
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * 1 * Time.deltaTime * 60);

        }
        if ((Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)))
        {
            this.GetComponent<Transform>().Rotate(Vector3.up * -1 * Time.deltaTime * 60);
        }
    }
}
