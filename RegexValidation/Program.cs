using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string ItemToCheck = "GDP Sections";
            string ItemPattern = @"^([A-Za-z\s]+)$";
            CheckInvoice ItemValidate = new CheckInvoice(ItemToCheck, ItemPattern);
            ItemValidate.Validate("Item");
            Console.ReadKey();

            string InvoiceToCheck = "O/11/21";
            string InvoicePattern = @"^([A-Z])\/([0-9]{2})\/([0-9]{2})$";
            CheckInvoice Invoice = new CheckInvoice(InvoiceToCheck, InvoicePattern);
            Invoice.Validate("Invoice");
            Console.ReadKey();

            string CCDToCheck = "10707090-021017-0013452";
            string CCDPattern = @"^([0-9]{8})-([0-9]{6})-([0-9]{7})$";
            CheckInvoice CCD = new CheckInvoice(CCDToCheck, CCDPattern);
            CCD.Validate("CCD");
            Console.ReadKey();

            string DateToCheck = "2017-11-18";
            string DatePattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";
            //TODO - Complete Date validation fully
            CheckInvoice DateValidate = new CheckInvoice(DateToCheck, DatePattern);
            DateValidate.Validate("Date");
            Console.ReadKey();

            string PositionToCheck = "1";
            string PostitionPattern = @"^([1-9]+)$";
            CheckInvoice PositionValidate = new CheckInvoice(PositionToCheck, PostitionPattern);
            PositionValidate.Validate("Position in CCD");


            Console.ReadKey();
        }
    }

}
