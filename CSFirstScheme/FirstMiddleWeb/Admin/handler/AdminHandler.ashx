<%@ WebHandler Language="C#" Class="AdminHandler" %>

using System;
using System.Web;
using System.Reflection;

public class AdminHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string savePath = context.Server.MapPath("~/App_Data/FirstMiddle.xls");

        string action = context.Request["action"];
        if (!string.IsNullOrEmpty(action))
        {
           MethodInfo method = this.GetType().GetMethod(action);
           method.Invoke(this, new object[] { context });
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}