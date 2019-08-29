using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Jp.Application.ViewModels
{
    public class ProfilePictureViewModel
    {
        [Required(ErrorMessage = "Invalid image")]
        public string Filename { get; set; }
        [Required(ErrorMessage = "Invalid image")]
        public string FileType { get; set; }
        [Required(ErrorMessage = "Invalid image")]
        public string Value { get; set; }

        public long? Id { get; set; }
        [JsonIgnore]
        public string Picture { get; set; }
    }
}
