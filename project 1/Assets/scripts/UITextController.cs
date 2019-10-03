using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    private Text TextLabel;

    public void UpdateText(IntData date)
    {
        TextLabel.text = date.value.ToString();
    }

    void Awake()
    {
        TextLabel = GetComponent<Text>();
    }
}

