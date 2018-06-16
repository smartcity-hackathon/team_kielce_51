using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoControler : MonoBehaviour {

    public float timer;
    public GameObject logo1, logo2,circle;

    public GameObject infoPanel,list;

	// Use this for initialization
	void Start () {
        timer = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        circle.GetComponent<Image>().fillAmount = timer / 12f;

        if(timer >= 10f && timer <= 11f)
        {
            infoPanel.SetActive(false);
        }
        if(timer <= 9f)
        {
            infoPanel.SetActive(true);
        }
        
        if (timer >= 12f && timer <= 13f)
        {
            logo1.SetActive(false);
            logo2.SetActive(false);
            list.SetActive(false);
        }
	}
}
