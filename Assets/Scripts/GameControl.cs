using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    private int Days;
    public Transform OldLadyMissionPos;
    public Transform neighborMissionPos;
    public Image OrderDetail;

    public Transform MissionNaviPos;
    public GameObject TakeoutInStore;
    public Transform Bike;
    public Transform Player;

    public Vector3 BikePosition;
    public Quaternion BikeRotation;
    public Vector3 PlayerPosition;
    public Quaternion PlayerRotation;

    public GameObject MissionSpot;
    public GameObject MissionLight;
    public GameObject TakeoutDelivered;
    public GameObject Food;

    public Animator Dialo;
    public GameObject DialoCanvas;
    // Start is called before the first frame update
    void Start()
    {
        BikePosition = Bike.position;
        BikeRotation = Bike.rotation;
        PlayerPosition = Player.position;
        PlayerRotation = Player.rotation;
        Days = 1;
        InitializeNavigation(Days);
    }

    // Update is called once per frame
    void Update()
    {
        if(Days == 1)
        {

        }
        else if(Days == 2)
        {

        }
    }
    public void DayPass()
    {
        Days++;
        DialoCanvas.SetActive(true);
        Dialo.SetInteger("Begin", Days);
        Dialo.SetInteger("Days", Days-1);
        InitializeBikePlayer();
        InitializeTakeout(Days);
        InitializeNavigation(Days);
        MissionSpot.SetActive(false);
    }

    private void InitializeBikePlayer()
    {
        Player.GetComponent<CharacterController>().enabled = false;
        Bike.position = BikePosition;
        Bike.rotation = BikeRotation;
        Player.position = PlayerPosition;
        Player.rotation = PlayerRotation;
        Player.GetComponent<CharacterController>().enabled = true;
    }

    public void InteractWithDoor()
    {
        if (Days == 1 || Days == 2 || Days == 3 || Days == 4 || Days == 5)
        {
            DialoCanvas.SetActive(true);
            Dialo.SetInteger("Days", Days);
            Dialo.SetInteger("Begin", Days);
            InitializeMissionSpot(Days);
        }
    }
    private void InitializeMissionSpot(int a)
    {
        if (a == 1 || a == 3 || a == 4 )
        {
            MissionSpot.SetActive(true);
            MissionLight.SetActive(true);
            TakeoutDelivered.SetActive(false);
            MissionSpot.transform.position = OldLadyMissionPos.position;
        }
        if (a == 2)
        {
            MissionSpot.SetActive(false);
            MissionLight.SetActive(false);
            TakeoutDelivered.SetActive(false);
        }
        if(a == 5)
        {
            MissionSpot.SetActive(false);
            MissionLight.SetActive(false);
            TakeoutDelivered.SetActive(false);
            Food.SetActive(true);
        }
    }
    private void InitializeTakeout(int a)
    {
        TakeoutInStore.SetActive(true);
        if(a == 1)
        {
            
        }
    }
    private void InitializeNavigation(int a)
    {
        if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5)
        {
            MissionNaviPos.position = OldLadyMissionPos.position + (new Vector3(0, 50, 0));
        }
    }


}
