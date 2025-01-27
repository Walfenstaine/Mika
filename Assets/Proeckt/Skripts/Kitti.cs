using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Kitti : MonoBehaviour
{
    public List<float> dist;
    public AudioClip clip;
    public NavMeshAgent agent;
    public Animator anim;
    public Transform target, point;
    float timer = 0;

    public void AddPlayer() 
    {
        SoundPlayer.regit.Play(clip,2);
        Player_Muwer.rid.AddKitti(this);
    }

    public void Onpoint(Transform t) 
    {
        if (target == null) 
        {
            timer = Time.time + Random.Range(10, 20);
            point = t;
        }
        
    }

    private void FixedUpdate()
    {
        if (agent.enabled) 
        {
            if (target != null)
            {
                agent.speed = 3;
                anim.SetBool("Walck", false);
                if (agent.velocity.magnitude > 0.5f)
                {
                    anim.SetBool("Run", true);
                }
                else
                {
                    anim.SetBool("Run", false);
                }
                agent.destination = target.position;
                timer = 0;
                point = null;
            }
            else
            {
                if (point != null)
                {
                    agent.speed = 1;
                    anim.SetBool("Run", false);
                    if (agent.velocity.magnitude > 0.5f)
                    {
                        anim.SetBool("Walck", true);
                    }
                    else
                    {
                        anim.SetBool("Walck", false);
                    }
                    agent.destination = point.position;
                }
                else 
                {
                    GameObject[] g = GameObject.FindGameObjectsWithTag("Kity_Point");
                    for (int i = 0; i < g.Length; i++) 
                    {
                        dist.Add(Vector3.Distance(g[i].transform.position, transform.position));
                        float min = dist[0];
                        for (int j = 0; j < dist.Count; j++)
                        {
                            if (min > dist[j])
                            {
                                min = dist[j];
                                Kity_Point p = g[j].GetComponent<Kity_Point>();
                                Onpoint(p.next[Random.Range(0, 2)]);
                            }
                            
                        }
                    }
                }
            }
            if (timer < Time.time)
            {
                agent.isStopped = false;
            }
            else
            {
                agent.isStopped = true;
            }
            anim.SetFloat("Speed", agent.velocity.magnitude / 2);
        }
        else
        {
            agent.enabled = true;
        }

        
        
    }
    
}
