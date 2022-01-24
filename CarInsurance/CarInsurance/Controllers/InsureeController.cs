using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        //function for calculating the quote cost
        public static Decimal GetQuote(Insuree insuree)
        {
            //calculate the cost of the quote by adding to the running total variable
            decimal runningTot = 50.00M; //initialized base cost

            //calculate the age of the insuree
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(insuree.DateOfBirth.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            //take into account the user's age
            if (age < 19)
            {
                runningTot += 100.00M;
            }
            else if (age < 26)
            {
                runningTot += 50.00M;
            }
            else
            {
                runningTot += 25.00M;
            }

            //take into account the car's year
            if (insuree.CarYear < 2000)
            {
                runningTot += 25M;
            }
            else if (insuree.CarYear > 2015)
            {
                runningTot += 25M;
            }

            //take into account the car's make and model
            if (insuree.CarMake.ToLower() == "porsche")
            {
                runningTot += 25M;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    runningTot += 25M;
                }
            }

            //take into account the insuree's speeding tickets, if any
            if (insuree.SpeedingTickets != 0)
            {
                runningTot += 10M * insuree.SpeedingTickets;
            }

            //take into account whether the insuree has had at least one DUI
            if (insuree.DUI == true)
            {
                runningTot = runningTot * 1.25M;
            }

            //account for whether the insuree elected for full coverage
            if (insuree.CoverageType == true)
            {
                runningTot = runningTot * 1.50M;
            }

            return runningTot;
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //call on the GetQuote function to calculate the quote specific to this new insuree
                insuree.Quote = GetQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //call on the function GetQuote to calculate the quote specific to the existing insuree 
                insuree.Quote = GetQuote(insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
