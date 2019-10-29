using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCash : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;
    
    void Start()
    {
        
    }

    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<TextMeshProUGUI>().text = "Money: $" + CashValue;
    }
}
