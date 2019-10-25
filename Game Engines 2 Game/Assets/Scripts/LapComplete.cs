using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject BestMinuteDisplay;
    public GameObject BestSecondDisplay;
    public GameObject BestMilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if(RaceTimer.SecondCount <= 9)
        {
            BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer.SecondCount + ".";
        }
        else
        {
            BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.SecondCount + ".";
        }

        if (RaceTimer.MinuteCount <= 9)
        {
            BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer.MinuteCount + ".";
        }
        else
        {
            BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.MinuteCount + ".";
        }

        BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.MilliCount.ToString("F0");

        RaceTimer.MinuteCount = 0;
        RaceTimer.SecondCount = 0;
        RaceTimer.MilliCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
