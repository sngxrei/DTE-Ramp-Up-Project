using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    [SerializeField] Material hit;
    [SerializeField] Material notHit;
    private bool _isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isHit)
        {
            GetComponent<Renderer>().material = hit;
        }
        //else
        //{
        //    GetComponent<Renderer>().material = notHit;
        //}
    }

    public void IsHit()
    {
        _isHit = true;
    }
}
