using UnityEngine;

public class Character : MonoBehaviour
{
    protected Health health;
    protected Collider characterCollider;
    [SerializeField]
    protected Animator characterAnimator;
    protected  private void Awake() 
    {
        health = GetComponent<Healt>();
        characterCollider = GetComponent<Collider>();
        characterAnimator = GetComponent<Animator>();
    }
}