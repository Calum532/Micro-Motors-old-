using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PosDown : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject UpPosTrigger;
    public GameObject DownPosTrigger;
    //public int playerPosition;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            PlayerPos.playerPosition++;
            positionDisplay.GetComponent<TextMeshProUGUI>().text = PlayerPos.playerPosition.ToString();
            DownPosTrigger.SetActive(false);
            UpPosTrigger.SetActive(true);
            //PlayerPos.positionDisplay.GetComponent<TextMeshProUGUI>().text = "2";
        }
    }
}
