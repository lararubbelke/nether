﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Nether.Analytics.Parsers
{
    public interface IMessageParser<T>
    {
        IMessage ParseMessage(T msg);
    }
}