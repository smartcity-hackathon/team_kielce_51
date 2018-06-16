using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour {

    public GameObject list, panelInfo,button1;
    public string url;
    public RawImage panelImage1;

    public void Back()
    {
        list.SetActive(true);
        panelInfo.SetActive(false);
        button1.SetActive(true);
        gameObject.SetActive(false);
    }

    public void RandomButton()
    {
        panelInfo.SetActive(true);
        int infoNuber = Random.Range(0, LoadZabytek.objects.Length);
        url = LoadZabytek.objects[infoNuber].urlImage;
        StartCoroutine("StartPanel");
        if (LeagueSelector.league == "Polish")
        {
            ButtonListControler.panelDesc.GetComponent<Text>().text = LoadZabytek.objects[infoNuber].descriptionPL;
            ButtonListControler.panelName.GetComponent<Text>().text = LoadZabytek.objects[infoNuber].namePL + "|" + LoadZabytek.objects[infoNuber].locationPL;
        }
        if (LeagueSelector.league == "England")
        {
            ButtonListControler.panelName.GetComponent<Text>().text = LoadZabytek.objects[infoNuber].nameEN + "|" + LoadZabytek.objects[infoNuber].locationEN;
            ButtonListControler.panelDesc.GetComponent<Text>().text = LoadZabytek.objects[infoNuber].descriptionEN;
        }
        list.SetActive(false);

        button1.SetActive(true);
    }

    private void Update()
    {

       /* if(ButtonListControler.panelImage.GetComponent<RawImage>().texture != null)
        {
            gameObject.SetActive(false);
            
        }
        */
    }

    IEnumerator StartPanel()
    {
        // Start a download of the given URL
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            yield return www;

            // assign texture
            ButtonListControler.panelImage.GetComponent<RawImage>().texture = www.texture;



        }
    }


}
