using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Token : Fighter
{
    [SerializeField]
    public int position;
    [SerializeField]
    public int currentHp;
    [SerializeField]
    public int currentDamage;
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

    public void PassData()
    {
        GameManager.gameManager.tokenHp.text = this.characterSO.hp.ToString();
        GameManager.gameManager.tokenDamage.text = this.characterSO.damage.ToString();
        GameManager.gameManager.tokenImage.sprite = this.characterSO.design;
    }
}
