using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;

        [SerializeField]
        private Light light;

        private int awakeTime = 3;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();

        }

        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
            hitPoints--;
            animator.SetTrigger("Hit");
            if(hitPoints == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            StartCoroutine(lightDie());
        } 
        
        private IEnumerator lightDie()
        {
            animator.SetTrigger("Die");
            light.GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(3f);
            light.GetComponent<Light>().enabled = false;

            Destroy(this.gameObject);
        }
    }

}