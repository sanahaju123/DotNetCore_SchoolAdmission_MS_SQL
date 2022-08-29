using Moq;
using SchoolAdmission.BusinessLayer.Interfaces;
using SchoolAdmission.BusinessLayer.Services;
using SchoolAdmission.BusinessLayer.Services.Repository;
using SchoolAdmission.DataLayer;
using SchoolAdmission.Entities;
using SchoolAdmission.Tests.TestCases.GroceriesManagement.Tests.TestCases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SchoolAdmission.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;

        private readonly IStudentServices _studentServices;
        private readonly IAdmissionServices _admissionServices;
        private readonly IClassroomServices _classroomServices;


        public readonly Mock<IStudentRepository> studentservice = new Mock<IStudentRepository>();
        public readonly Mock<IAdmissionRepository> admissionservice = new Mock<IAdmissionRepository>();
        public readonly Mock<IClassroomRepository> classroomservice = new Mock<IClassroomRepository>();


        private readonly Person _person;
        private readonly Admission _admission;
        private readonly Classroom _classroom;


        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _studentServices = new StudentServices(studentservice.Object);
            _admissionServices = new AdmissionServices(admissionservice.Object);
            _classroomServices = new ClassroomServices(classroomservice.Object);

            _output = output;

            _person = new Person
            {
                PersonID = 1,
                PersonName = "Person1",
                EmailId = "Person@gmail.com",
                Password = "Pass123",
                Personcity = "Mumbai",
            };
            _classroom = new Classroom
            {
                ClassroomId = 1,
                ClassType = "AC",
                Availability = "Yes",
                PerClassFee = 2000,
                StudentCapacity = 150,
            };

            _admission = new Admission
            {
                AdmissionId = 1,
                ClassroomId = 1,
                PersonId = 1,
                NumberofStudents = 150,
            };
        }

        [Fact]
        public async Task<bool> Testfor_RegisterPerson()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                studentservice.Setup(repos => repos.Register(_person)).ReturnsAsync(_person);
                var result = await _studentServices.Register(_person);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Login()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                studentservice.Setup(repos => repos.Login(_person.EmailId,_person.Password));
                var result = await _studentServices.Login(_person.EmailId, _person.Password);
                //Assertion
                if (result == false)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_AddClassroom()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                classroomservice.Setup(repos => repos.AddClassroom(_classroom)).ReturnsAsync(_classroom);
                var result = await _classroomServices.AddClassroom(_classroom);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_AddAdmission()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                admissionservice.Setup(repos => repos.AddAdmission(_admission)).ReturnsAsync(_admission);
                var result = await _admissionServices.AddAdmission(_admission);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_GetAvailableClassroom()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                classroomservice.Setup(repos => repos.GetClassroom());
                var result = await _classroomServices.GetClassroom();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetAllAdmissions()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                admissionservice.Setup(repos => repos.GetAdmission());
                var result = await _admissionServices.GetAdmission();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}