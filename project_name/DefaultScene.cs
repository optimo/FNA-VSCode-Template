using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace project_name
{
	public class DefaultScene : Scene
    {
        public override void Initialize()
        {
            SetDesignResolution(Screen.Width, Screen.Height, Scene.SceneResolutionPolicy.None);

            CreateEntity("demo imgui draw commands")
                .SetPosition(new Vector2(150, 150))
                .AddComponent<DemoComponent>()
                .AddComponent(new PrototypeSpriteRenderer(20, 20));

            var logo = Content.LoadTexture("Content/Textures/nez-logo-black.png");
            CreateEntity("logo")
                .SetPosition(Screen.Center)
                .AddComponent(new SpriteRenderer(logo));
        }
    }
}
