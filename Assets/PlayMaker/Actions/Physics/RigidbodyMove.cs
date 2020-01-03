using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory(ActionCategory.Physics)]
    public class RigidbodyMove : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Rigidbody))]
        [Tooltip("The GameObject to move.")]
        public FsmOwnerDefault gameObject;

        [Tooltip("The movement vector.")]
        public FsmVector3 moveVector;


        public Rigidbody rigidbody;
        public GameObject go;

        // Code that runs on entering the state.

        public override void OnEnter()
        {
            go = Fsm.GetOwnerDefaultTarget(gameObject);

            if (rigidbody == null)
            {
                rigidbody = go.GetComponent<Rigidbody>();
            }
        }

        public override void OnUpdate()
        {
            rigidbody.MovePosition(go.transform.position + moveVector.Value);
        }

    }
}
