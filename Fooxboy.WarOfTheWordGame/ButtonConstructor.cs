using Fooxboy.FusionBot;
using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Keyboard;

namespace Fooxboy.WarOfTheWordGame
{
    public static class ButtonConstructor
    {
        public static MessageKeyboardButton ButtonToHome()
        {
            var messageButton = new MessageKeyboardButton();
            messageButton.Action = new MessageKeyboardButtonAction()
            {
                Label = "Домой",
                Payload = new PayloadBuilder("home").BuildToString(),
                Type = KeyboardButtonActionType.Text
            };
            messageButton.Color = KeyboardButtonColor.Default;

            return messageButton;
        }

        public static MessageKeyboardButton ButtonToBattle(long enemy)
        {
            var messageButton = new MessageKeyboardButton();
            messageButton.Action = new MessageKeyboardButtonAction()
            {
                Label = "В бой!",
                Payload = new PayloadBuilder("battle", new List<object>() { "toBattle", enemy.ToString()}).BuildToString(),
                Type = KeyboardButtonActionType.Text
            };
            messageButton.Color = KeyboardButtonColor.Positive;

            return messageButton;
        }

        public static MessageKeyboardButton ButtonCancelBattle(long enemyId)
        {
            var messageButton = new MessageKeyboardButton();
            messageButton.Action = new MessageKeyboardButtonAction()
            {
                Label = "Отменить бой",
                Payload = new PayloadBuilder("battle", new List<object>() { "cancelBattle",enemyId.ToString() }).BuildToString(),
                Type = KeyboardButtonActionType.Text
            };
            messageButton.Color = KeyboardButtonColor.Negative;

            return messageButton;
        }

        public static MessageKeyboardButton ButtonEmenyAcceptBattle(long id)
        {
            var messageButton = new MessageKeyboardButton();
            messageButton.Action = new MessageKeyboardButtonAction()
            {
                Label = "Принимаю",
                Payload = new PayloadBuilder("battle", new List<object>() { "acceptEnemy", id.ToString()}).BuildToString(),
                Type = KeyboardButtonActionType.Text
            };
            messageButton.Color = KeyboardButtonColor.Positive;

            return messageButton;
        }

        public static MessageKeyboardButton ButtonEmenyNotAcceptBattle(long id)
        {
            var messageButton = new MessageKeyboardButton();
            messageButton.Action = new MessageKeyboardButtonAction()
            {
                Label = "Не принимаю",
                Payload = new PayloadBuilder("battle", new List<object>() { "notAcceptEnemy", id.ToString()}).BuildToString(),
                Type = KeyboardButtonActionType.Text
            };
            messageButton.Color = KeyboardButtonColor.Negative;

            return messageButton;
        }
    }
}
