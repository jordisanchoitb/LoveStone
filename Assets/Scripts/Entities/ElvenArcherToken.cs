using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenArcherToken : Token, IOnDamaged, IOnDead
{
    public void OnDamaged()
    {
        throw new System.NotImplementedException();
    }

    public void OnDead()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        base.PassData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
