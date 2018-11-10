using System.Web.Mvc;
using AdventureWorks.Services.HumanResources;
using Microsoft.ApplicationInsights;

namespace AdventureWorks.Web.Controllers
{
    public class DepartmentsController : Controller
    {
        private TelemetryClient telemetry = new TelemetryClient();

        // GET: Departments
        public ActionResult Index()
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentGroups = departmentService.GetDepartments();

            telemetry.TrackPageView("Departament home page requested.");

            return View(departmentGroups);
        }

        // GET: Departments/Employees/{id}
        public ActionResult Employees(int id)
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentEmployees = departmentService.GetDepartmentEmployees(id);
            var departmentInfo = departmentService.GetDepartmentInfo(id);

            ViewBag.Title = "Employees in " + departmentInfo.Name + " Department";

            telemetry.TrackPageView($"Employee with id {id} and name {departmentInfo.Name} requested.");

            return View(departmentEmployees);
        }
    }
}
