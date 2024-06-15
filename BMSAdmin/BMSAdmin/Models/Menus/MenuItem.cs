using Microsoft.FluentUI.AspNetCore.Components;

namespace BMSAdmin.Models.Menus;

public class MenuItem
{
    private List<MenuSubItem> _subMenuItems = new List<MenuSubItem>();
    public int OrderBy { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public bool IsHome { get; set; } = false;
    public bool IsGroup { get; set; } = false;
    public Icon Icon { get; set; }
    public string ToolTipMessage { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public IReadOnlyList<MenuSubItem> SubMenuItems => _subMenuItems;

    public MenuItem()
    {
    }

    public MenuItem(int orderBy, string name, bool isHome, bool isGroup, Icon icon, string toolTipMessage, string link)
    {
        OrderBy = orderBy;
        Name = name;
        IsGroup = isGroup;
        Icon = icon;
        ToolTipMessage = toolTipMessage;
        Link = link;
        IsHome = isHome;
    }

    public void AddSubMenu(string name, Icon icon, string toolTipMessage, string link)
    {
        var orderBy = _subMenuItems.Count + 1;
        _subMenuItems.Add(new MenuSubItem(orderBy, name, icon, toolTipMessage, link));
    }
}
