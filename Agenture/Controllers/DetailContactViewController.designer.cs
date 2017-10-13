// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Agenture
{
    [Register ("DetailContactViewController")]
    partial class DetailContactViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField detailApellido { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField detailIdentificacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView detailImagen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField detailNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (detailApellido != null) {
                detailApellido.Dispose ();
                detailApellido = null;
            }

            if (detailIdentificacion != null) {
                detailIdentificacion.Dispose ();
                detailIdentificacion = null;
            }

            if (detailImagen != null) {
                detailImagen.Dispose ();
                detailImagen = null;
            }

            if (detailNombre != null) {
                detailNombre.Dispose ();
                detailNombre = null;
            }
        }
    }
}