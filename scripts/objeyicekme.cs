using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objeyicekme : MonoBehaviour
{
    
    public GameObject objectToInstatiate;
   // public Text text;
    //public Text Endtext;
   // int puanartt�r = 0;
    private void Start()
    {
       // text.text = puanartt�r.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naber");
        if (other.CompareTag("Karasinek"))
        {
            Destroy(other.gameObject);
            InstantiateObject();
            
           // puanartt�r += 5;
           // text.text = puanartt�r.ToString();
           // Endtext.text = "Score: " + puanartt�r.ToString();
        }
    }
    private void InstantiateObject()
    {
        float x = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);
        Instantiate(objectToInstatiate, new Vector3(x, 29.83925f, z), Quaternion.identity);
        
    }
}
