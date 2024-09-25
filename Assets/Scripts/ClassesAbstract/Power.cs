using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Power : Invocable
{
    [SerializeField]
    public EntitySO entitySO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HeroPower()
    {

    }

    public void PassData()
    {
        GameManager.gameManager.powerImage.sprite = this.entitySO.design;
        GameManager.gameManager.powerMana.text = this.mana.ToString();
    }
}
