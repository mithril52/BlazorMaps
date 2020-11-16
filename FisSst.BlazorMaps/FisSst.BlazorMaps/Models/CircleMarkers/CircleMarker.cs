﻿using FisSst.BlazorMaps.JsInterops.Events;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace FisSst.BlazorMaps
{
    public class CircleMarker : Path
    {
        private readonly string toGeoJSON = "toGeoJSON";
        private readonly string setLatLng = "setLatLng";
        private readonly string getLatLng = "getLatLng";
        private readonly string setRadius = "setRadius";
        private readonly string getRadius = "getRadius";

        internal CircleMarker(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop)
        {
            JsReference = jsReference;
            EventedJsInterop = eventedJsInterop;
        }

        public async Task<object> ToGeoJSON()
        {
            return await this.JsReference.InvokeAsync<object>(toGeoJSON);
        }

        public async Task<CircleMarker> SetLatLng(LatLng latLng)
        {
            await this.JsReference.InvokeAsync<IJSObjectReference>(setLatLng, latLng);
            return this;
        }

        public async Task<LatLng> GetLatLng()
        {
            return await this.JsReference.InvokeAsync<LatLng>(getLatLng);
        }

        public async Task<CircleMarker> SetRadius(LatLng latLng)
        {
            await this.JsReference.InvokeAsync<IJSObjectReference>(setRadius, latLng);
            return this;
        }

        public async Task<double> GetRadius()
        {
            return await this.JsReference.InvokeAsync<double>(getRadius);
        }
    }
}