using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Text chMana, chHp, chDamage, chDescription, tokenDamage, tokenHp, powerMana, spellMana, spellDescription;
    public Image chImage, avImage, powerImage, tokenImage, spellImage;
    void Awake()
    {
       if (gameManager != null && gameManager != this)
           Destroy(this.gameObject);
       gameManager = this;
    }
}
