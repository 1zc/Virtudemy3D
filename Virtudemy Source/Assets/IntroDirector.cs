using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDirector : MonoBehaviour
{

    public GameObject director;
    float fadeTime;
    

    public void ExploreButton()
    {
        fadeTime = director.GetComponent<Fade>().BeginFade(1);
        //yield return new WaitForSeconds(fadeTime);
        wait();
        Change();
        
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
    }

    public void Change()
    {
        Application.LoadLevel("Menu");
    }

}
