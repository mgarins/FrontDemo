using Newtonsoft.Json;

using System;
using System.Collections.Generic;


namespace FrontWebApp.Business
{
    public class AccountModel
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("AmountDue")]
        public float AmountDue { get; set; }
        [JsonProperty("PaymentDueDate")]
        public DateTime? PaymentDueDate { get; set; }
        [JsonProperty("AccountStatusId")]
        public int AccountStatusId { get; set; }
    }
}
