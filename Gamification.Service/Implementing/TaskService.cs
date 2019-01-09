using System;
using Gamification.Application.BusinessTask;
using Gamification.Service.DataModel;
using System.Collections.Generic;

namespace Gamification.Service.Implementing
{
    public interface ITaskService
    {
        ResponseBase CreateTask(TaskView taskView);
        ResponseBase UpdateTask(TaskView taskView);
        ResponseBase DeleteTask(Guid taskId);
        TaskView GetTask(Guid taskId);
        IList<TaskView> GetAllTasks();
        IList<TaskView> GetAllPendingTasks();
    }

    internal class TaskService : ITaskService
    {
        private readonly ITaskBusiness _taskBusiness;

        public TaskService(ITaskBusiness taskBusiness)
        {
            _taskBusiness = taskBusiness;
        }

        public ResponseBase CreateTask(TaskView taskView)
        {
            var response = new ResponseBase();

            try
            {
                var task = taskView.ToModel();
                _taskBusiness.Add(task);
                _taskBusiness.SaveChanges();
                response.Suceeded = true;
                response.Message = TaskMessages.TaskCreatedSuccessfully;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = TaskMessages.TaskCreationFaild;
            }

            return response;
        }

        public ResponseBase UpdateTask(TaskView taskView)
        {
            var response = new ResponseBase();

            try
            {
                var task = taskView.ToModel();
                _taskBusiness.Update(task);
                _taskBusiness.SaveChanges();
                response.Suceeded = true;
                response.Message = TaskMessages.TaskUpdatedSuccessfully;
            }
            catch (Exception)
            {
                response.Suceeded = false;
                response.Message = TaskMessages.TaskUpdatingFaild;
            }

            return response;
        }

        public ResponseBase DeleteTask(Guid taskId)
        {
            var response = new ResponseBase();

            try
            {
                _taskBusiness.Remove(taskId);
                _taskBusiness.SaveChanges();
                response.Suceeded = true;
                response.Message = TaskMessages.TaskDeletedSuccessfully;
            }
            catch (Exception)
            {
                response.Suceeded = false;
                response.Message = TaskMessages.TaskDeletionFaild;
            }

            return response;
        }

        public TaskView GetTask(Guid taskId)
        {
            var task = _taskBusiness.GetById(taskId);
            return task.ToDataModel();
        }

        public IList<TaskView> GetAllTasks()
        {
            var tasks = _taskBusiness.GetAll();
            return tasks.ToDataModel();
        }

        public IList<TaskView> GetAllPendingTasks()
        {
            var tasks = _taskBusiness.GetAllPendingTasks();
            return tasks.ToDataModel();
        }
    }
}
