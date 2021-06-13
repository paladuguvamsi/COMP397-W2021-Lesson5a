using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class Pausable : MonoBehaviour
{
    public List<MonoBehaviour> scripts;
    public List<NavMeshAgent> agenst; 
    public bool isGamePaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void TogglePause()
    {
        isGamePaused = !isGamePaused;
        foreach(var script in scripts)
        {
            script.enabled = !isGamePaused;
        }
        foreach (var agent in agenst)
        {
            agent.enabled = !isGamePaused;
        }

    }
}
