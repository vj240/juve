// Type: System.Web.Mvc.AreaRegistration
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft ASP.NET\ASP.NET MVC 4\Assemblies\System.Web.Mvc.dll

namespace System.Web.Mvc
{
  public abstract class AreaRegistration
  {
    public static void RegisterAllAreas();
    public static void RegisterAllAreas(object state);
    public abstract void RegisterArea(AreaRegistrationContext context);
    public abstract string AreaName { get; }
  }
}
