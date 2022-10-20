using TMPro; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Temporizador : MonoBehaviour
{
    
    float currentTime;
    public float startingTime = 60f;
    public TMPro.TMP_Text textoPerdiste;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
        SetearTextos();
        textoPerdiste.text = "";
    }
    void Update()
    {
        currentTime = currentTime - 1 * Time.deltaTime; 
        countdownText.text = currentTime.ToString("0");
        SetearTextos();
         
            if (currentTime <= 0)
            {
                currentTime = 0;

                textoPerdiste.text = " GameOver ";
                Time.timeScale = 0;
            }
        
    }
    private void SetearTextos()
    {
        currentTime = currentTime - 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime<=0)
        {
            currentTime = 0;
           textoPerdiste.text = " GameOver ";
        }
    }
}
