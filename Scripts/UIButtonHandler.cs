using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonHandler : MonoBehaviour
{
  public bool selector=true;
   public bool helper=true;
    public bool btnpb=true;
 public bool setb=true;

    public GameObject btnP;
public GameObject select;
public GameObject helpObj;
public GameObject settingsUI;
   void Start()
   {
    //   select.SetActive(false);
   }

  public void selec()
   {
       select.SetActive(selector);
       selector=!selector;
   }
  public void helperF()
   {
       helpObj.SetActive(helper);
       helper=!helper;
   } 
   public void buttonPF()
   {
       btnP.SetActive(btnpb);
       btnpb=!btnpb;
   }
    public void SetttingsPF()
   {
       settingsUI.SetActive(setb);
       setb=!setb;
   }
}
