using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //Parameters
    [SerializeField] int breakableBlocks;

    //Cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        //Remove a block counter
        breakableBlocks--;
        //Check if blocks left
        if(breakableBlocks <= 0)
        {
            //Load Next Level
            sceneLoader.LoadNextScene();
        }
    }
}
