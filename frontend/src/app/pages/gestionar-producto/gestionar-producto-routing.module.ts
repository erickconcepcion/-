/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GestionarProductoComponent } from './gestionar-producto.component';
/* import { GmapsComponent } from './gmaps/gmaps.component';
import { LeafletComponent } from './leaflet/leaflet.component';
import { BubbleMapComponent } from './bubble/bubble-map.component';
import { SearchMapComponent } from './search-map/search-map.component';
import { MapComponent } from './search-map/map/map.component';
import { SearchComponent } from './search-map/search/search.component'; */

const routes: Routes = [{
  path: '',
  component: GestionarProductoComponent,
  children: [{
    path: 'gmaps',
    /* component: GmapsComponent, */
  }, {
    path: 'leaflet',
    /* component: LeafletComponent, */
  }, {
    path: 'bubble',
    /* component: BubbleMapComponent, */
  }, {
    path: 'searchmap',
    /* component: SearchMapComponent, */
  }],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class GestionarProductoRoutingModule { }

export const routedComponents = [
  GestionarProductoComponent,
 /*  GmapsComponent,
  LeafletComponent,
  BubbleMapComponent,
  SearchMapComponent,
  MapComponent,
  SearchComponent, */
];
