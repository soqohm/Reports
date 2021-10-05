using TFlex.DOCs.Model.Macros;
using TFlex.Model.Technology.Macros.ObjectModel;

public class TechnologicalMapsName : MacroProvider
{
    public TechnologicalMapsName(MacroContext context)
        : base(context)
    {
    }

    public override void Run()
    {
    }

    public string ПолучитьИмяФайлаОтчета()
    {
        var объект = ТекущийОбъект;

        if (!объект.Тип.ПорожденОт("Базовый технологический процесс"))
            return "[пустой отчет - объект не техпроцесс]";

        var техпроцесс = (ТехнологическийПроцесс)объект;
        return техпроцесс.Обозначение + " _ " + техпроцесс.Наименование;
    }
}