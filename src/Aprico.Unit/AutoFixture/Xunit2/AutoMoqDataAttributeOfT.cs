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

using System.Diagnostics.CodeAnalysis;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace Aprico.AutoFixture.Xunit2;

[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
public sealed class AutoMoqDataAttribute<T> : AutoDataAttribute
	where T : CompositeCustomization, new()
{
	// @formatter:keep_existing_arrangement true
	public AutoMoqDataAttribute() : base(
		static () => new Fixture()
			.Customize(new AutoMoqCustomization())
			.Customize(new T())) { }
}
