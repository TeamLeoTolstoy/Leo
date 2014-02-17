using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public interface IRenderable
    {
        MatrixCoords TopLeft { get;}

        //int MatrixSize { get; set; }

        string[,] GetImage();
    }
}
