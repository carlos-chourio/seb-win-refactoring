﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using SafeExamBrowser.Contracts.Communication;
using SafeExamBrowser.Contracts.Communication.Messages;
using SafeExamBrowser.Contracts.Communication.Responses;
using SafeExamBrowser.Contracts.Logging;
using SafeExamBrowser.Core.Communication;

namespace SafeExamBrowser.Core.UnitTests.Communication
{
	internal class BaseProxyImpl : BaseProxy
	{
		public BaseProxyImpl(string address, IProxyObjectFactory factory, ILogger logger) : base(address, factory, logger)
		{
		}

		public override bool Connect(Guid? token = null, bool autoPing = false)
		{
			return base.Connect(token, autoPing);
		}

		public override bool Disconnect()
		{
			return base.Disconnect();
		}

		public new Response Send(Message message)
		{
			return base.Send(message);
		}
	}
}