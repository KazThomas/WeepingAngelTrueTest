using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolState : MonoBehaviour
{

    public interface IState
    {
        void Handle();
    }
    public abstract class State : IState

    {

        protected StateMachine controller;

        protected NavMeshAgent agent;


        public State(StateMachine controller, NavMeshAgent agent)

        {

            this.controller = controller;

            this.agent = agent;

        }


        public abstract void Handle();

    }

    public class PatrlState : State, IPatrlState
    {



        public override void Handle()
        {
            throw new System.NotImplementedException();
        }
        public void override Handle()
        {

        }
    }

}
