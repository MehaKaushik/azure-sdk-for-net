// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Categorical variable represents signal that needs to be analyzed based on the count or duration of occurrence of limited set of defined values. </summary>
    public partial class CategoricalVariable : TimeSeriesVariable
    {
        /// <summary> Initializes a new instance of CategoricalVariable. </summary>
        /// <param name="value"> Value time series expression is used to represent the value of the signal that is going to be categorized. It can evaluate to only &apos;String&apos; or &apos;Long&apos; type for categorical variables. </param>
        /// <param name="defaultCategory"> Represents the default category. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> or <paramref name="defaultCategory"/> is null. </exception>
        public CategoricalVariable(TimeSeriesExpression value, TimeSeriesDefaultCategory defaultCategory)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (defaultCategory == null)
            {
                throw new ArgumentNullException(nameof(defaultCategory));
            }

            Value = value;
            Categories = new ChangeTrackingList<TimeSeriesAggregateCategory>();
            DefaultCategory = defaultCategory;
            Kind = "categorical";
        }

        /// <summary> Initializes a new instance of CategoricalVariable. </summary>
        /// <param name="kind"> Allowed &quot;kind&quot; values are - &quot;numeric&quot; or &quot;aggregate&quot;. While &quot;numeric&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the &quot;aggregate&quot; kind lets you directly aggregate on the event properties without specifying value. </param>
        /// <param name="filter"> Filter over the events that restricts the number of events being considered for computation. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </param>
        /// <param name="value"> Value time series expression is used to represent the value of the signal that is going to be categorized. It can evaluate to only &apos;String&apos; or &apos;Long&apos; type for categorical variables. </param>
        /// <param name="interpolation"> Categorical variable supports only &apos;step&apos; interpolation. </param>
        /// <param name="categories"> &lt;This property needs a description&gt;. </param>
        /// <param name="defaultCategory"> Represents the default category. </param>
        internal CategoricalVariable(string kind, TimeSeriesExpression filter, TimeSeriesExpression value, InterpolationOperation interpolation, IList<TimeSeriesAggregateCategory> categories, TimeSeriesDefaultCategory defaultCategory) : base(kind, filter)
        {
            Value = value;
            Interpolation = interpolation;
            Categories = categories;
            DefaultCategory = defaultCategory;
            Kind = kind ?? "categorical";
        }

        /// <summary> Value time series expression is used to represent the value of the signal that is going to be categorized. It can evaluate to only &apos;String&apos; or &apos;Long&apos; type for categorical variables. </summary>
        public TimeSeriesExpression Value { get; set; }
        /// <summary> Categorical variable supports only &apos;step&apos; interpolation. </summary>
        public InterpolationOperation Interpolation { get; set; }
        /// <summary> &lt;This property needs a description&gt;. </summary>
        public IList<TimeSeriesAggregateCategory> Categories { get; }
        /// <summary> Represents the default category. </summary>
        public TimeSeriesDefaultCategory DefaultCategory { get; set; }
    }
}
