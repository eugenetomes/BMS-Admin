using BMSAdmin.Models.Menus;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BMSAdmin.Services;

public interface INavLinkService
{
    List<MenuItem> MenuItems { get; set; }
    MenuItem GetHomeMenuItem(int? orderBy);
}

public class NavLinkService : INavLinkService
{
    public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

    public NavLinkService()
    {
        MenuItems.Add(GetHomeMenuItem(1));
        MenuItems.Add(GetCounter(2));
        MenuItems.Add(GetWeather(3));

    }

    public MenuItem GetHomeMenuItem(int? orderBy)
    {
        var homeMenuItem = new MenuItem(GetNextOrderByNumber(orderBy), "Home", true, false, new Icons.Regular.Size20.Home(), "Home", "/");

        return homeMenuItem;
    }

    private MenuItem GetCounter(int? orderBy)
    {
        var menuItem = new MenuItem(GetNextOrderByNumber(orderBy), "Counter", false, false, new Icons.Regular.Size20.NumberSymbolSquare(), "Counter Tooltip", "counter");
        return menuItem;
    }

    private MenuItem GetWeather(int? orderBy)
    {
        var menuItem = new MenuItem(GetNextOrderByNumber(orderBy), "Weather Section", false, true, new Icons.Regular.Size20.WeatherPartlyCloudyDay(), "Weather Section", "");
        menuItem.AddSubMenu("Weather", new Icons.Regular.Size20.WeatherPartlyCloudyDay(), "Weather", "weather");
        menuItem.AddSubMenu("Weather", new Icons.Regular.Size20.WeatherPartlyCloudyDay(), "Weather", "weather");
        menuItem.AddSubMenu("Weather", new Icons.Regular.Size20.WeatherPartlyCloudyDay(), "Weather", "weather");
        return menuItem;
    }

    private int GetNextOrderByNumber(int? orderBy)
    {
        if (orderBy.HasValue)
        {
            return orderBy.Value;
        }
        return MenuItems.Select(x => x.OrderBy).Max() + 1;
    }
}
