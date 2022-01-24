using UnityEngine.UI;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;

    private void Start()
    {
        if (PlayerPrefs.HasKey("ImageControlum"))
        {
            if (PlayerPrefs.GetInt("ImageControlum") == 0)
            {

                but.image.sprite = OffSprite;
            }
            else
            {
                but.image.sprite = OnSprite;
            }
        }
    }
    public void ChangeImage()
    {
        if (but.image.sprite == OnSprite)
        {
            but.image.sprite = OffSprite;
            PlayerPrefs.SetInt("Voice", 0);
            PlayerPrefs.SetInt("ImageControlum", 0);
        }
            
        else
        {
            but.image.sprite = OnSprite;
            PlayerPrefs.SetInt("Voice", 1);
            PlayerPrefs.SetInt("ImageControlum", 1);
        }
    }
}