using UnityEngine;

public class AudioKontrolEt : MonoBehaviour
{
    public AudioSource Audio;
    int music;
    
    private void Start()
    {
        
        
        if (music == 1)
        {
            Audio.Play();
        }
        else
        {
            Audio.Stop();
        }


    }
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Music"))
        {
            music = 1;
        }
        else
        {
            music = PlayerPrefs.GetInt("Music");
        }
    }
    public void openSound()
    {
         music = PlayerPrefs.GetInt("Music");
        if (music == 0)
        {
            Audio.Stop();
        }
        else
        {
            Audio.Play();
        }
    }
}
