using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject raceTypeUI;
    public GameObject raceTrackUI;
    public GameObject chooseRacerUI;
    public GameObject settingsUI;

    public void RaceTypeSelect()
    {
        raceTypeUI.SetActive(true);
        menuUI.SetActive(false);
    }

    public void RaceTrackSelect()
    {
        raceTypeUI.SetActive(false);
        raceTrackUI.SetActive(true);
    }

    public void RacerSelect()
    {
        menuUI.SetActive(false);
        raceTypeUI.SetActive(false);
        raceTrackUI.SetActive(false);
        chooseRacerUI.SetActive(true);
    }

    public void DisplaySettings()
    {
        settingsUI.SetActive(true);
        menuUI.SetActive(false);
    }

    public void Back()
    {
        menuUI.SetActive(true);
        raceTypeUI.SetActive(false);
        settingsUI.SetActive(false);
        raceTrackUI.SetActive(false);
        chooseRacerUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
