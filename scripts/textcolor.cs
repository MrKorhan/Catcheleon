using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcolor : MonoBehaviour
{
    Text text;
    private Color RandomColor;
    private float RandomChannelOne, RandomChannelTwo, RandomChannelThree;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
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

        RandomColor = new Color(RandomChannelOne, RandomChannelTwo, RandomChannelThree, 1f);

        text.color = RandomColor;
    }
}
