using UnityEngine;
using UnityEngine.UI;

public class DrawCard : MonoBehaviour {

    public Image image;

    private void Start()
    {
        image.enabled = false;
    }

    private void OnMouseDown()
    {
        image.enabled = !image.enabled;
    }
}
