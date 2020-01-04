using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory(ActionCategory.Physics)]
    public class RigidbodyMoveForward : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Rigidbody))]
        [Tooltip("The GameObject to move.")]
        public FsmOwnerDefault gameObject;

        [Tooltip("Axis values are in the range -1 to 1. Use the multiplier to set a larger range.")]
        public FsmFloat multiplier;

        private Rigidbody rigidbody;
        private GameObject go;

        // Code that runs on entering the state.
        public override void OnEnter()
        {
            go = Fsm.GetOwnerDefaultTarget(gameObject);

            if (rigidbody == null)
            {
                rigidbody = go.GetComponent<Rigidbody>();
            }
        }

        // Code that runs every frame.
        public override void OnUpdate()
        {
            rigidbody.MovePosition(go.transform.position + go.transform.forward * multiplier.Value);
        }
    }
}
