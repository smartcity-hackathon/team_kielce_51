using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitching : MonoBehaviour {

    public GameObject button1,button2;

   public void ImageCornerswitch()
   {
        button1.SetActive(false);
        button2.SetActive(true);
   }
   public void ImageCornerswitchRevert()
   {
        button1.SetActive(true);
        button2.SetActive(false);
   }
    public void Test()
    {
        Debug.Log("Test");
    }


}
