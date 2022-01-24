using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoDestroyanimation : MonoBehaviour
{
    float delay = 0f;
    
    Animator kontrolanim;

    // Use this for initialization
    void Start()
    {
        kontrolanim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (kontrolanim.isActiveAndEnabled == true)
        {
            kontrolanim.SetTrigger("yokOl");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);

        }
    }
    public void AnimasyonSonu()
    {
        SceneManager.LoadScene("ReplayGame");
    }
}
