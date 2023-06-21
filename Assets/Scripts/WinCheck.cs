using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Check()
    {
        map = (int[,])StageGenScript.lvl_layout.Clone();
    } 
}
