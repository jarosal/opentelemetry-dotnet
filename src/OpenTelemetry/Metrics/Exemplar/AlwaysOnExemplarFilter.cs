// <copyright file="AlwaysOnExemplarFilter.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace OpenTelemetry.Metrics;

/// <summary>
/// An ExemplarFilter which makes all measurements eligible for being an Exemplar.
/// </summary>
public sealed class AlwaysOnExemplarFilter : ExemplarFilter
{
    public override bool ShouldSample(long value, ReadOnlySpan<KeyValuePair<string, object>> tags)
    {
        return true;
    }

    public override bool ShouldSample(double value, ReadOnlySpan<KeyValuePair<string, object>> tags)
    {
        return true;
    }
}
