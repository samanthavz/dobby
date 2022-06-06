using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    int receivedPoints = Scoring.totalscore;
    public Animator animator;

    public void percentagestart(){
        Scoring.totalscore = 50;
    }
    public void percentageplus10(){ 
        Scoring.totalscore += 10;
    }

    public void percentageplus20(){ 
        Scoring.totalscore += 20;
    }

    public void percentageplus30(){ 
        Scoring.totalscore += 30;
    }

    public void percentageplus40(){ 
        Scoring.totalscore += 40;
    }

    public void percentagemin10(){ 
        Scoring.totalscore -= 10;
    }

    public void percentagemin20(){ 
        Scoring.totalscore -= 20;
    }

    public void percentagemin30(){ 
        Scoring.totalscore -= 30;
    }

    public void percentagemin40(){ 
        Scoring.totalscore -= 40;
    }

    void Update()
    {

        if(Scoring.totalscore > 49)
        {
            Debug.Log("Sock full");
            animator.SetBool("1", true);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
        }
        else if(Scoring.totalscore > 29)
        {
            Debug.Log("Sock almost full");
            animator.SetBool("2", true);
            animator.SetBool("1", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
        }
        else if(Scoring.totalscore > 19)
        {
            Debug.Log("Sock half");
            animator.SetBool("3", true);
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
        }
        else if(Scoring.totalscore > 9)
        {
            Debug.Log("Sock almost dead");
            animator.SetBool("4", true);
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("5", false);
        }
        else if(Scoring.totalscore > 0)
        {
            Debug.Log("Sock dead");
            animator.SetBool("5", true);
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
        }
    }
}
