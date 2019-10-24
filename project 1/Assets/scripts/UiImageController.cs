using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UiImageController : MonoBehaviour
{
    private Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(FloatData data)
    {
        Debug.Log("test");
        img.fillAmount = data.value;
    }
    
}

   