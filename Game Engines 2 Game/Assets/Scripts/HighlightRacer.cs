using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighlightRacer : MonoBehaviour
{
    public GameObject RC;
    public GameObject UFO;
    public GameObject Taxi;
    public GameObject Truck;
    public GameObject Tank;
    public GameObject Monster;
    public GameObject Dozer;
    public GameObject SkyCar;
    public GameObject Random;
    public GameObject RacerNameUI;

    public void mouseOverRC()
    {
        RC.SetActive(true);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "R.C.";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 0, 255, 255);
    }

    public void mouseOverUFO()
    {
        RC.SetActive(false);
        UFO.SetActive(true);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "UFO";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(125, 125, 125, 255);
    }

    public void mouseOverTaxi()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(true);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Taxi";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 0, 255);
    }

    public void mouseOverTruck()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(true);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Truck";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 0, 0, 255);
    }

    public void mouseOverTank()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(true);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Tank";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 150, 0, 255);
    }

    public void mouseOverMonster()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(true);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Monster";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(125, 0, 255, 255);
    }

    public void mouseOverDozer()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(true);
        SkyCar.SetActive(false);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Dozer";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 125, 0, 255);
    }

    public void mouseOverSkyCar()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(true);
        Random.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Sky Car";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 255, 255);
    }

    public void mouseOverRandom()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "?????????";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
    }
}
