using NewYearEve.resx.model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewYearEve.Models
{
    public class GuestResponse
    {
        [DisplayName(resx_model_GuestResponse.Label_Name)]
        [Required(AllowEmptyStrings =false,ErrorMessage =resx_model_GuestResponse.Required_Name)]
        public string? Name { get; set; }
        //-----------------------------------
        [DisplayName(resx_model_GuestResponse.Label_Email)]
        [Required(AllowEmptyStrings = false, ErrorMessage = resx_model_GuestResponse.Required_Email)]
        public string? Email { get; set; }
        //-----------------------------------
        [DisplayName(resx_model_GuestResponse.Label_Phone)]
        [Required(AllowEmptyStrings = false, ErrorMessage = resx_model_GuestResponse.Required_Phone)]
        public string? Phone { get; set; }
        //-----------------------------------
        [DisplayName(resx_model_GuestResponse.Label_Attend)]
        [Required(AllowEmptyStrings = false, ErrorMessage = resx_model_GuestResponse.Required_Attend)]
        public bool? WillAttend { get; set; }
        //-----------------------------------


    }
}
