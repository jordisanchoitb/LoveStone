using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObjects/Entity")]

public class EntitySO : ScriptableObject
{
    public string name;
    public Sprite design;
    public string description;
}
