using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot
{
    /// <summary>
    /// Работа с ядром
    /// </summary>
    public class Fusion
    {
        IGetUpdates updater;

        public Fusion(IGetUpdates upd, IFusionCommand notCommand, IFusionSendMessage sendMessage)
        {
            updater = upd;
            Globals.Message = sendMessage;
            Globals.NotCommand = notCommand;
        }

        /// <summary>
        /// Установка команды.
        /// </summary>
        /// <param name="command">экземпляр команды</param>
        [Obsolete("Метод устарел, используйте SetCommands. Использовать в случае добавления динамически новой команды.")]
        public void SetCommand(IFusionCommand command)
        {
            if (Globals.Commands is null) Globals.Commands = new List<IFusionCommand>();
            Globals.Commands.Add(command);
        }

        /// <summary>
        /// Установка массива команд
        /// </summary>
        /// <param name="commands">Массив экземпляров команды</param>
        public void SetCommands(params IFusionCommand[] commands)
        {
            if (Globals.Commands != null) throw new ArgumentException("Список команд не пуст. Добавте сразу все команды. Или используйте SetCommand");
            else Globals.Commands = commands.ToList();
        }

        
        /// <summary>
        /// Начало работы с Ядром бота
        /// </summary>
        /// <param name="token">Токен сообщества</param>
        /// <param name="groupId">Индентификатор группы</param>
        /// <returns></returns>
        public bool Start(object token, long groupId)
        {
            Globals.TokenGroup = (string)token;
            updater.MessageNewEvent += NewMessage;
            Task.Run(() => updater.Start(token, groupId));
            return true;
        }


        private void NewMessage(Models.MessageVK message)
        {
            Processor.StartProcessor(message);
        }
    }
}
