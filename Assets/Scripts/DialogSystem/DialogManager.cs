using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    [System.Serializable]
    public struct DialogObject
    {
        [SerializeField]
        public Sprite characterSprite;
        [SerializeField]
        public string name;
        [SerializeField]
        public string dialog;
    }

    public DialogObject[] DEBUG_dialogs;
    public DialogPanel dialogPanel;


    DialogObject[] _currentDialogSeries;
    int _currentDialogIndex;
    bool _dialogInProgress = false;

    private void Awake()
    {
        TriggerDialogSeries(DEBUG_dialogs);
    }


    public void TriggerDialogSeries(DialogObject[] dialogSeries)
    {
        _currentDialogIndex = 0;
        _currentDialogSeries = dialogSeries;

        ShowCurrentDialog();
        _dialogInProgress = true;
        dialogPanel.OpenPanel();
    }

    public void ShowCurrentDialog()
    {
        if (_currentDialogSeries.Length > _currentDialogIndex)
        {
            DialogObject currentDialog = _currentDialogSeries[_currentDialogIndex];
            dialogPanel.SetDialogObject(currentDialog);
        }
        else
        {
            _dialogInProgress = false;
            dialogPanel.ClosePanel();
        }

    }

    public void IterateDialog()
    {
        _currentDialogIndex++;
        ShowCurrentDialog();
    }

}

