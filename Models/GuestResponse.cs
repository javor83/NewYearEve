using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewYearEve.Models
{
    public class GuestResponse
    {
        [DisplayName(const_caption_GuestResponse.Label_Name)]
        [Required(AllowEmptyStrings =false,ErrorMessage =const_caption_GuestResponse.Required_Name)]
        public string? Name { get; set; }
        //-----------------------------------
        [DisplayName(const_caption_GuestResponse.Label_Email)]
        [Required(AllowEmptyStrings = false, ErrorMessage = const_caption_GuestResponse.Required_Email)]
        public string? Email { get; set; }
        //-----------------------------------
        [DisplayName(const_caption_GuestResponse.Label_Phone)]
        [Required(AllowEmptyStrings = false, ErrorMessage = const_caption_GuestResponse.Required_Phone)]
        public string? Phone { get; set; }
        //-----------------------------------
        [DisplayName(const_caption_GuestResponse.Label_Attend)]
        [Required(AllowEmptyStrings = false, ErrorMessage = const_caption_GuestResponse.Required_Attend)]
        public bool? WillAttend { get; set; }
        //-----------------------------------


    }
}
