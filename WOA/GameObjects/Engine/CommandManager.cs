﻿namespace GameObjects.Engine
{
    using System;

    using Contracts.Engine;

    public class CommandManager
    {
        public CommandManager(IInteractionManager interactionManager)
        {
            this.InteractionManager = interactionManager;
        }

        public string Command { get; private set; }

        public IInteractionManager InteractionManager { get; private set; }

        public void ProccessCommand(string command)
        {
            var splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = splittedCommand[0].ToLower();

            switch (commandType)
            {
                case "create":
                    this.ParseCreateCommand(splittedCommand[1], splittedCommand[2]);
                    break;
                case "startexam":
                    string trainerName = splittedCommand[1];
                    this.ExecuteExamCommand(trainerName);
                    break;
                case "status":
                    this.ParseStatusCommand(splittedCommand[1]);
                    break;
                default: InteractionManager.InvalidCommand(); break;
            }
        }

        private void ParseStatusCommand(string name)
        {
            this.InteractionManager.PrintStatus(name);
        }

        private void ParseCreateCommand(string objectType, string objectName)
        {
            switch (objectType.ToLower())
            {
                case "trainer":
                    this.InteractionManager.AddTrainer(objectName);
                    break;
                case "student":
                    this.InteractionManager.AddStudent(objectName);
                    break;
            }

         
        }

        private void ExecuteExamCommand(string trainerName)
        {
            this.InteractionManager.StartExam(trainerName);
        }
    }
}
