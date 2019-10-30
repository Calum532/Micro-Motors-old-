using System;
using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject powerUp;

    public float respawnDuration = 5f;
    public float effectDuration = 10f;

    private int RandomNum;

    public float grow = 2f;
    public float shrink = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            FindObjectOfType<AudioManager>().Play("PickUp");
            StartCoroutine(respawnCountdown());

            RandomNum = UnityEngine.Random.Range(0, 1);
            if (RandomNum == 0)
            {
                StartCoroutine( PickupGrow(other));
            }
            else if (RandomNum == 1)
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

        yield return new WaitForSeconds(respawnDuration);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
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
