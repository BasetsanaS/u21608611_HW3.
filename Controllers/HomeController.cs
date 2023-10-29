using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21608611_HW3.Models;
using System.Web.UI.DataVisualization.Charting;
using System.Text;

namespace u21608611_HW3.Controllers
{
    public class HomeController : Controller
    {
        private LibraryEntities db = new LibraryEntities();

        public ActionResult Index()
        {
            var newModel = new StudentBookModel
            {
                studentData = db.students.ToList(),
                bookData = db.books.ToList(),

            };
            return View(newModel);
        }

        public ActionResult Maintain()
        {
            var newModel = new Maintain
            {
                authorData = db.authors.ToList(),
                typeData = db.types.ToList(),
                borrowData = db.borrows.ToList(),

            };
            return View(newModel);
        }

        LibraryEntities2 db1 = new LibraryEntities2();

        public ActionResult ChartFromEF()
        {
            var data = db1.FetchStudents().ToList();
            var chart = new Chart();
            var area = new ChartArea();
            chart.ChartAreas.Add(area);
            var series = new Series();

            series.ChartType = SeriesChartType.Bar;

            foreach (var item in data)
            {
                series.Points.AddXY(item.gender, item.point);
            }

            chart.Series.Add(series);

            chart.Height = 300;
            chart.Titles.Add(new Title("Student Data"));
            chart.ChartAreas[0].AxisX.Title = "gender";
            chart.ChartAreas[0].AxisY.Title = "point";

            var returnStream = new MemoryStream();
            chart.ImageType = ChartImageType.Png;
            chart.SaveImage(returnStream);

            byte[] chartBytes = returnStream.ToArray();
            return File(chartBytes, "image/png");
        }

        public ActionResult Report()
        {
            return View();
        }



    }
}