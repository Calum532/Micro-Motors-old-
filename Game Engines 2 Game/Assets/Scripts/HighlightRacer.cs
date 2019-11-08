using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
}
