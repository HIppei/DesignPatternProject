using System;

namespace ChainOfResponsibilityDemo
{
    public class QuizeMaster
    {
        private AbstractParticipant participant1;
        private AbstractParticipant participant2;
        private AbstractParticipant participant3;

        public QuizeMaster()
        {
           participant1 = new Participant("John", "History");
           participant2 = new Participant("David", "Music");
           participant3 = new Participant("Raj", "Language");
           participant1.SetNextParticipant(participant2);
           participant2.SetNextParticipant(participant3);
        }

        public void AskQuestion(string area)
        {
            Console.WriteLine($"Question is {area}");
            participant1.Answer(area);
        }
    }
}
