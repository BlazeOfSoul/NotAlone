using NotAlone.Models;
using System;

namespace NotAlone.Services
{
    public class CreateMessageService : ICreateMessageService
    {
        public string CreateMessage(LoverModel fromLover, LoverModel toLover)
        {
            string sex;
            if(toLover.LoverSex == "�������")
            {
                sex = "��";
            }
            else
            {
                sex = "���";
            }

            string eventAim;
            if(toLover.EventAim == "��� ��������")
            {
                eventAim = "����� ��������� ��� ������";
            }
            else
            {
                eventAim = toLover.EventAim;
            }

            string faculty;
            if(toLover.Faculty == "�� ���")
            {
                faculty = "����� ��������� � ������ �� ����������! ���, �� ���� ������� �� �� ���!";
            }
            else
            {
                faculty = $"����� ��������� � ������ {sex} ����������. ���, ��������� - {toLover.Faculty}!";
            }

            string comment;
            if(toLover.PartnerComment == "")
            {
                comment = "����, �� ���� �� �������� �������� ��������.";
            }
            else
            {
                comment = $"���-�, � ��� ��� ���� ��� � �������� ��������: \"{toLover.PartnerComment}\".";
            }

            string message = $"� �������� ���� ����! \n ��� ������ �������� - {toLover.Name} � ��� ���� � ���� ����������� - {eventAim}.\n" +
                $"������ �� ������ �������� - {toLover.VkURL}. \n {faculty} \n ���-���, � ��� ������� ��� {sex} - {toLover.Temperament}," +
                $" � �� ����� {sex} - {toLover.ZodiakSign}. � ���� �� �����: {toLover.Height}, ����� ��, �� ��������?\n" +
                $"��� �� ��� ���� ����������, ��. ��������� � �������� - {toLover.AlcoholRelation}, � � ������� - {toLover.SmokeRelation}. \n" +
                $" {comment} \n�� � �������, ����� ����!";

            return message;
        }
    }
}