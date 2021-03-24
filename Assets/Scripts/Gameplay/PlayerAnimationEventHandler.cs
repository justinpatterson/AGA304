using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEventHandler : MonoBehaviour
{
    public void JumpSFX()
    {
        AudioManager.instance.PlaySoundEffect(AudioManager.SoundFXTypes.Jump);
    }
}
