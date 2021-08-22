using System;

namespace RentalStore.Models
{
    public class ErrorViewModel
    {
        // error handling process
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
