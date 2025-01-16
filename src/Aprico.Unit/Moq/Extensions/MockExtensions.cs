#region region Copyright & License

// Copyright © 2024 - 2025 Aprico Consultants
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using MockQueryable;
using Moq;

namespace Aprico.Moq.Extensions;

[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
public static class MockExtensions
{
	public static Mock<T> AsMock<T>(this T t)
		where T : class
	{
		return Mock.Get(t);
	}

	public static IQueryable<T> AsQueryableMock<T>(this IEnumerable<T> t)
		where T : class
	{
		return t.AsQueryable()
			.BuildMock();
	}
}
