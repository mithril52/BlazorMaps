﻿using FisSst.BlazorMaps.JsInterops.Events;
using Microsoft.JSInterop;

namespace FisSst.BlazorMaps
{
    public class Polygon : Polyline
    {
        internal Polygon(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop)
            : base(jsReference, eventedJsInterop)
        {
        }
    }
}