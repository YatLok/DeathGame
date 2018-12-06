using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapButton : MonoBehaviour {

    public void Town()
    {
        FadeManager.Instance.LoadScene("Town2", 1.0f);
        //SceneManager.LoadScene("Town2");
    }

    public void client()
    {
        GameObject aaa = GameObject.Find("DirectorUI");
        aaa.GetComponent<map2UI>().clientBorC();
        //FadeManager.Instance.LoadScene("clientB", 1.0f);
        //SceneManager.LoadScene("clientB");
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
