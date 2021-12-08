using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConnectorLibrary;
using TMSObjectLibrary;
using System.Configuration;


namespace TMSUserLibrary
{
    /// <summary>
    /// Buyer derives from User and adds methods CreatOrder(), GetContract(), GenerateInvoice()
    /// </summary>
    public class Planner : TMSUser
    {

        public ObservableCollection<Orders> Orders { get; set; }
        public ObservableCollection<Invoice> Invoices { get; set; }
        public ObservableCollection<Shipment> Shipments { get; set; }

        //private SQLConnector sqlcTMS;
        private SQLConnector sqlc;

        public Planner() : base("planner")
        {

        }

        public void incrementDay()
        {
            DateTime today = DateTime.Now;
            DateTime dateInc = today.AddDays(1);
        }

        /// <summary>
        /// Method AdvanceTime
        /// </summary>
        public ObservableCollection<Orders> advanceTime()
        {
            //create a list in which to store the data
            List<List<string>> timeAdvanced = new List<List<string>>();

            //retrieve the data
            if (sqlcTMS.incrementDay("orders", "orderCompleteDate", 1, out timeAdvanced))
            {
                //get the number of orders
                int numberOfOrders = timeAdvanced[0].Count;

                //create a list of orders
                ObservableCollection<Orders> ordersFetched = new ObservableCollection<Orders>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberOfOrders; ++i)
                    {
                        Orders orders = new Orders();
                        orders.OrderCompleteDate = timeAdvanced[0][i];
                        ordersFetched.Add(orders);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return ordersFetched;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method FetchOrderData fetches and orders made by user
        /// </summary>
        public ObservableCollection<Orders> FetchOrderData()
        {
            //create a list in which to store the data
            List<List<string>> orderInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlcTMS.RetrieveFromColumns("orders", "orderID, orderSubmissionDate, orderCompleteDate, orderStatus, jobType, quantity, originCity, destinationCity, vanType, customerID, invoiceID", out orderInfoRetrieved))
            {
                //get the number of orders
                int numberOfOrders = orderInfoRetrieved[0].Count;

                //create a list of orders
                ObservableCollection<Orders> ordersFetched = new ObservableCollection<Orders>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberOfOrders; ++i)
                    {
                        Orders orders = new Orders();
                        Customer customer = new Customer();
                        Invoice invoice = new Invoice();

                        orders.OrderID = int.Parse(orderInfoRetrieved[0][i]);
                        orders.OrderSubmissionDate = orderInfoRetrieved[1][i];
                        orders.OrderCompleteDate = orderInfoRetrieved[2][i];
                        orders.OrderStatus = orderInfoRetrieved[3][i];
                        orders.JobType = orderInfoRetrieved[4][i];
                        orders.Quantity = orderInfoRetrieved[5][i];
                        orders.OriginCity = orderInfoRetrieved[5][i];
                        orders.DestinationCity = orderInfoRetrieved[5][i];
                        orders.VanType = orderInfoRetrieved[5][i];
                        customer.CustomerID = int.Parse(orderInfoRetrieved[0][i]);
                        invoice.InvoiceID = int.Parse(orderInfoRetrieved[0][i]);

                        ordersFetched.Add(orders);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return ordersFetched;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method PAirCarrierToOrder
        /// </summary>
        public string PairCarrierToOrder()
        {
            try
            {
                //clear the tables in the database
                sqlc.ClearTable("orders");
                sqlc.ClearTable("carriers");

                //for each carrier, insert a new row into the database
                foreach (Carrier carrier in this.Carriers)
                {
                    sqlc.InsertRow("carriers (carrierName, FTLRate, LTLRate, ReefCharge)", carrier.GenerateCommaDelimitedString());

                    //for each carrier, add a new row for orders into the database
                    foreach (Orders orders in carrier.Orders)
                    {
                        {
                            sqlc.InsertRow("orders (orderID, orderSubmissionDate, orderCompleteDate, orderStatus, jobType, quantity, originCity, destinationCity, vanType, customerID, invoiceID)", orders.GenerateCommaDelimitedString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                logger.Log(ex.ToString());
                return "Pairing failed.";
            }

            return "Pairing successful.";
        }

        /// <summary>
        /// Method FetchShipmentData
        /// </summary>
        public ObservableCollection<Shipment> FetchShipmentData()
        {
            //create a list in which to store the data
            List<List<string>> shipmentInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlc.RetrieveFromColumns("shipments", "depotID, orderID, shipmentStatus, shipmentQuantity", out shipmentInfoRetrieved))
            {
                //get the number of shipments
                int numberOfShipments = shipmentInfoRetrieved[0].Count;

                //create a list of orders
                ObservableCollection<Shipment> shipmentsFetched = new ObservableCollection<Shipment>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberOfShipments; ++i)
                    {
                        Shipment shipment = new Shipment();

                        shipment.DepotID = int.Parse(shipmentInfoRetrieved[0][i]);
                        shipment.OrderID = int.Parse(shipmentInfoRetrieved[1][i]);
                        shipment.ShipmentStatus = shipmentInfoRetrieved[2][i];
                        shipment.ShipmentQuantity = int.Parse(shipmentInfoRetrieved[3][i]);

                        shipmentsFetched.Add(shipment);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return shipmentsFetched;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method FetchInvoiceData fetches invoices made by user
        /// </summary>
        public ObservableCollection<Invoice> FetchInvoiceData()
        {
            //create a list in which to store the data
            List<List<string>> invoiceInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlcTMS.RetrieveFromColumns("invoices", "invoiceID, amount, dateIssued, datePaid, invoiceStatus", out invoiceInfoRetrieved))
            {
                //get the number of invoices
                int numberOfInvoices = invoiceInfoRetrieved[0].Count;

                //create a list of invoices
                ObservableCollection<Invoice> invoiceFetched = new ObservableCollection<Invoice>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberOfInvoices; ++i)
                    {
                        Invoice invoice = new Invoice();

                        invoice.InvoiceID = int.Parse(invoiceInfoRetrieved[0][i]);
                        invoice.Amount = int.Parse(invoiceInfoRetrieved[1][i]);
                        invoice.DateIssued = invoiceInfoRetrieved[2][i];
                        invoice.DatePaid = invoiceInfoRetrieved[3][i];
                        invoice.InvoiceStatus = invoiceInfoRetrieved[4][i];

                        invoiceFetched.Add(invoice);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return invoiceFetched;
            }
            else
            {
                return null;
            }
        }

    }
}
