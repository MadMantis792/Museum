using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject imagePanel;

    public void OnInteraction()
    {
        textPanel.SetActive(true);
        imagePanel.SetActive(true);
        //Invoke(nameof(OffInteraction), 10);
    }
    //h�r har jag lagt till en till funktion som ska st�nga av texten
    public void OffInteraction()
    {
        textPanel.SetActive(false);
        imagePanel.SetActive(false);
    }
}