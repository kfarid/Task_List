using Microsoft.AspNetCore.Mvc;
using Task_List_Dylan.ViewModels;

namespace Task_List_Dylan.Controllers
{
    public class JobController : Controller
    {
        private IJobRepository _repository;

        public JobController(IJobRepository repo)
        {
            _repository = repo;
        }
        [HttpGet]
        [Route("job/all")]
        public IActionResult All()
        {
            return View(_repository.GetJob());
        }

        [HttpPost]
        [Route("job/add")]
        public IActionResult Add(string title)
        {
            //добавляем новый таск
            _repository.Add(title);
            return new RedirectToActionResult("all", "job", null);
        }

        [HttpPost]
        [Route("job/ChangeStatus")]
        public IActionResult ChangeStatus(int ItemId)
        {
            _repository.ChangeJobStatus(ItemId);
            return new RedirectToActionResult("all", "job", null); ;
        }
    }
}