﻿using Alma.Api.Sdk.Extractors.Alma;
using Alma.Api.Sdk.Models;
using Microsoft.Extensions.Logging;
using RestSharp;
using RestSharp.Serializers.Utf8Json;
using System.Collections.Generic;
using System.Linq;

namespace Alma.Api.Sdk.Extractors
{
    public interface ISessionsExtractor
    {
        List<Session> Extract(string almaSchoolCode);
    }

    public class SessionsExtractor : ISessionsExtractor
    {
        private readonly RestClient _client;
        private readonly ISchoolYearsExtractor _schoolYearsExtractor;
        public SessionsExtractor(IAlmaRestClientConfigurationProvider client, 
                                 ISchoolYearsExtractor schoolYearsExtractor)
        {
            _client = client.GetRestClient();
            _schoolYearsExtractor = schoolYearsExtractor;
        }
        public List<Session> Extract(string almaSchoolCode)
        {
            var almaSchoolYears = _schoolYearsExtractor.Extract(almaSchoolCode);

            // NOTE: In Alma they have a different way of looking at Terms and Sessions.
            // They are calling these grading-periods.
            var request = new RestRequest($"v2/{almaSchoolCode}/grading-periods", DataFormat.Json);
            var response = _client.Get(request);
            //Deserialize JSON data
            var schoolGradingPeriods = new Utf8JsonSerializer().Deserialize<SessionsResponse>(response);
            schoolGradingPeriods.response.ForEach(gP =>
            {
                gP.SchoolYear = almaSchoolYears.SingleOrDefault(x => x.id == gP.schoolYearId);
            });
            return schoolGradingPeriods.response;
        }
    }
}
