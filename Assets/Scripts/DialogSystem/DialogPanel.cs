using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogPanel : MenuPanel
{
    public Text nameText;
    public Text dialogText;
    public Image dialogImage;

    public void SetDialogObject(DialogManager.DialogObject dialogObject)
    {
        SetImageSprite(dialogObject.characterSprite);
        SetDialogText(dialogObject.dialog);
        SetNameText(dialogObject.name);
    }

    void SetImageSprite(Sprite dialogSprite)
    {
        dialogImage.sprite = dialogSprite;
    }

    void SetNameText(string name)
    {
        nameText.text = name;
    }
    void SetDialogText(string dialog)
    {
        dialogText.text = dialog;
    }

    public void OnNextDialogButtonPressed()
    {
        DialogManager dm = GameObject.FindObjectOfType<DialogManager>();
        if (dm != null)
            dm.IterateDialog();
    }
}
