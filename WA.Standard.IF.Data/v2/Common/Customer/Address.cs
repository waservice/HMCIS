using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.Common.Customer
{
    [Serializable]
    public class Address
    {
        private string _addresstype = string.Empty; public string AddressType { get { return this._addresstype; } set { this._addresstype = value; } }
        private string _fulladdress = string.Empty; public string FullAddress { get { return this._fulladdress; } set { this._fulladdress = value; } }
        private string _zipcode = string.Empty; public string ZipCode { get { return this._zipcode; } set { this._zipcode = value; } }
        private string _region = string.Empty; public string Region { get { return this._region; } set { this._region = value; } }
        private string _district = string.Empty; public string District { get { return this._district; } set { this._district = value; } }
        private string _city = string.Empty; public string City { get { return this._city; } set { this._city = value; } }
        private string _locality = string.Empty; public string Locality { get { return this._locality; } set { this._locality = value; } }
        private string _street = string.Empty; public string Street { get { return this._street; } set { this._street = value; } }
        private string _house = string.Empty; public string House { get { return this._house; } set { this._house = value; } }
        private string _housing = string.Empty; public string Housing { get { return this._housing; } set { this._housing = value; } }
        private string _flat = string.Empty; public string Flat { get { return this._flat; } set { this._flat = value; } }
    }
}