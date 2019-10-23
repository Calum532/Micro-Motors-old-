using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceController : MonoBehaviour
{
    bool raceStarted = false;
    GameObject[] AICars;

    // Start is called before the first frame update
    void Start()
    {
        AICars = GameObject.FindGameObjectsWithTag("AICar");
        foreach(GameObject car in AICars)
        {
            car.GetComponent<CarAIControl>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!raceStarted && Input.GetKey("space"))
        {
            foreach(GameObject car in AICars)
            {
                car.GetComponent<CarAIControl>().enabled = true;
            }
            raceStarted = true;
        }
    }
}
