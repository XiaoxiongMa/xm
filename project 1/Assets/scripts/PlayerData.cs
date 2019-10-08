using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public Sprite sprites;
    public new Color color;
    public new GameObject prefab;
    public GameObject weapon;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprites;
        newSprite.color = color;
    }
}
