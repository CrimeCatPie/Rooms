using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawn : MonoBehaviour, Iclickable
{
    public static bool isEnabled = false;
    public bool IsTouched = false;
    public bool SpawnCubes;

    public bool Blue;
    public bool Yellow;
    public bool Red;
    public bool Green;

    
    
    public void OnPointerClick()
    {
        Click();
    }

    public void OnPointerEnter()
    {
        
        OnLookAt();
    }

    public void OnPointerExit()
    {
        
        OnLookExit();
    }

    public virtual void Click()
    {
        
        IsTouched = true;
    }

   

    public virtual void OnLookAt()
    {

        Debug.Log("look!");
    }

    public virtual void OnLookExit()
    {
        
        
    }


   
}
