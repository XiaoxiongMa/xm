using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public UnityAction<GameObject> instanceAction;
    public UnityEvent onRunEvent;
    
    public Sprite sprites;
    public Color color;
    public GameObject prefab;
    public GameObject weapon;
    public FloatData health;
    public ClotherData shirt;
    public ClotherData pants;
    public List<WeaponData> weapons;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        playerSprite.sprite = sprites;
        playerSprite.color = spritecolor;
        instanceAction(newPlayer);
    }

    public void Run()
    {
        onRunEvent.Invoke();
    }
}

