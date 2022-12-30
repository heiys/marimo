using UnityEngine;
using UnityEngine.UI;

public class BaseButton: MonoBehaviour
{
    private void Awake()
    {
        Button currentButton = transform.gameObject.GetComponent<Button>();
        currentButton.onClick.AddListener(OnClick);
    }

    // override each button's event
    virtual protected void OnClick() { }
}
