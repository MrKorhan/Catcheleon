using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    private Color RandomColor;
    private float RandomChannelOne, RandomChannelTwo, RandomChannelThree;
    void Start()
    {
        StartCoroutine(ChangeColorum());
    }
    IEnumerator ChangeColorum()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            randomoColor();
        }
        
    }

    

    private void randomoColor()
    {
        RandomChannelOne = Random.Range(0f, 1f);
        RandomChannelTwo = Random.Range(0f, 1f);
        RandomChannelThree = Random.Range(0f, 1f);

        RandomColor = new Color(RandomChannelOne,RandomChannelTwo,RandomChannelThree,1f);

        gameObject.GetComponent<Renderer>().material.color = RandomColor;
    }


}
