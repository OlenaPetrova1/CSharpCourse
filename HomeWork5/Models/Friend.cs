using System.ComponentModel.DataAnnotations;

namespace HomeWork5.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "Friend ID is required")]
        public int FriendId { get; set; }

        [Required (ErrorMessage = "Friend Name empty not allowed") ]
        public string FriendName { get; set; }

        [StringLength(25)]
        public string Place { get; set; }

    }
}
