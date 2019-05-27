using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

public class CustomCmd : MonoBehaviour {
    public Text outputArea;

    public delegate void CommandFunction(params string[] arguments);
    private Dictionary<string, Command> commands;

    private void Awake()
    {
        commands = new Dictionary<string, Command>() {
        {"echo", new Command(EchoFunc, "Echo-cho-cho-ho-o", -1)}
    };
    }

    public struct Command {
        public string description;
        public CommandFunction function;
        public int argumentCount;

        public Command(CommandFunction func, string descr, int args) {
            description = descr;
            function = func;
            argumentCount = args;
        }
    }

    public void ParseCommand(Text input) {
        string[] splitInput = input.text.Split(' ');
        string command = splitInput[0];

        if(command == "help") {
            PrintLine("The following commands are available:");
            foreach (string comm in new List<string>(this.commands.Keys)) {
                PrintLine(comm + " - " + commands[comm].description);
            }
            return;
        }

        if(!commands.ContainsKey(command)) {
            PrintError("\"" + command + "\" is not a valid command. Use help to find out more.");
            return;
        }

        Command cmd = commands[command];

        if(cmd.argumentCount == -1 || cmd.argumentCount == splitInput.Length - 1) {
            // Permit any length (ie. echo)
            string[] arguments = new string[splitInput.Length - 1];
            Array.Copy(splitInput, 1, arguments, 0, splitInput.Length - 1);
            cmd.function(arguments);
        }
    }

    private void EchoFunc(params string[] arguments) {
        PrintLine(string.Join(" ", arguments));
    }

    private void PrintLine(string line) {
        outputArea.text += line + "\n";
    }

    private void PrintError(string error) {
        outputArea.text += "<color=red><b>Error:</b>\t" + error + "</color>\n";
    }
}