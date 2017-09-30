using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    public DAL()
    {
        //
        // TODO: Add constructor logic here
        //

        

    }
    public static DataRow GetAll()
    {
        string Sql = "Select * FROM student ";
        return DbUtils.SelectDataRow(Sql);
    }
    //add customer-adminCustomer
    /*public static void AddCustomer(int TxtCustomerId, string TxtFN, string TxtLN, string Txtbirthdate, string Txtaddress
        , int  txtcountry,  int txtcity, string TxtEamil, string Txtphone, string Txtpostalcode
        , string Txtusername, string Txtpassword, string TxtCreditnumber, string Txtcardtype, string TxtExpiredmonth
        , string TxtExpiredYear, string TxtSecurityCode)*/
    public static void AddCustomer(Customer customer,Label lbl)
    {
        string cardtype = customer.CardType;
        if ((cardtype == "Visa") || (cardtype == "visa") || (cardtype == "MasterCard") || (cardtype == "mastercard") || (cardtype == "American Express") || (cardtype == "american express"))
        {
            
                string sql = @"INSERT INTO Customer(CustomerId,FirstName,LastName,BirthDate,Address,CountryId,CityId,Email,PhoneNumber,
                                            PostalCode,UserName,Password,CreditCardNumber,CardType,ExpiredMonth,ExpiredYear,
                                            SecurityCode)Values" + "('" + customer.CustomerId + "','" + customer.FirstName + "' ,'" +
                              customer.LastName + "',CAST('"+customer.BirthDate+"' AS datetime) ,'" +
                              customer.Address + "' ,'" +
                              customer.CountryId + "','" +
                              customer.CityId + "','" +
                              customer.Email + "','" +
                              customer.PhoneNumber + "','" +
                              customer.PostalCode + "','" +
                              customer.UserName + "' ,'" +
                              customer.Password + "','" +
                              customer.CreditCardNumber + "','" +
                              customer.CardType + "' ,'" +
                              customer.ExpiredMonth + "','" +
                              customer.ExpiredYear + "','" +
                              customer.SecurityCode + "')";

                DbUtils.ExNonQuery(sql);
            }
         
               
        
        else
        {
            lbl.Text = "The card Types that available are only: Visa, MasterCard or AmericanExpress";
            lbl.Visible = true;
        }
    }

    public static void UpdateCustomer(Customer customer)
    {
//        string sql = @"UPDATE Customer SET 
//                     FirstName ='" + customer.FirstName + "' where customerid=" + customer.CustomerId + "";

//        DbUtils.ExNonQuery(sql);

        //customer.UpdateCustomerFirstName(customer);
        //customer.UpdateCustomerAddress(customer);
        //customer.UpdateCustomerBirthdate(customer);
        //customer.UpdateCustomerCardType(customer);
        //customer.UpdateCustomerCity(customer);
        //customer.UpdateCustomerCountry(customer);
        //customer.UpdateCustomerCreditCardNumber(customer);
        //customer.UpdateCustomerEmail(customer);
        //customer.UpdateCustomerExpiredMonth(customer);
        //customer.UpdateCustomerExpiredYear(customer);
        //customer.UpdateCustomerLastName(customer);
        //customer.UpdateCustomerPassword(customer);
        //customer.UpdateCustomerPhoneNumber(customer);
        //customer.UpdateCustomerPostalCode(customer);
        //customer.UpdateCustomerSecurityCode(customer);
        //customer.UpdateCustomerUserName(customer);

      
    }
    
    
    
}
