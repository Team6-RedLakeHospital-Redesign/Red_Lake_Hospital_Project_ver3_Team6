using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Red_Lake_Hospital_Redesign_Team6.Models.ViewModels
{
    public class ListPhotos
    {
        //Admin will see "Create New" and "Edit" links, non-admin will not see these.
        public bool isadmin { get; set; }
        public IEnumerable<PhotoDto> photos { get; set; }
    }
}