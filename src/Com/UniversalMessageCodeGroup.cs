using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
    [ComVisible(true)]
    [Guid("29160E2C-C634-423A-91FB-B0965D531A73")]
    [XmlType(TypeName = "UniversalMessageCodeGroup", Namespace = "https://diadoc-api.kontur.ru")]
    public enum UniversalMessageCodeGroup
    {
            
        UnknownCodeGroup = 0,
            
        Receipt = 1,
            
        AmendmentRequest = 2,
            
        Rejection = 3,
            
        InformationMessage = 4
    }
}