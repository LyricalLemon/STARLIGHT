using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecretButton : MonoBehaviour
{
    public Button secretButton; 
    public int clickCount = 0;
    public int requiredClicks = 7;
    // Start is called before the first frame update
    public void Awake() 
    {
        secretButton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        clickCount++;

        if (clickCount >= requiredClicks)
        {
            ActivateEasterEgg();
        }
    }
    public void ActivateEasterEgg()
    {
        SceneManager.LoadScene("SecretButton...");
        Debug.Log("Easter Egg activated!");
    }
}
