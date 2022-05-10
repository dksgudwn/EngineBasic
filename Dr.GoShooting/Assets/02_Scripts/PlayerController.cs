using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    KeyCode keyCodeAttack = KeyCode.Space;
    [SerializeField]
    StageData stageData;
    public float speed = 5;
    MoveMent movement;
    Weapon Weapon;
    private void Awake()
    {
        movement = GetComponent<MoveMent>();
        Weapon = GetComponent<Weapon>();
    }
    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        movement.MoveTo(new Vector3(x, y, 0));
        if(Input.GetKeyDown(keyCodeAttack))
        {
            Weapon.StartFiring();
        }
        else if(Input.GetKeyUp(keyCodeAttack))
        {
            Weapon.StopFiring();
        }
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
            Mathf.Clamp(transform.position.y, stageData.LimitMin.x, stageData.LimitMax.y),0);
    }
}
