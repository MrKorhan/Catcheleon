using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class backTusu : MonoBehaviour
{
    public Text replayText;
    private void Start()
    {
        
        if (PlayerPrefs.HasKey("ScoreTutucu"))
        {
            replayText.text = "Score: " + PlayerPrefs.GetInt("ScoreTutucu").ToString();
        }
        else
        {
            replayText.text = "Score: ";
        }
        
       
    }
    
    public void Home()
    {
        SceneManager.LoadScene("Baslangic");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
