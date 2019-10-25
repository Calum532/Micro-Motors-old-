using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class RaceTimer : MonoBehaviour
{
    private float countdownTimer = 3;
    public static float cTimer;
    private bool raceTimer = false;

    public static float finishTime;
    private bool finished;
    public GameObject raceResultsUI;

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    bool raceStarted = false;
    GameObject[] AICars;

    private void Start()
    {
        cTimer = countdownTimer;

        AICars = GameObject.FindGameObjectsWithTag("AICar");
        foreach (GameObject car in AICars)
        {
            car.GetComponent<CarAIControl>().enabled = false;
        }
    }

    void Update()
    {
        //start 3 second race countdown
        if (raceTimer == false)
        {
            PauseMenu.gameIsPaused = true;
            cTimer -= Time.deltaTime;
        }

        //Race starts
        if (cTimer <= 0f)
        {
            PauseMenu.gameIsPaused = false;
            raceTimer = true;

            raceStarted = true;
        }

        //Start lap timer
        if (finished == false & raceTimer == true)
        {
            MilliCount += Time.deltaTime * 10;
            MilliDisplay = MilliCount.ToString("F0");
            MilliBox.GetComponent<TextMeshProUGUI>().text = "" + MilliDisplay;

            if (MilliCount >= 9)
            {
                MilliCount = 0;
                SecondCount += 1;
            }

            if (SecondCount <= 9)
            {
                SecondBox.GetComponent<TextMeshProUGUI>().text = "0" + SecondCount + ".";
            } else
            {
                SecondBox.GetComponent<TextMeshProUGUI>().text = "" + SecondCount + ".";
            }

            if (SecondCount >= 60)
            {
                SecondCount = 0;
                MinuteCount += 1;
            }

            if (MinuteCount <= 9)
            {
                MinuteBox.GetComponent<TextMeshProUGUI>().text = "0" + MinuteCount + ":";
            } else
            {
                MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
            }

            if (raceStarted)
            {
                foreach (GameObject car in AICars)
                {
                    car.GetComponent<CarAIControl>().enabled = true;
                }
            }
        }

        //if player finishes race
        /* if (Player finishes race)
        {
            finishTime = t;
            finished = true;
            timerText.color = Color.red;
            raceResultsUI.SetActive(true);
            PauseMenu.gameIsPaused = true;
        } */
    }
}
