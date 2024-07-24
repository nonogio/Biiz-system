using Life;
using Life.UI;
using Life.Network;
using UnityEngine;



namespace PluginTest
{
    public class PluginTest : Plugin
    {
        public PluginTest(IGameAPI aPI) : base(aPI)
        {
        }

        public override void OnPlayerInput(Player player, KeyCode keyCode, bool onUI)
        {
            base.OnPlayerInput(player, keyCode, onUI);

            if (keyCode == KeyCode.V)
            {
                UIPanel panel = new UIPanel("UItest", UIPanel.PanelType.Text);
                panel.SetTitle("paneltest");
                panel.text = ("le panel fonctionne");
                panel.AddButton("fermer", ui => player.ClosePanel(ui));

                player.ShowPanelUI(panel);
            }
        }
    }
}