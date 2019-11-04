using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class BoostPadScript : MonoBehaviour
{
    public static float magnitudeSpeed;
    public static float currentSpeed;
    public float boostDuration = 3f;
    public bool isActive = false;

    public GameObject boostEffect;

    GameObject Player;
    GameObject AICar;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //AICar = GameObject.FindGameObjectWithTag("AICar");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( PlayerBoost(other));
        }
        /*else if (other.CompareTag("AI Car"))
        {
            StartCoroutine( AIBoost(other));
        }*/
    }

    IEnumerator PlayerBoost(Collider racer)
    {
        magnitudeSpeed = racer.GetComponent<Rigidbody>().velocity.magnitude;
        magnitudeSpeed = 100;

        currentSpeed = racer.GetComponent<CarController>().CurrentSpeed;
        currentSpeed = 100;

        //Player.GetComponent<CarController>().m_Topspeed = Player.GetComponent<CarController>().m_Topspeed * 2;

        FindObjectOfType<AudioManager>().Play("Boost");
        //Instantiate(boostEffect, transform.position, transform.rotation);
        isActive = true;

        yield return new WaitForSeconds(boostDuration);

        isActive = false;
        //Player.GetComponent<CarController>().m_Topspeed = Player.GetComponent<CarController>().m_Topspeed / 2;
        magnitudeSpeed = magnitudeSpeed / 2;
        currentSpeed = currentSpeed / 2;
    }

    /*IEnumerator AIBoost(Collider racer)
    {
        magnitudeSpeed = AICar.GetComponent<Rigidbody>().velocity.magnitude;
        magnitudeSpeed = magnitudeSpeed * 2;

        currentSpeed = AICar.GetComponent<CarController>().CurrentSpeed;
        currentSpeed = currentSpeed * 2;

        //CarController.m_Topspeed = CarController.m_Topspeed * 2;

        //Instantiate(boostEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(boostDuration);

        //CarController.m_Topspeed = CarController.m_Topspeed / 2;
        magnitudeSpeed = magnitudeSpeed / 2;
        currentSpeed = currentSpeed / 2;
    }*/
}
