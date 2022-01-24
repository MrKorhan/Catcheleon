using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Startcontroller : MonoBehaviour
{
    
    public Text HighScoreText;
    private void Start()
    {
        
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            HighScoreText.text = "High Score: 0";
        }
    }
    public void OyunEkraniGecis()
    {
        if (!PlayerPrefs.HasKey("Intro") || PlayerPrefs.GetInt("Intro") == 0)
        {
            PlayerPrefs.SetInt("Intro", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene("ýNTRO");
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
