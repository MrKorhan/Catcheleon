using UnityEngine;
using UnityEngine.SceneManagement;

public class Baslatıcı : MonoBehaviour
{
    public void OyunuBaslat()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
