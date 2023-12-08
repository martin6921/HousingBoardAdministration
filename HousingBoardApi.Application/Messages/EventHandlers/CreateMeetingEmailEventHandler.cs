﻿using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Messages.Events;
using HousingBoardApi.Domain.Mail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Messages.EventHandlers
{
    public class CreateMeetingEmailEventHandler : INotificationHandler<CreateMeetingEmailEvent>
    {
        private readonly IBoardMemberRepository _boardMemberRepository;
        private readonly IMailService _mailService;

        public CreateMeetingEmailEventHandler(IBoardMemberRepository boardMemberRepository, IMailService mailService)
        {
            _boardMemberRepository = boardMemberRepository;
            _mailService = mailService;
        }


        Task INotificationHandler<CreateMeetingEmailEvent>.Handle(CreateMeetingEmailEvent notification, CancellationToken cancellationToken)
        {
            MailRequest mailRequest = new MailRequest
            {
                Subject = $"Nyt møde: {notification.Title}",
                Body = $"Mødet foregår på addressen {notification.AddressLocation}, på datoen {notification.MeetingTime.ToString("dd, MM, yyyy")}, " +
                        $"klokken {notification.MeetingTime.ToString("HH")}",
                RecipientEmailAddresses = _boardMemberRepository.GetAll().Select(b => b.UserName).ToList()
            };

            _mailService.SendEmail(mailRequest);
            return Task.CompletedTask;
        }
    }
}
