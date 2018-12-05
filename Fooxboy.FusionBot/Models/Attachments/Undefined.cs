using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Undefined: IAttachment
    {
        public string Title
        {
            get => "Тип этого вложения не поддерживается.";
        }

        public override string ToString()
        {
            return "Вложение";
        }

        public string ToMore() => "Вложения";
        public string ToMoreTwo() => "Вложений";
    }
}
