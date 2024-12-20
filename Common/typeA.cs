using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //what can we write inside the namespace?
    //1-class
    //2-struct(stands for structure)
    //interface
    //Enum
    //----------------------------------------------
    //Allowed Access modifier inside the name space
    //internal
    //public
    public class typeA
    {
       ///* private*/ int x;  
       // internal int Y;
       // public int Z;

        #region Definitions
        //write inside the class or struct
        //1-attribute(filed,variable)
        //2-property(full,Automatic, indexer)
        //3-function(constructor-getter/setter-method)
        //4-event
        //-------------------
        //Allowed Access modifier inside the struct
        //1-private
        //2-internal
        //3-public
        //-----------------------
        //Allowed Access modifier inside the class
        //1-private
        //2-private protected
        //3-protected
        //4-internal
        //5-internal protected
        //6-public
        //-------------------------
        //what you can write inside the interface
        //1-signature for property
        //2-signature for method
        //3-defult implemented method
        //-------------------------
        //default access modifiers inside the interface public
        #endregion

    }
}
