using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objeyicekme : MonoBehaviour
{
    
    public GameObject objectToInstatiate;
   // public Text text;
    //public Text Endtext;
   // int puanarttýr = 0;
    private void Start()
    {
       // text.text = puanarttýr.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naber");
        if (other.CompareTag("Karasinek"))
        {
            Destroy(other.gameObject);
            InstantiateObject();
            
           // puanarttýr += 5;
           // text.text = puanarttýr.ToString();
           // Endtext.text = "Score: " + puanarttýr.ToString();
        }
    }
    private void InstantiateObject()
    {
        float x = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);
        Instantiate(objectToInstatiate, new Vector3(x, 29.83925f, z), Quaternion.identity);
        
    }
}
