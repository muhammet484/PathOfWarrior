using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PlayerAttackController : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] ThirdPersonController controller;
    [SerializeField] bool _StopPlayer;

    bool CanAttack = true;

    float ControllerMoveSpeed;
    float ControllerSprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CanAttack)
        {
            PlayerAttack();
        }
    }
    void PlayerAttack()
    {
        animator.SetTrigger("Attack");
        CanAttack = false;
        StopPlayer(true);
    }
    void SetCanAttackTrue()
    {
        CanAttack = true;
        StopPlayer(false);
    }

    void StopPlayer(bool ShouldStop)
    {
        if(_StopPlayer)
        controller.PlayerStop = ShouldStop;
        /*
        if (ShouldStop)
        {
            ControllerMoveSpeed = controller.MoveSpeed;
            ControllerSprintSpeed = controller.SprintSpeed;

            controller.MoveSpeed = 0;
            controller.SprintSpeed = 0;
        }
        else
        {
            controller.MoveSpeed = ControllerMoveSpeed;
            controller.SprintSpeed = ControllerSprintSpeed;
        }*/
    }
}
