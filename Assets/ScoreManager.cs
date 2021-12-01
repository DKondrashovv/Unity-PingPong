using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    private int score1;
    public Text textDisplay1;
    private int score2;
    public Text textDisplay2;
    private void Start()
    {
       
    }
    
    void Update()
    {
        textDisplay1.text = "Счёт левого чела: " + score1.ToString();
        textDisplay2.text = "Счёт правого чела: " + score2.ToString();
    }
   public void Plus()
    {
        score1++;
        if(score1==5)
        {
            SceneManager.LoadScene("GameOver");
        }    
    }
    public void Plus2()
    {
        score2++;
        if(score2==5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
