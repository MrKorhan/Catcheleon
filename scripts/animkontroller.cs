using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animkontroller : MonoBehaviour
{
    public GameObject zamanliObje1;
    public GameObject zamanliObje2;

    private void Start()
    {
        StartCoroutine(ZamanliBaslaticim());
    }
    IEnumerator ZamanliBaslaticim()
    {
        zamanliObje1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        zamanliObje2.SetActive(true);
    }



}
