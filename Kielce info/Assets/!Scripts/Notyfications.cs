using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.SimpleAndroidNotifications
{
    public class Notyfications : MonoBehaviour
    {
        public float timer;

        void Update()
        {
            timer += Time.deltaTime;

            if (timer >= 30f)
            {
                int infoLos = Random.Range(0, LoadZabytek.objects.Length);
                if (LeagueSelector.league == "Polish")
                {
                    NotificationManager.SendWithAppIcon(System.TimeSpan.FromSeconds(5), LoadZabytek.objects[infoLos].namePL, LoadZabytek.objects[infoLos].descriptionPL, new Color(0, 0.6f, 1), NotificationIcon.Event);
                }
                if(LeagueSelector.league == "England")
                {
                    NotificationManager.SendWithAppIcon(System.TimeSpan.FromSeconds(5), LoadZabytek.objects[infoLos].nameEN, LoadZabytek.objects[infoLos].descriptionEN, new Color(0, 0.6f, 1), NotificationIcon.Event);
                }
                timer = 0;
            }

        }
    }
}
