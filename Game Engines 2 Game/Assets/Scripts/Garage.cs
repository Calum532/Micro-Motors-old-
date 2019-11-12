﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Garage : MonoBehaviour
{
    public GameObject RC;
    public GameObject UFO;
    public GameObject Taxi;
    public GameObject Truck;
    public GameObject Tank;
    public GameObject Monster;
    public GameObject Dozer;
    public GameObject SkyCar;

    public GameObject RCBorder;
    public GameObject UFOBorder;
    public GameObject TaxiBorder;
    public GameObject TruckBorder;
    public GameObject TankBorder;
    public GameObject MonsterBorder;
    public GameObject DozerBorder;
    public GameObject SkyCarBorder;

    public GameObject RacerNameUI;
    public GameObject RacerPrice;

    public Slider TopSpeedSlider;
    public Slider AccelerationSlider;
    public Slider GripSlider;
    public Slider HandlingSlider;
    public Slider WeightSlider;

    public Image TopSpeedFill;
    public Image AccelerationFill;
    public Image GripFill;
    public Image HandlingFill;
    public Image WeightFill;

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

        RCBorder.SetActive(true);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 1;
        AccelerationSlider.value = 1;
        GripSlider.value = 1;
        HandlingSlider.value = 1;
        WeightSlider.value = 1;

        TopSpeedFill.color = new Color32(0, 0, 255, 255);
        AccelerationFill.color = new Color32(0, 0, 255, 255);
        GripFill.color = new Color32(0, 0, 255, 255);
        HandlingFill.color = new Color32(0, 0, 255, 255);
        WeightFill.color = new Color32(0, 0, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $"+100;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(true);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 2;
        AccelerationSlider.value = 2;
        GripSlider.value = 2;
        HandlingSlider.value = 2;
        WeightSlider.value = 2;

        TopSpeedFill.color = new Color32(169, 169, 169, 255);
        AccelerationFill.color = new Color32(169, 169, 169, 255);
        GripFill.color = new Color32(169, 169, 169, 255);
        HandlingFill.color = new Color32(169, 169, 169, 255);
        WeightFill.color = new Color32(169, 169, 169, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 200;
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "UFO";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(169, 169, 169, 255);
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(true);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 3;
        AccelerationSlider.value = 3;
        GripSlider.value = 3;
        HandlingSlider.value = 3;
        WeightSlider.value = 3;

        TopSpeedFill.color = new Color32(255, 255, 0, 255);
        AccelerationFill.color = new Color32(255, 255, 0, 255);
        GripFill.color = new Color32(255, 255, 0, 255);
        HandlingFill.color = new Color32(255, 255, 0, 255);
        WeightFill.color = new Color32(255, 255, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 300;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(true);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 4;
        AccelerationSlider.value = 4;
        GripSlider.value = 4;
        HandlingSlider.value = 4;
        WeightSlider.value = 4;

        TopSpeedFill.color = new Color32(255, 0, 0, 255);
        AccelerationFill.color = new Color32(255, 0, 0, 255);
        GripFill.color = new Color32(255, 0, 0, 255);
        HandlingFill.color = new Color32(255, 0, 0, 255);
        WeightFill.color = new Color32(255, 0, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 400;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(true);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 5;
        AccelerationSlider.value = 5;
        GripSlider.value = 5;
        HandlingSlider.value = 5;
        WeightSlider.value = 5;

        TopSpeedFill.color = new Color32(0, 150, 0, 255);
        AccelerationFill.color = new Color32(0, 150, 0, 255);
        GripFill.color = new Color32(0, 150, 0, 255);
        HandlingFill.color = new Color32(0, 150, 0, 255);
        WeightFill.color = new Color32(0, 150, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 500;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(true);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 6;
        AccelerationSlider.value = 6;
        GripSlider.value = 6;
        HandlingSlider.value = 6;
        WeightSlider.value = 6;

        TopSpeedFill.color = new Color32(125, 0, 255, 255);
        AccelerationFill.color = new Color32(125, 0, 255, 255);
        GripFill.color = new Color32(125, 0, 255, 255);
        HandlingFill.color = new Color32(125, 0, 255, 255);
        WeightFill.color = new Color32(125, 0, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 600;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(true);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 7;
        AccelerationSlider.value = 7;
        GripSlider.value = 7;
        HandlingSlider.value = 7;
        WeightSlider.value = 7;

        TopSpeedFill.color = new Color32(255, 125, 0, 255);
        AccelerationFill.color = new Color32(255, 125, 0, 255);
        GripFill.color = new Color32(255, 125, 0, 255);
        HandlingFill.color = new Color32(255, 125, 0, 255);
        WeightFill.color = new Color32(255, 125, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + 700;
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

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(true);

        TopSpeedSlider.value = 8;
        AccelerationSlider.value = 8;
        GripSlider.value = 8;
        HandlingSlider.value = 8;
        WeightSlider.value = 8;

        TopSpeedFill.color = new Color32(0, 255, 255, 255);
        AccelerationFill.color = new Color32(0, 255, 255, 255);
        GripFill.color = new Color32(0, 255, 255, 255);
        HandlingFill.color = new Color32(0, 255, 255, 255);
        WeightFill.color = new Color32(0, 255, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Sky Car";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 255, 255);
    }
}
