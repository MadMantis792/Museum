using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    public GameObject textPanel;

    public void OnInteraction()
    {
        textPanel.SetActive(true);
    }
}