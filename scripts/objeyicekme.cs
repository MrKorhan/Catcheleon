using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objeyicekme : MonoBehaviour
{
    
    public GameObject objectToInstatiate;
   // public Text text;
    //public Text Endtext;
   // int puanarttır = 0;
    private void Start()
    {
       // text.text = puanarttır.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naber");
        if (other.CompareTag("Karasinek"))
        {
            Destroy(other.gameObject);
            InstantiateObject();
            
           // puanarttır += 5;
           // text.text = puanarttır.ToString();
           // Endtext.text = "Score: " + puanarttır.ToString();
        }
    }
    private void InstantiateObject()
    {
        float x = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);
        Instantiate(objectToInstatiate, new Vector3(x, 29.83925f, z), Quaternion.identity);
        
    }
}
