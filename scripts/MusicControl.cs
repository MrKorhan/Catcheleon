using UnityEngine.UI;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;

    public AudioSource musicKontrol;

    private void Start()
    {
        
        if (PlayerPrefs.HasKey("ImageControl"))
        {
            if (PlayerPrefs.GetInt("ImageControl") == 0)
            {

                but.image.sprite = OffSprite;
                musicKontrol.Stop();
            }
            else
            {
                but.image.sprite = OnSprite;
                musicKontrol.Play();
            }
        }
        
        
    }
    public void ChangeImage()
    {
        if (but.image.sprite == OnSprite)
        {
            but.image.sprite = OffSprite;
            PlayerPrefs.SetInt("Music", 0);
            PlayerPrefs.SetInt("ImageControl", 0);
        }
           
        else
        {
            but.image.sprite = OnSprite;
            PlayerPrefs.SetInt("Music", 1);
            PlayerPrefs.SetInt("ImageControl", 1);
        }
        PlayerPrefs.Save();
    }

    

   
}
