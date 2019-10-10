using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
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
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprites;
        newSprite.color = color;
    }
}
