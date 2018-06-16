using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListControler : MonoBehaviour {

    public ZabyktiObcjetc info;

    public Text nameB;
    public RawImage image;

    public string url;

    public GameObject list, infoPanel;

    //Do panel info
    public static GameObject panelName;
    public static GameObject panelDesc;
    public static GameObject panelImage;

    private void Start()
    {

        url = info.urlImage;

        StartCoroutine("StartIE");

    }
    private void Update()
    {
        if (LeagueSelector.league == "Polish")
        {
            nameB.text = info.namePL;
        }
        if (LeagueSelector.league == "England")
        {
            nameB.text = info.nameEN;
        }
        if (infoPanel == null)
        {
            list = GameObject.FindGameObjectWithTag("List");
            infoPanel = GameObject.FindGameObjectWithTag("InfoPanel");
            panelName = GameObject.FindGameObjectWithTag("Name");
            panelDesc = GameObject.FindGameObjectWithTag("Desc");
            panelImage = GameObject.FindGameObjectWithTag("Image");
        }
    }



    IEnumerator StartIE()
    {
        // Start a download of the given URL
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            yield return www;

            // assign texture
            image.texture = www.texture;

        }
    }

    IEnumerator StartPanel()
    {
        // Start a download of the given URL
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            yield return www;

            // assign texture
            panelImage.GetComponent<RawImage>().texture = www.texture;

        }
    }

    public void OnCLick()
    {

        list.SetActive(false);
        infoPanel.SetActive(true);
        panelImage.GetComponent<RawImage>().texture = image.texture;
        if(LeagueSelector.league == "Polish")
        {
            panelDesc.GetComponent<Text>().text = info.descriptionPL;
            panelName.GetComponent<Text>().text = info.namePL + "|" + info.locationPL;
        }
        if (LeagueSelector.league == "England")
        {
            panelDesc.GetComponent<Text>().text = info.descriptionEN;
            panelName.GetComponent<Text>().text = info.nameEN + "|" + info.locationEN;
        }

    }

}
