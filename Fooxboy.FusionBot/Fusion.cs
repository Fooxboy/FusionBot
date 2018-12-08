using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    /// <summary>
    /// Работа с ядром
    /// </summary>
    public class Fusion
    {
        IGetUpdates updater;

        public Fusion(IGetUpdates upd, INotCommand notCommand, IFusionSendMessage sendMessage)
        {
            updater = upd;
            Globals.Message = sendMessage;
            Globals.NotCommand = notCommand;
        }

        /// <summary>
        /// Установка команды.
        /// </summary>
        /// <param name="command">экземпляр команды</param>
        public void SetCommand(IFusionCommand command)
        {
            if (Globals.Commands is null) Globals.Commands = new List<IFusionCommand>();
            Globals.Commands.Add(command);
        }

        /// <summary>
        /// Установка массива команд
        /// </summary>
        /// <param name="commands">Массив экземпляров команды</param>
        public void SetCommands(IEnumerable<IFusionCommand> commands)
        {
            if (Globals.Commands != null) throw new ArgumentException("Список команд не пуст. Добавте сразу все команды.");
            else Globals.Commands = (List<IFusionCommand>)commands;
        }

        
        /// <summary>
        /// Начало работы с Ядром бота
        /// </summary>
        /// <param name="token">Токен сообщества</param>
        /// <param name="groupId">Индентификатор группы</param>
        /// <returns></returns>
        public bool Start(object token, long groupId)
        {
            updater.Start(token, groupId);
            updater.MessageNewEvent += NewMessage;
            return true;
        }


        private void NewMessage(Models.MessageVK message)
        {
            Processor.StartProcessor(message);
        }
    }
}
