/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AyudaComponent } from './ayuda.component';
import { VersionComponent } from './version/version.component';
import { SoporteComponent } from './soporte/soporte.component';

const routes: Routes = [
  {
    path: '',
    component: AyudaComponent,
    children: [
      {
        path: 'version',
        component: VersionComponent,
      },
      {
        path: 'soporte',
        component: SoporteComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AyudaRoutingModule {
}
