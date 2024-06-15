using Microsoft.FluentUI.AspNetCore.Components;

namespace BMSAdmin.Models.Menus;

public class MenuSubItem
{
    public int OrderBy { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public Icon Icon { get; set; }
    public string ToolTipMessage { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;

    public MenuSubItem()
    {
    }

    public MenuSubItem(int orderBy, string name, Icon icon, string toolTipMessage, string link)
    {
        OrderBy = orderBy;
        Name = name;
        Icon = icon;
        ToolTipMessage = toolTipMessage;
        Link = link;
    }
}
