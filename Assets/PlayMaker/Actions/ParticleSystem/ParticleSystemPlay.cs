using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("ParticleSystem")]
    public class ParticleSystemPlay : FsmStateAction
    {
        public FsmOwnerDefault gameObject;
        private ParticleSystem ps;

        // Code that runs on entering the state.
        public override void OnEnter()
        {
            ps = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<ParticleSystem>();

            ps.Play();

            Finish();
        }
    }
}
