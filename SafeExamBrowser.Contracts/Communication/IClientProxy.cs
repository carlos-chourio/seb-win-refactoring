﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Communication.Responses;

namespace SafeExamBrowser.Contracts.Communication
{
	public interface IClientProxy : ICommunicationProxy
	{
		/// <summary>
		/// Instructs the client to submit its authentication data.
		/// </summary>
		IAuthenticationResponse RequestAuthentication();
	}
}