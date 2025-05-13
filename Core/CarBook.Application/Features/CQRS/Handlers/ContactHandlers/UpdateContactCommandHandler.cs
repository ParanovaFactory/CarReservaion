using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand request)
        {
            var contact = await _repository.GetByIdAsync(request.ContactId);
            contact.ContactName = request.ContactName;
            contact.ContactEmail = request.ContactEmail;
            contact.ContactSubject = request.ContactSubject;
            contact.ContactMessage = request.ContactMessage;
            contact.ContactSendDate = request.ContactSendDate;
            await _repository.UpdateAsync(contact);
        }
    }
}
