using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    bool _isOpen = false;

    private void Awake()
    {
        _isOpen = gameObject.activeSelf;
    }

    public virtual void OpenPanel()
    {
        _isOpen = true;
        gameObject.SetActive(_isOpen);
    }

    public virtual void ClosePanel()
    {
        _isOpen = false;
        gameObject.SetActive(_isOpen);
    }
}
