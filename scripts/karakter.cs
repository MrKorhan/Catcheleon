using UnityEngine;
using System.Collections;




public class karakter : MonoBehaviour
{
    public GameObject[] noktalar;
    Transform gecerlinokta;
    Vector3 poz;
    Vector3 poz2;
    int devriyeNoktaSayisi = 0;
    public GameObject bukelemun;
    bool durdur = true;
    LineRenderer line;

    UnityEngine.TouchPhase touchPhase = UnityEngine.TouchPhase.Ended;

    Transform child0;
    Transform child1;
    public IEnumerator yineleyici;
    
    void Start()
    {
        
        gecerlinokta = noktalar[0].transform;
        line = GetComponentInChildren<LineRenderer>();
        child0 = transform.Find("Cube");
        child1 = transform.Find("Cube (1)");
        
        InvokeRepeating("RenkDegisim", 3f, 2f);
    }

   
    
    void RenkDegisim()
    {
        if (child0.gameObject.activeSelf)
        {
            child0.gameObject.SetActive(false);
            child1.gameObject.SetActive(true);

            transform.gameObject.tag = "KirmiziSinek";
        }
        else
        {
            child0.gameObject.SetActive(true);
            child1.gameObject.SetActive(false);

            transform.gameObject.tag = "fly";
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        SinekYakala();
        
        if (durdur == true)
        {
            poz = gecerlinokta.position - transform.position;
            transform.Translate(poz.normalized * 10f * Time.deltaTime, Space.World);


            var newRotation = Quaternion.LookRotation(poz, Vector3.forward);
            newRotation.x = 0.0f;
            newRotation.z = 0.0f;
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8f);

            if (Vector3.Distance(transform.position, gecerlinokta.position) <= .1f)
            {
                BirsonrakiPozisyonagit();

            }



            void BirsonrakiPozisyonagit()
            {

                if (devriyeNoktaSayisi >= noktalar.Length - 1)
                {

                    devriyeNoktaSayisi = 0;
                    return;
                }


                else
                {
                    devriyeNoktaSayisi = Random.Range(0, 9); //1 // 2
                }

                gecerlinokta = noktalar[devriyeNoktaSayisi].transform;



            }
        }
        else 
        {
            poz2 = bukelemun.transform.position - transform.position;
            transform.Translate(poz2.normalized * 130f * Time.deltaTime, Space.World);
            Cizdirme();

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pasif"))
        {
            durdur = true;
            line.SetPosition(1, transform.position);
            transform.gameObject.tag = "fly";
        }
    }

    //private void OnMouseDown()
    //{
    //    durdur = false;
        
        
    //}
    void Cizdirme()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, bukelemun.transform.position);
    }
public void SinekYakala()
{
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
           // Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("fly") || hit.transform.CompareTag("KirmiziSinek"))
                {
                    GameObject touchedObject = hit.transform.gameObject;
                    touchedObject.GetComponent<karakter>().durdur = false;
                }
            
            }
        }
    }


}
