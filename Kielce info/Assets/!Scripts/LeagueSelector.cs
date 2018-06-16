using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeagueSelector : MonoBehaviour {

    public static string league;

    public GameObject list;

    public GameObject poland, english;
    public Button button1;

    public void Polish()
    {
        league = "Polish";
        list.SetActive(true);
        poland.SetActive(false);
        english.SetActive(false);
        button1.interactable = true;
        
    }
    public void English()
    {
        league = "England";
        list.SetActive(true);
        poland.SetActive(false);
        english.SetActive(false);
        button1.interactable = true;
    }

}
