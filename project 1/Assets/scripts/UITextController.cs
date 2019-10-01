using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    public UnityEvent startEvent; 
    private Text TextLabel;

    public void UpdateText(IntData date)
    {
        TextLabel.text = date.value.ToString();
    }

    void Start()
    {
        TextLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}

