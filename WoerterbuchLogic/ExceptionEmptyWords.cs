using System;

namespace WoerterbuchLogic
{
    public class ExceptionEmptyWords : Exception
    {
        public override string Message => "Neuer Eintrag konnte nicht hinzugefügt werden!\n\n Wort/Wörter sind leer";
    }
}
