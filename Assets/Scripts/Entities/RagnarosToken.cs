using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagnarosToken : Token, IOnDead, IOnDamaged, IEffect
{
    public void Effect()
    {
        throw new System.NotImplementedException();
    }

    public void Effect(Fighter target)
    {
        throw new System.NotImplementedException();
    }

    public void Effect(Fighter[] targets)
    {
        throw new System.NotImplementedException();
    }

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
