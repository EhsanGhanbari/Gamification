using Gamification.Application.BusinessTask;
using Gamification.Service.DataModel;
using System;
using System.Collections.Generic;
using log4net.Core;

namespace Gamification.Service.Implementing
{
    public interface IMessageService
    {
        ResponseBase CreateMessage(MessageView messageView);
        ResponseBase DeleteMessage(Guid messageId);
        MessageView GetMessage(Guid messageId);
        IList<MessageView> GetAllMessages();
    }

    internal class MessageService : IMessageService
    {
        private readonly IMessageBusiness _messageBusiness;
        private readonly ILogger _logger;

        public MessageService(IMessageBusiness messageBusiness)
        {
            _messageBusiness = messageBusiness;
        }

        public ResponseBase CreateMessage(MessageView messageView)
        {
            var response = new ResponseBase();

            try
            {
                var task = messageView.ToModel();
                _messageBusiness.Add(task);
                _messageBusiness.SaveChanges();
                response.Suceeded = true;
                response.Message = MessageMessages.MessageCreatedSuccessfully;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = MessageMessages.MessageCreationFaild;
            }

            return response;
        }

        public ResponseBase DeleteMessage(Guid messageId)
        {
            var response = new ResponseBase();

            try
            {
                var message = _messageBusiness.GetById(messageId);
                message.IsDeleted = true;
                _messageBusiness.Update(message);
                _messageBusiness.SaveChanges();
                response.Suceeded = true;
                response.Message = MessageMessages.MessageCreatedSuccessfully;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = MessageMessages.MessageCreationFaild;
            }

            return response;
        }

        public MessageView GetMessage(Guid messageId)
        {
            var message = _messageBusiness.GetById(messageId);
            return message.ToDataModel();
        }

        public IList<MessageView> GetAllMessages()
        {
            var messages = _messageBusiness.GetAll();
            return messages.ToDataModel();
        }

    }
}
