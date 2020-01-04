using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("Dotween")]
    public class DoSlider : FsmStateAction
    {
        public Slider slider;
        public FsmFloat m_fBeginValue;
        public FsmFloat m_fEndValue;
        public FsmFloat m_fTime;

        // Code that runs on entering the state.
        public override void OnEnter()
        {
            slider.value = m_fBeginValue.Value;

            slider.DOValue(m_fEndValue.Value, m_fTime.Value);

            Finish();
        }
    }
}
