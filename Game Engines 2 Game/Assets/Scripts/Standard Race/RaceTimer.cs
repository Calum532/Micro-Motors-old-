using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class RaceTimer : MonoBehaviour
{
    private float countdownTimer = 3;
    public static float cTimer;
    private bool raceTimer = false;

    public static bool finished;
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;
    public static float RawTime;
    public static float magnitudeSpeed;
    public static double mphSpeed;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public GameObject CountdownContainer;
    public GameObject SpeedUI;

    bool raceStarted = false;
    GameObject[] AICars;
    GameObject Player;

    private void Start()
    {
        CountdownContainer.SetActive(true);
        cTimer = countdownTimer;
        FindObjectOfType<AudioManager>().Play("Race1Music");
    }

    void Update()
    {
        //if player has chosen a vehicle
        if (ChooseRacer.RacerChosen)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            AICars = GameObject.FindGameObjectsWithTag("AICar");

            magnitudeSpeed = Player.GetComponent<Rigidbody>().velocity.magnitude;
            mphSpeed = magnitudeSpeed * 2.222;
            SpeedUI.GetComponent<TextMeshProUGUI>().text = mphSpeed.ToString("F0");

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
                RawTime += Time.deltaTime;
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
                }
                else
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
                }
                else
                {
                    MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
                }

                if (raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = true;

                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = true;
                    }
                }
                else
                {
                    Player.GetComponent<CarUserControl>().enabled = false;
                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = false;
                    }
                }
            }
        }
    }
}
