using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IK_Test : MonoBehaviour
{
    protected Animator _animator;
    [SerializeField] public Transform rightHandObj = null;
    private bool checkRightHand = false;
    [SerializeField] public Transform leftHandObj = null;
    private bool checkLeftHand = false;
    [SerializeField] public Transform lookObj = null;
    public bool checkLookObj = false;

    public bool ikActive = false;
    //private GameObject _player;
    void Start()
    {
        _animator = GetComponent<Animator>();

    }
    void OnAnimatorIK()
    {
        if (_animator)
        {
            ikActive = true;

            if (Input.GetKey(KeyCode.E))
            {
                checkLeftHand = true;
                checkRightHand = true;
            }
            else
            {
                checkLeftHand = false;
                checkRightHand = false;
            }

            if (ikActive)
            {
                if (checkLookObj) //lookObj != null
                {
                    _animator.SetLookAtWeight(1);
                    _animator.SetLookAtPosition(lookObj.position);
                }

                if (checkRightHand) //rightHandObj != null
                {
                    _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                    _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                    _animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    _animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
                }

                if (checkLeftHand) //leftHandObj != null
                {
                    _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
                    _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
                    _animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
                    _animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);
                }
            }
            else
            {
                _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
                _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
                _animator.SetLookAtWeight(0);
            }
        }
    }
}
