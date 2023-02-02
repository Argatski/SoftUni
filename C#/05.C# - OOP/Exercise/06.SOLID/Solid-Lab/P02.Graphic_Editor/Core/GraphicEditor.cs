using P02.Graphic_Editor.Models;
using P02.Graphic_Editor.Models.Interfaces;

namespace P02.Graphic_Editor.Core
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
