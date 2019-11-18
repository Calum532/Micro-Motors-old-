using System;
using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject powerUp;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;

    public float respawnDuration = 5f;
    public float effectDuration = 10f;

    private int randomNum;

    public float grow = 2f;
    public float shrink = 0.5f;

    public float rotateSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            FindObjectOfType<AudioManager>().Play("PickUp");
            StartCoroutine(respawnCountdown());

            randomNum = UnityEngine.Random.Range(0, 1);
            if (randomNum == 0)
            {
                StartCoroutine( PickupGrow(other));
            }
            else if (randomNum == 1)
            {
                StartCoroutine( PickupShrink(other));
            }
            /*else if (RandomNum == 2)
            {
                StartCoroutine( PickupBoost(other));
            }
            else if (RandomNum == 3)
            {
                StartCoroutine( PickupBlur(other));
            }
            else if (RandomNum == 4)
            {
                StartCoroutine( Pickup(other));
            }
            else if (RandomNum == 5)
            {
                StartCoroutine( Pickup(other));
            }
            else
            {
                StartCoroutine( Pickup(other));
            }*/
        }
    }

    IEnumerator respawnCountdown()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        child1.GetComponent<MeshRenderer>().enabled = false;
        child2.GetComponent<MeshRenderer>().enabled = false;
        child3.GetComponent<MeshRenderer>().enabled = false;
        child4.GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(respawnDuration);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
        child1.GetComponent<MeshRenderer>().enabled = true;
        child2.GetComponent<MeshRenderer>().enabled = true;
        child3.GetComponent<MeshRenderer>().enabled = true;
        child4.GetComponent<MeshRenderer>().enabled = true;
    }

    IEnumerator PickupGrow(Collider racer)
    {
        FindObjectOfType<AudioManager>().Play("Buff");

        racer.transform.localScale *= grow;
        yield return new WaitForSeconds(effectDuration);
        racer.transform.localScale /= grow;
    }

    IEnumerator PickupShrink(Collider racer)
    {
        FindObjectOfType<AudioManager>().Play("Debuff");

        racer.transform.localScale *= shrink;
        yield return new WaitForSeconds(effectDuration);
        racer.transform.localScale /= shrink;
    }

    /*IEnumerator PickupBoost(Collider racer)
    {

    }

    IEnumerator PickupBlur(Collider racer)
    {

    }

    IEnumerator Pickup(Collider racer)
    {

    }*/
}
