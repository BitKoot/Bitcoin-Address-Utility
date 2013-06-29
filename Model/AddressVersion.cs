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

namespace BtcAddress.Model
{
	/// <summary>
	/// Class containing constant version numbers of different address types.
	/// </summary>
    public class AddressVersion {
        public const byte Bitcoin = 0;
        public const byte Litecoin = 48;
        public const byte Namecoin = 52;
        public const byte Testnet = 111;
    }
}
