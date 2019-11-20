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

    public int playerLapsDone = 1;
    /*public int RCLapsDone = 1;
    public int UFOLapsDone = 1;
    public int TaxiLapsDone = 1;
    public int TruckLapsDone = 1;
    public int TankLapsDone = 1;
    public int DozerLapsDone = 1;
    public int MonsterLapsDone = 1;
    public int SkyCarLapsDone = 1;*/

    public float RawTime;
    public int firstPlaceWinnings = 500;
    public int secondPlaceWinnings = 300;
    public int thirdPlaceWinnings = 100;
    public GameObject winningsDisplay;

    GameObject Player;
    GameObject AIRC;
    GameObject AIUFO;
    GameObject AITaxi;
    GameObject AITank;
    GameObject AITruck;
    GameObject AIDozer;
    GameObject AIMonster;
    GameObject AISkyCar;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        /*AIRC = GameObject.FindGameObjectWithTag("AIRC");
        AIUFO = GameObject.FindGameObjectWithTag("AIUFO");
        AITaxi = GameObject.FindGameObjectWithTag("AITaxi");
        AITruck = GameObject.FindGameObjectWithTag("AITruck");
        AITank = GameObject.FindGameObjectWithTag("AITank");
        AIDozer = GameObject.FindGameObjectWithTag("AIDozer");
        AIMonster = GameObject.FindGameObjectWithTag("AIMonster");
        AISkyCar = GameObject.FindGameObjectWithTag("AISkyCar");*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerLapsDone += 1;
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (RaceTimer.RawTime <= RawTime)
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

            if (playerLapsDone >= 1) //race complete
            {
                PauseMenu.gameIsPaused = true;
                Player.GetComponent<CarUserControl>().enabled = false;
                Player.GetComponent<CarAIControl>().enabled = true;
                RaceCompleteUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);

                if(PlayerPos.playerPosition == 1)
                {
                    GlobalCash.TotalCredits += firstPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + firstPlaceWinnings;
                    PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 2)
                {
                    GlobalCash.TotalCredits += secondPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + secondPlaceWinnings;
                    PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 3)
                {
                    GlobalCash.TotalCredits += thirdPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + thirdPlaceWinnings;
                    PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCredits);
                }
                else
                {
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $0";
                }
            }

            PlayerPrefs.SetInt("BestMinSave", RaceTimer.MinuteCount);
            PlayerPrefs.SetInt("BestSecSave", RaceTimer.SecondCount);
            PlayerPrefs.SetFloat("BestMilliSave", RaceTimer.MilliCount);
            PlayerPrefs.SetFloat("RawTime", RaceTimer.RawTime);

            RaceTimer.MinuteCount = 0;
            RaceTimer.SecondCount = 0;
            RaceTimer.MilliCount = 0;
            RaceTimer.RawTime = 0;
            LapCounter.GetComponent<TextMeshProUGUI>().text = "" + playerLapsDone + "/3";
            //HalfLapTrig.SetActive(true);
            //LapCompleteTrig.SetActive(false);
        }
    }
}
