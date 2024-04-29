using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public void OnRetryButtonClicked()
    {
        Debug.Log("Retry button clicked. Loading scene: SampleScene");
        SceneManager.LoadScene("SampleScene");
    }
}
