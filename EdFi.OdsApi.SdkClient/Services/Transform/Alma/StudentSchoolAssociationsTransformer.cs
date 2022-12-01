using Alma.Api.Sdk.Models;
using EdFi.AlmaToEdFi.Cmd.Services.Transform.Descriptor;
using EdFi.OdsApi.Sdk.Models.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EdFi.AlmaToEdFi.Cmd.Services.Transform.Alma
{
    public interface IStudentSchoolAssociationsTransformer
    {
        List<EdFiStudentSchoolAssociation> TransformSrcToEdFi(int schoolId, Enrollment srcEnrollment, StudentsGradeLevels studentGradeLevels, List<GradeLevel> gradeLevels);
        List<EdFiStudentSchoolAssociation> TransformSrcToEdFi(int schoolId,  StudentsGradeLevels studentGradeLevels, List<GradeLevel> gradeLevels);
    }
    public class StudentSchoolAssociationsTransformer : IStudentSchoolAssociationsTransformer
    {
        private readonly IDescriptorMappingService _descriptorMappingService;
        public StudentSchoolAssociationsTransformer(IDescriptorMappingService descriptorMappingService)
        {
            _descriptorMappingService = descriptorMappingService;
        }
        public List<EdFiStudentSchoolAssociation> TransformSrcToEdFi(int schoolId, StudentsGradeLevels studentGradeLevels, List<GradeLevel> gradeLevels)
        {
            var edFiStudentSchoolAssociations = new List<EdFiStudentSchoolAssociation>();
            var schoolReference = new EdFiSchoolReference(schoolId, null);
            foreach (var student in studentGradeLevels.students)
            {

                foreach (var gradeLevelItem in student.GradeLevels)
                {

                    var studentReference = new EdFiStudentReference(student.id, null);
                    var gradeEnrollment = gradeLevels.Where(gl => gl.id == gradeLevelItem.gradeLevelId && gl.schoolYearId == gradeLevelItem.schoolYearId).ToList();
                    if (gradeEnrollment.Count > 0)
                        edFiStudentSchoolAssociations.Add(new EdFiStudentSchoolAssociation(null, Convert.ToDateTime(gradeEnrollment.SingleOrDefault().effectiveDate), null, null, null, schoolReference, null,
                                studentReference, null, null, null, GetEdFiGradeLevelDescriptors(gradeEnrollment.SingleOrDefault().gradeLevelAbbr)));
                }
            }

            return edFiStudentSchoolAssociations;
        }
        public List<EdFiStudentSchoolAssociation> TransformSrcToEdFi(int schoolId, Enrollment srcEnrollment, StudentsGradeLevels studentGradeLevels, List<GradeLevel> gradeLevels)
        {
            var edFiStudentSchoolAssociations = new List<EdFiStudentSchoolAssociation>();
            var schoolReference = new EdFiSchoolReference(schoolId, null);
            var studentReference = new EdFiStudentReference(srcEnrollment.studentId, null);
            var studentGradeLevelEnrollment = studentGradeLevels.students.FirstOrDefault(x => x.id == srcEnrollment.studentId).GradeLevels;
            foreach (var gradeLevel in studentGradeLevelEnrollment)
            {
                var gradeEnrollment = gradeLevels.Where(gl => gl.id== gradeLevel.gradeLevelId && gl.schoolYearId== gradeLevel.schoolYearId).ToList();
                if(gradeEnrollment.Count>0)
                    edFiStudentSchoolAssociations.Add(new EdFiStudentSchoolAssociation(null, Convert.ToDateTime(srcEnrollment.date), null, null, null, schoolReference, null,
                            studentReference, null, null, null, GetEdFiGradeLevelDescriptors(gradeEnrollment.SingleOrDefault().gradeLevelAbbr)));
            }

            return edFiStudentSchoolAssociations;
        }
        private string  GetEdFiGradeLevelDescriptors(string  scrGradelevel)
        {
            return _descriptorMappingService.MappAlmaToEdFiDescriptor("GradeLevelDescriptor", scrGradelevel);
        }
    }
}
