using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    [SerializeField]
    public int damage;
    [SerializeField]
    public int hp;
    [SerializeField]
    public int team;
    [SerializeField]
    public int currentHp;
    [SerializeField]
    public int currentDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(Fighter fighter) { }
}
