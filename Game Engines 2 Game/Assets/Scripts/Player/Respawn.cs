using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    GameObject obj;
    GameObject AI;
    public GameObject explosion;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
        AI = GameObject.FindGameObjectWithTag("AICar");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Respawn - Respawning Player");
            Instantiate(explosion, transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Explosion");
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
