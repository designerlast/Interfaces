using IntellVega.CBB.Interfaces.CunstomMessageBoxResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IMessageBox
    {
        void Info(string message);

        void Success(string message);

        void Warning(string message);

        void Error(string message);

        void Ask(string message, Func<bool, bool> actionBeforeClose);

        MegaMessageBoxResult InfoDialog(string message);

        MegaMessageBoxResult SuccessDialog(string message);

        MegaMessageBoxResult WarningDialog(string message);

        MegaMessageBoxResult ErrorDialog(string message);

        MegaMessageBoxResult AskDialog(string message);
    }
}
