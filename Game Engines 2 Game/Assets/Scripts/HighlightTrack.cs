using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighlightTrack : MonoBehaviour
{
    public GameObject Track1Border;
    public GameObject Track2Border;
    public GameObject Track3Border;
    public GameObject RandomTrackBorder;

    public GameObject TrackName;
    public GameObject TrackDescription;
    public GameObject TrackImage;

    public void MouseOverTrack1()
    {
        Track1Border.SetActive(true);
        Track2Border.SetActive(false);
        Track3Border.SetActive(false);
        RandomTrackBorder.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Track 1";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(0, 0, 255, 255);
        TrackDescription.GetComponent<TextMeshProUGUI>().text = "This is a short description of what to expect in Track 1";
    }

    public void MouseOverTrack2()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(true);
        Track3Border.SetActive(false);
        RandomTrackBorder.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Track 2";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 0, 255);
        TrackDescription.GetComponent<TextMeshProUGUI>().text = "This is a short description of what to expect in Track 2";
    }

    public void MouseOverTrack3()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(false);
        Track3Border.SetActive(true);
        RandomTrackBorder.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Track 3";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 0, 0, 255);
        TrackDescription.GetComponent<TextMeshProUGUI>().text = "This is a short description of what to expect in Track 3";
    }

    public void MouseOverRandomTrack()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(false);
        Track3Border.SetActive(false);
        RandomTrackBorder.SetActive(true);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Random Track";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
        TrackDescription.GetComponent<TextMeshProUGUI>().text = "This is a short description explaining the player is about to select a random track from the 3 above";
    }
}
