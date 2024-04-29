using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject panel;
    public GameObject playAgain;
    public GameObject button;
    public GameObject score;

    private void Update()
    {
        if (panel.activeSelf)
        {
            StartCoroutine(WaitText());
        }
    }

    IEnumerator WaitText()
    {
        yield return new WaitForSeconds(2f);
        playAgain.SetActive(true);
        StartCoroutine(WaitButton());
    }

    IEnumerator WaitButton()
    {
        yield return new WaitForSeconds(0.5f);
        button.SetActive(true);
    }
}
