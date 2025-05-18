using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bombinha : MonoBehaviour
{
    ParticleSystem myPS;

    // Start is called before the first frame update
    void Start()
    {
        myPS = GetComponent<ParticleSystem>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag =="Bomba")
        {
            ParticleSystem.Particle[] particulas = new ParticleSystem.Particle[myPS.main.maxParticles];//coloca as particulas criadas pelo sistema em um array

            myPS.GetParticles(particulas);//adentra nas particulas estipuladas pelo nome particulas dentro do myPS

            for (int i = 0; i < particulas.Length; i++)//com esse contador usando for, conta cada particula no array
            {
                if (Vector2.Distance(particulas[i].position, other.transform.position) <= 5f)//com esse if, cada particula que é acertada pela bombinha e está em uma posição menor que 5f
                {
                    particulas[i].remainingLifetime = 0;//faz com que a particula suma
                }
            }
        }
    }
}
