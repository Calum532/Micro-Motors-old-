using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PosUp : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject DownPosTrigger;
    public GameObject UpPosTrigger;
    //public int playerPosition;

    private void Start()
    {
        DownPosTrigger.SetActive(false);
        UpPosTrigger.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "CarPos")
        {
            PlayerPos.playerPosition--;
            positionDisplay.GetComponent<TextMeshProUGUI>().text = PlayerPos.playerPosition.ToString();
            DownPosTrigger.SetActive(true);
            UpPosTrigger.SetActive(false);
        }
    }
}
