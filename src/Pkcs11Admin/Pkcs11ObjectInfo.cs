﻿/*
 *  Pkcs11Admin - GUI tool for administration of PKCS#11 enabled devices
 *  Copyright (c) 2014-2017 Jaroslav Imrich <jimrich@jimrich.sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3 
 *  as published by the Free Software Foundation.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Net.Pkcs11Interop.HighLevelAPI;
using System.Collections.Generic;

namespace Net.Pkcs11Admin
{
    public abstract class Pkcs11ObjectInfo : Pkcs11Info
    {
        public ObjectHandle ObjectHandle
        {
            get;
            internal set;
        }

        public List<ObjectAttribute> ObjectAttributes
        {
            get;
            internal set;
        }

        public ulong? StorageSize
        {
            get;
            internal set;
        }
    }
}
