﻿using System;

namespace Employee.Library
{
    public class DefaultResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Reason { get; set; }
        public string Data { get; set; }
        public int UserId { get; set; }
    }
}
