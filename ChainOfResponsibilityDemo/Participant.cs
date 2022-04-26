using System;

namespace ChainOfResponsibilityDemo
{
    public abstract class AbstractParticipant
    {
        protected string name;
        protected string strongArea;
        protected AbstractParticipant nextParticipant;
     
        protected AbstractParticipant(string name,string strongArea)
        {
            this.name = name;
            this.strongArea = strongArea;
        }

        public void SetNextParticipant(AbstractParticipant participant)
        {
            nextParticipant = participant;
        }

        public abstract void Answer(string area);
    }

    public class Participant : AbstractParticipant
    {
        public Participant(string name, string strongArea) :base(name, strongArea)
        {
        }

        public override void Answer(string area)
        {
            if (area == strongArea)
            {
                Console.WriteLine($"{name} answers it!");
            }
            else
            {
                if (nextParticipant != null)
                {
                    nextParticipant.Answer(area);
                } 
                else
                {
                    Console.WriteLine("No one can answer");
                }
            }
        }
    }
}
