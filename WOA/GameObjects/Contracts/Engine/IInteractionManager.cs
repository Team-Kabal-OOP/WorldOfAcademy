﻿namespace GameObjects.Contracts.Engine
{
    public interface IInteractionManager
    {
        void AddTrainer(string name);

        void AddStudent(string name);

        void PrintStatus(string name);
        void InvalidCommand();
        void StartExam(string trainerName);
    }
}
