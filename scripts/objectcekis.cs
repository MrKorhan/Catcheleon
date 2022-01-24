using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class objectcekis : MonoBehaviour
{
    int baslangicpuan =0;

    int voice;
    public AudioSource Audio;

    public Text puan;
    public GameObject[] objectToInstatiate;
    public GameObject[] olusacaknoktam;
    int siranumarasi = 0;
    int siranumarasi2 = 0;

    public GameObject[] kalplerim;

    int kalpkontrol;

    

    
    private void Start()
    {

        puan.text = baslangicpuan.ToString();

        kalpkontrol = 0;

        

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("fly"))
        {

            EatingFlySound();

            InstantiateObject();
            other.gameObject.SetActive(false);

            

            baslangicpuan += 10;
            puan.text = baslangicpuan.ToString();

        }
        else if (other.gameObject.CompareTag("KirmiziSinek"))
        {
            EatingFlySound();

            InstantiateObject();
            other.gameObject.SetActive(false);

            

            kalplerim[kalpkontrol].GetComponent<Animator>().enabled = true;
            kalpkontrol++;
            if (kalpkontrol >= 3)
            {
                if (PlayerPrefs.HasKey("HighScore") && PlayerPrefs.GetInt("HighScore") < baslangicpuan)
                {
                    
                        PlayerPrefs.SetInt("HighScore", baslangicpuan);
                        PlayerPrefs.Save();                   
                }
                else if(!PlayerPrefs.HasKey("HighScore"))
                {
                    PlayerPrefs.SetInt("HighScore", baslangicpuan);
                    PlayerPrefs.Save();
                }
                PlayerPrefs.SetInt("ScoreTutucu", baslangicpuan);

                
                ReplaySahneGecis();
            }
            
        }
    }

    public void EatingFlySound()
    {
        if (PlayerPrefs.GetInt("Voice") == 1)
        {
            Audio.Play();
        }
        else if (!PlayerPrefs.HasKey("Voice"))
        {
            Audio.Play();
        }

    }

    public void ReplaySahneGecis()
    {
        SceneManager.LoadScene("ReplayGame");
    }


    private void InstantiateObject()
    {


        if (siranumarasi <= 10)
        {
            for (int i = 0; i < 10; i++)
            {
                if (siranumarasi<10)
                {
                    if (objectToInstatiate[siranumarasi].activeSelf)
                    {
                        siranumarasi++;
                        continue;

                    }
                    else
                    {
                        if (siranumarasi2 < 3)
                        {
                            objectToInstatiate[siranumarasi].transform.gameObject.tag = "fly";
                            objectToInstatiate[siranumarasi].transform.Find("Cube").gameObject.SetActive(true);
                            objectToInstatiate[siranumarasi].transform.Find("Cube (1)").gameObject.SetActive(false);

                            objectToInstatiate[siranumarasi].SetActive(true);
                            objectToInstatiate[siranumarasi].transform.position = olusacaknoktam[siranumarasi2].transform.position;
                            siranumarasi2++;
                            break;
                        }
                        else
                        {
                            siranumarasi2 = 0;
                            objectToInstatiate[siranumarasi].transform.gameObject.tag = "fly";
                            objectToInstatiate[siranumarasi].transform.Find("Cube").gameObject.SetActive(true);
                            objectToInstatiate[siranumarasi].transform.Find("Cube (1)").gameObject.SetActive(false);

                            objectToInstatiate[siranumarasi].SetActive(true);
                            objectToInstatiate[siranumarasi].transform.position = olusacaknoktam[siranumarasi2].transform.position;
                            siranumarasi2++;
                            break;
                        }
                        
                    }
                }
                else
                {
                    siranumarasi = 0;
                    continue;
                    
                }
            }
        }
 
    }
}
