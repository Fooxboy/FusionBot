using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Keyboard;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBot.VkNetSupport
{
    public class KeyboardBuilder
    {
        private readonly List<List<MessageKeyboardButton>> fullKeyboard = new List<List<MessageKeyboardButton>>();
        private List<MessageKeyboardButton> currentLine = new List<MessageKeyboardButton>();
        private bool oneTime = false;
        public KeyboardBuilder AddButton(string label, PayLoadModelFusion payLoad, KeyboardButtonColor color = default(KeyboardButtonColor))
        {
            color = color ?? KeyboardButtonColor.Default;
            var button = new MessageKeyboardButton();
            currentLine.Add(new MessageKeyboardButton
            {
                Color = color,
                Action = new MessageKeyboardButtonAction
                {
                    Label = label,
                    Payload = PayloadBuilder.BuildModel(payLoad),
                    Type = KeyboardButtonActionType.Text
                }
            });

            return this;
        }

        public void AddButton(string v, PayloadBuilder payloadBuilder, object keyboardButionColor)
        {
            throw new NotImplementedException();
        }

        public KeyboardBuilder AddLine()
        {
            fullKeyboard.Add(currentLine);
            currentLine = new List<MessageKeyboardButton>();
            return this;
        }

        public MessageKeyboard Build()
        {
            fullKeyboard.Add(currentLine);

            return new MessageKeyboard
            {
                OneTime = oneTime,
                Buttons = fullKeyboard
            };
        }

        public KeyboardBuilder SetOneTime()
        {
            oneTime = true;
            return this;
        }
    }
}
