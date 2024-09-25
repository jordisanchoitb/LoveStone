using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Invocable : MonoBehaviour
{
    [SerializeField]
    public int mana;
    [SerializeField]
    public int crurrentMana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() { }
}
