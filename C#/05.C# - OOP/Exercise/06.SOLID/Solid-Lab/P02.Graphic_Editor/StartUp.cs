using P02.Graphic_Editor.Core;
using P02.Graphic_Editor.Models;

namespace P02.Graphic_Editor
{
    public class StartUp
    {
        static void Main()
        {
            GraphicEditor graphicEditor = new GraphicEditor();

            graphicEditor.DrawShape(new Circle());
            graphicEditor.DrawShape(new Rectangle());
            graphicEditor.DrawShape(new Square());
        }
    }
}
