using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;

    private GameObject currenScreen;

    private void Start()
    {
        firstScreen.SetActive(true);
        currenScreen = firstScreen;
    }

    public void SwitchToSecondScreen()
    {
        firstScreen.SetActive(false);
        secondScreen.SetActive(true);
    }

    public void SwitchToFirstScreen()
    {
        secondScreen.SetActive(false);
        firstScreen.SetActive(true);
    }
}