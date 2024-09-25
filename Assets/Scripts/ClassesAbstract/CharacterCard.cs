using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterCard : Card
{
    [SerializeField]
    public CharacterSO characterSO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Invoke(Token token)
    {

    }

    public void PassData()
    {
        GameManager.gameManager.chHp.text = this.characterSO.hp.ToString();
        GameManager.gameManager.chMana.text = this.mana.ToString();
        GameManager.gameManager.chDescription.text = this.characterSO.description;
        GameManager.gameManager.chDamage.text = this.characterSO.damage.ToString();
        GameManager.gameManager.chImage.sprite = this.characterSO.design;
    }
}
