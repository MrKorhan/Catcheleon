using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject panel;
    public GameObject startButton;
    GameObject sinekler;
    public Text timeText;
    float timeLeft = 60.1f;
    int tmlft;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "60";
        panel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        tmlft = (int)timeLeft;
        
        if (timeLeft < 0)
        {
            sinekler = GameObject.FindWithTag("Dusman");
            Destroy(sinekler);
            panel.SetActive(true);
            timeText.text = "0";
        }
        else
        {
            timeText.text = tmlft.ToString();
        }

    }
    
    public void SahneyiTekrarYukle()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
}
