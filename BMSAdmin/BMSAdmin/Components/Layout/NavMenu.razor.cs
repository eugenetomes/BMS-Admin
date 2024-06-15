using BMSAdmin.Models.Menus;
using BMSAdmin.Services;
using Microsoft.AspNetCore.Components;

namespace BMSAdmin.Components.Layout;

public partial class NavMenu
{
    [Inject]
    private INavLinkService NavLinkService { get; set; } = null!;

    private List<MenuItem> MenuItems => NavLinkService.MenuItems.OrderBy(x => x.OrderBy).ToList();

    protected override void OnInitialized()
    {

    }
}
