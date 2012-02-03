using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
	class CommandManager
	{
		List<Command> commandList;

		public CommandManager()
		{
			commandList = new List<Command>();
		}

		public void Undo()
		{
			if (commandList.Count > 0) {
				// 最後に追加したコマンドを戻す
				int index = commandList.Count - 1;
				var command = commandList[index] as UndoCommand;
				command.Undo();

				// リストから削除
				commandList.RemoveAt(index);
			}
		}

		public void Execute(Command command)
		{
			// コマンドを実行
			command.Execute();

			// Undo機能の為にリストに追加する
			commandList.Add(command);
		}
	}
}
