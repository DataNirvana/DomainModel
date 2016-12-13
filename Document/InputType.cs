using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {

    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    public enum InputType {
        TextBox=1,
        TextArea=2,
        DropDownList=3,
        DateChooser=4,
        FileChooser=5,
        Trombowyg=6 // This is for html wysiwyg text editing ...
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------------------
    public enum WebDocProcessingStatus {
        NotYetProcessed = 0,
        Success =1,
        NoAction=2, // E.g. because the old version and the new version were the same ....
        Failure=3
    }
}
