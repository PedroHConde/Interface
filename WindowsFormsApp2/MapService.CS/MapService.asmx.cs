//
// Copyright (c) 2014-2020, MindFusion LLC - Bulgaria
//

using System.Web.Services;
using MindFusion.Mapping.WebForms;

namespace MapService
{
    /// <summary>
    /// Handles generation of map images.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MapService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GenerateMap(string json)
        {
            return MapView.GenerateMap(json);
        }
    }
}
