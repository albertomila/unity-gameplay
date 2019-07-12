using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelManager.CreateInstance();
        LevelManager go = LevelManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
