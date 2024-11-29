using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class CommandInvoker
    {
        private static Stack<ICommand> undoStack = new Stack<ICommand>();
        private static Stack<ICommand> redoStack = new Stack<ICommand>();
        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
        }
        public static void UndoCommand()
        {
            if (undoStack.Count > 0)
            {
                ICommand activeCommand = undoStack.Pop();
                activeCommand.Undo();
                redoStack.Push(activeCommand);
            }
            else
            {
                Debug.Log("Out of undo");
            }
        }

        public static void RedoCommand()
        {
            if (redoStack.Count > 0)
            {
                ICommand activeCommand = redoStack.Pop();
                activeCommand.Redo();
            }
            else
            {
                Debug.Log("Out of redo");
            }
        }
    }
}
