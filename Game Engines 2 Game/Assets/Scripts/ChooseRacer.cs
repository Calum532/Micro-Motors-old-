using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRacer : MonoBehaviour
{
    public GameObject ChooseRacerUI;
    public GameObject GameUI;
    public GameObject FrontCam;
    public GameObject SkyCam;

    public GameObject PlayerRC;
    public GameObject PlayerUFO;
    public GameObject PlayerTaxi;
    public GameObject PlayerTank;
    public GameObject PlayerMonster;
    public GameObject PlayerTruck;
    public GameObject PlayerDozer;
    public GameObject PlayerSkyCar;

    public GameObject AIRC;
    public GameObject AIUFO;
    public GameObject AITaxi;
    public GameObject AITank;
    public GameObject AIMonster;
    public GameObject AITruck;
    public GameObject AIDozer;

    public GameObject SkyCarRC;
    public GameObject SkyCarUFO;
    public GameObject SkyCarTaxi;
    public GameObject SkyCarTank;
    public GameObject SkyCarMonster;
    public GameObject SkyCarTruck;
    public GameObject SkyCarDozer;

    public static bool RacerChosen = false;
    private int RandomNum;

    void Start()
    {
        PauseMenu.gameIsPaused = true;
    }

    public void PickRC()
    {
        PlayerRC.SetActive(true);
        AIRC.SetActive(false);
        SkyCarRC.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickTaxi()
    {
        PlayerTaxi.SetActive(true);
        AITaxi.SetActive(false);
        SkyCarTaxi.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickUFO()
    {
        PlayerUFO.SetActive(true);
        AIUFO.SetActive(false);
        SkyCarUFO.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickTank()
    {
        PlayerTank.SetActive(true);
        AITank.SetActive(false);
        SkyCarTank.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickDozer()
    {
        PlayerDozer.SetActive(true);
        AIDozer.SetActive(false);
        SkyCarDozer.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickTruck()
    {
        PlayerTruck.SetActive(true);
        AITruck.SetActive(false);
        SkyCarTruck.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickMonster()
    {
        PlayerMonster.SetActive(true);
        AIMonster.SetActive(false);
        SkyCarMonster.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickSkyCar()
    {
        PlayerSkyCar.SetActive(true);
        PauseMenu.gameIsPaused = false;
        FrontCam.SetActive(true);
        SkyCam.SetActive(false);
        RacerChosen = true;
        ChooseRacerUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void PickRandom()
    {
        RandomNum = UnityEngine.Random.Range(0, 7);

        if(RandomNum == 0)
        {
            PickRC();
        }
        else if(RandomNum == 1)
        {
            PickTaxi();
        }
        else if (RandomNum == 2)
        {
            PickUFO();
        }
        else if (RandomNum == 3)
        {
            PickTank();
        }
        else if (RandomNum == 4)
        {
            PickDozer();
        }
        else if (RandomNum == 5)
        {
            PickTruck();
        }
        else if (RandomNum == 6)
        {
            PickMonster();
        }
        else
        {
            PickSkyCar();
        }
    }
}
