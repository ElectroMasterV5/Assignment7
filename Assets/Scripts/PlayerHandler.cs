using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    private Ray ray;
    public Image aim;
    private bool bikeMode;

    public GameObject BikeControl;
    public GameObject SitPos;
    public GameObject DeliverInfo;

    public GameObject iphoneUI;
    public GameObject iphoneCam;

    public GameObject GameControl;
    // Start is called before the first frame update
    void Start()
    {
        bikeMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        BikeModeOn();
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (iphoneUI.activeInHierarchy)
            {
                iphoneUI.SetActive(false);
            }
            else
            {
                iphoneUI.SetActive(true);
            }
            if (iphoneCam.activeInHierarchy)
            {
                iphoneCam.SetActive(false);
            }
            else
            {
                iphoneCam.SetActive(true);
            }
           
        }
        if(DeliverInfo.activeInHierarchy)
        {
            if (Input.GetMouseButton(1))
            {
                DeliverInfo.SetActive(false);
            }
        }
        if (Input.GetMouseButton(1))
        {
            bikeMode = false;
            this.transform.GetComponent<CharacterController>().enabled = true;
        }
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 2f)&&!bikeMode)
            {
                
                    if (raycastHit.transform.CompareTag("Bike"))
                    {
               
                        ChangeColorGrey();
                        if (Input.GetMouseButton(0))
                        {
                         bikeMode = true;
                    this.transform.GetComponent<CharacterController>().enabled = false;
                    this.transform.rotation = SitPos.transform.rotation;
                    //raycastHit.transform.GetComponent<SecDoorHandler>().DoorOpen();
                }
                       
                    }
                    else if (raycastHit.transform.CompareTag("Takeout"))
                    {
                        ChangeColorGrey();
                        if (Input.GetMouseButton(0))
                        {
                           raycastHit.transform.GetComponent<TakeoutInfo>().Disp();
                           DeliverInfo.SetActive(true);
                        }
               
                    }
                    else if (raycastHit.transform.CompareTag("Door"))
                    {
                        ChangeColorGrey();
                         if (Input.GetMouseButtonUp(0))
                         {
                    GameControl.GetComponent<GameControl>().InteractWithDoor();
                         }

                    }
            else if (raycastHit.transform.CompareTag("Deliver"))
            {
                ChangeColorGrey();
                if (Input.GetMouseButtonUp(0))
                {
                    raycastHit.transform.GetComponent<DeliverPoint>().DPDp();
                }

            }

            else
                    {
                        ChangeColorWhite();
                    }
                
            }
            else
            {
            ChangeColorWhite();
            }

    }
    private void ChangeColorGrey()
    {
        aim.color = Color.grey;
    }
    private void ChangeColorWhite()
    {
        aim.color = Color.white;
    }
    private void BikeModeOn()
    {
        if (bikeMode)
        {
            this.transform.position = SitPos.transform.position;
            BikeControl.GetComponent<BikeControl>().enabled = true;
        }
        if (!bikeMode)
        {
            BikeControl.GetComponent<BikeControl>().enabled = false;
        }
    }
}
