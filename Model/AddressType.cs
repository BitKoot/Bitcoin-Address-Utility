// Copyright 2012 Mike Caldwell (Casascius)
// This file is part of Bitcoin Address Utility.

// Bitcoin Address Utility is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Bitcoin Address Utility is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Bitcoin Address Utility.  If not, see http://www.gnu.org/licenses/.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casascius.Bitcoin
{
	/// <summary>
	/// Class containing constant version numbers of different address types.
	/// </summary>
    public static class AddressType {
        public const byte Bitcoin = 0;
        public const byte Litecoin = 48;
        public const byte Namecoin = 52;
        public const byte Testnet = 111;

        public static byte ToAddressType(string type) {
            switch (type)
            {
                case "Namecoin":
                    return AddressType.Namecoin;
                case "Testnet":
                    return AddressType.Testnet;
                case "Litecoin":
                    return AddressType.Litecoin;
                default:
                    return AddressType.Bitcoin;
            }
        }

        public static string FromAddressType(byte addressType)
        {
            switch (addressType)
            {
                case AddressType.Namecoin:
                    return "Namecoin";
                case AddressType.Testnet:
                    return "Testnet";
                case AddressType.Litecoin:
                    return "Litecoin";
                default:
                    return "Bitcoin";
            }
        }
    }
}
