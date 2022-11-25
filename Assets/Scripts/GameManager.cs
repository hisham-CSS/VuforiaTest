using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> huntList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTargetFound(GameObject target)
    {
        huntList.Remove(target);

        if (huntList.Count <= 0)
            Debug.Log("You WIN!");
    }
        
}
