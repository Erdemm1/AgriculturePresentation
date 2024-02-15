using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workbook = excelPackage.Workbook.Worksheets.Add("Dosya1");
            workbook.Cells[1, 1].Value = "Ürün Adı";
            workbook.Cells[1, 2].Value = "Ürün Kategorisi";
            workbook.Cells[1, 3].Value = "Ürün Stok";

            workbook.Cells[2, 1].Value = "Mercimek";
            workbook.Cells[2, 2].Value = "Bakliyat";
            workbook.Cells[2, 3].Value = "785 kg";

            workbook.Cells[3, 1].Value = "Buğday";
            workbook.Cells[3, 2].Value = "Bakliyat";
            workbook.Cells[3, 3].Value = "1.986 kg";

            workbook.Cells[4, 1].Value = "Havuç";
            workbook.Cells[4, 2].Value = "Sebze";
            workbook.Cells[4, 3].Value = "167 kg";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx");
        }
        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    ContactID = x.ContactId,
                    ContactName = x.Name,
                    ContactMail = x.Mail,
                    ContactDate = x.Date,
                    ContactMessage = x.Message
                }).ToList();
            }
            return contactModels;
        }
        public IActionResult ContactReport()
        {
            using(var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
                workSheet.Cell(1, 3).Value = "Mail Adres";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach(var item in ContactList())
                {
                    workSheet.Cell(contactRowCount,1).Value = item.ContactID;
                    workSheet.Cell(contactRowCount,2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount,3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount,4).Value = item.ContactMessage;
                    workSheet.Cell(contactRowCount,5).Value = item.ContactDate;
                    contactRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajRaporu.xlsx");
                }
            }
        }
        public List<AnnouncementModel> AnnouncementList()
        {
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();
            using (var context = new AgricultureContext())
            {
                announcementModels = context.Annoucements.Select(x => new AnnouncementModel
                {
                    Id = x.AnnoucementId,
                    Status = x.Status,
                    Date = x.Date,
                    Description = x.Description,
                    Title = x.Title
                }).ToList();
            }
            return announcementModels;
        }
        public IActionResult AnnouncementReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Duyuru Listesi");
                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru Başlığı";
                workSheet.Cell(1, 3).Value = "Duyuru Tarihi";
                workSheet.Cell(1, 4).Value = "Duyuru İçeriği";
                workSheet.Cell(1, 5).Value = "Durum";

                int announcementRowCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(announcementRowCount, 1).Value = item.Id;
                    workSheet.Cell(announcementRowCount, 2).Value = item.Title;
                    workSheet.Cell(announcementRowCount, 3).Value = item.Date;
                    workSheet.Cell(announcementRowCount, 4).Value = item.Description;
                    workSheet.Cell(announcementRowCount, 5).Value = item.Status;
                    announcementRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DuyuruRaporu.xlsx");
                }
            }
        }
    }
}
