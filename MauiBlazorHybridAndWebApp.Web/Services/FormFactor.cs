using MauiBlazorHybridAndWebApp.Shared.Services;

namespace MauiBlazorHybridAndWebApp.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}