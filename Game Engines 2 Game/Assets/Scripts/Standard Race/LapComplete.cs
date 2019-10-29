using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete : MonoBehaviour
{
    public GameObject RaceCompleteUI;
    public GameObject GameUI;
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject BestMinuteDisplay;
    public GameObject BestSecondDisplay;
    public GameObject BestMilliDisplay;
    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public GameObject RaceCompleteCam;
    public GameObject FrontCam;

    public int LapsDone = 1;
    public float RawTime;

    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter()
    {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if(RaceTimer.RawTime <= RawTime)
        {
            if (RaceTimer.MinuteCount <= 9)
            {
                BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer.MinuteCount + ":";
            }
            else
            {
                BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.MinuteCount + ":";
            }

            if (RaceTimer.SecondCount <= 9)
            {
                BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer.SecondCount + ".";
            }
            else
            {
                BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.SecondCount + ".";
            }

            BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer.MilliCount.ToString("F0");
        }

        if(LapsDone >= 1) //if race complete
        {
            PauseMenu.gameIsPaused = true;
            Player.GetComponent<CarUserControl>().enabled = false;
            Player.GetComponent<CarAIControl>().enabled = true;
            RaceCompleteUI.SetActive(true);
            GameUI.SetActive(false);
            RaceTimer.finished = true;
            RaceCompleteCam.SetActive(true);
            FrontCam.SetActive(false);
        }

        PlayerPrefs.SetInt("BestMinSave", RaceTimer.MinuteCount);
        PlayerPrefs.SetInt("BestSecSave", RaceTimer.SecondCount);
        PlayerPrefs.SetFloat("BestMilliSave", RaceTimer.MilliCount);
        PlayerPrefs.SetFloat("RawTime", RaceTimer.RawTime);

        RaceTimer.MinuteCount = 0;
        RaceTimer.SecondCount = 0;
        RaceTimer.MilliCount = 0;
        RaceTimer.RawTime = 0;
        LapCounter.GetComponent<TextMeshProUGUI>().text= "" + LapsDone + "/3";
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
