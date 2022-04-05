﻿using System;
using System.Collections.Generic;

namespace Alma.Api.Sdk.Models
{
    public  class SubjectsResponse
    {
        public List<Subject> response { get; set; }
    }
}

public class Subject
{
    public string id { get; set; }
    public string effectiveDate { get; set; }
    public string schoolYearId { get; set; }
    public int EdfiSchoolId { get; set; }
    public string AlmaSchoolId { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public DateTime created { get; set; }
    public DateTime modified { get; set; }
    public string changeLogId { get; set; }
}