using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject powerUp;

    public float respawnTimer = 5f;
    public float effectTimer = 5f;

    private int RandomNum;

    public float grow = 1.5f;
    public float shrink = 0.5f;
    public float normal = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        FindObjectOfType<AudioManager>().Play("PickUp");
        powerUp.SetActive(false);
        respawnCountdown();

        if (other.CompareTag("Player"))
        {
            RandomNum = UnityEngine.Random.Range(0, 0);
            if (RandomNum == 0)
            {
                PickupGrow(other);
            }
            else if (RandomNum == 1)
            {
                PickupShrink(other);
            }
            else if (RandomNum == 2)
            {
                PickupBoost(other);
            }
            else if (RandomNum == 3)
            {
                PickupBlur(other);
            }
            else if (RandomNum == 4)
            {
                Pickup(other);
            }
            else if (RandomNum == 5)
            {
                Pickup(other);
            }
            else
            {
                Pickup(other);
            }
        }
    }

    void respawnCountdown()
    {
        respawnTimer -= Time.deltaTime;

        if (respawnTimer <= 0f)
        {
            powerUp.SetActive(true);
            respawnTimer = 5f;
        }
    }

    void PickupGrow(Collider racer)
    {
        racer.transform.localScale *= grow;
        effectTimer -= Time.deltaTime;

        if (effectTimer <= 0f)
        {
            racer.transform.localScale *= shrink;
            effectTimer = 5f;
        }
    }

    void PickupShrink(Collider racer)
    {
        racer.transform.localScale *= shrink;
    }

    void PickupBoost(Collider racer)
    {

    }

    void PickupBlur(Collider racer)
    {

    }

    void Pickup(Collider racer)
    {

    }
}
