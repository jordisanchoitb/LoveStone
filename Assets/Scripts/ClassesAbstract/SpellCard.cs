using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellCard: Card
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
    public void PassData()
    {
        GameManager.gameManager.spellMana.text = this.mana.ToString();
        GameManager.gameManager.spellDescription.text = this.entitySO.description;
        GameManager.gameManager.spellImage.sprite = this.entitySO.design;
    }

}
